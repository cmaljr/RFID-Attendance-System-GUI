/*This is the RFID reading test to ensure MIFARE cards are properly read.
 * 
 * Instructions:
 * Once the modules are connected and SD card is provided, connect your Arduino to your computer using a USB cable. Compile and upload the code to Arduino. Run the Serial 
 * Monitor under Tools. Change the line ending settings to no new line. Tap the card on the reader, 
  */
#include <SPI.h>
#include <MFRC522.h>
#include <SD.h>
#include <RTClib.h>

#define RST_PIN    9                    //Pin number for Reset on Arduino
#define SDA_PIN     10                  //Pin number for SDA on Arduino

MFRC522 mfrc522(SDA_PIN, RST_PIN);      //MFRC variable
MFRC522::MIFARE_Key key;                //Key variable to access card
File file;                              //File variable
RTC_DS3231 rtc;                         //RTC Clock variable

//Instance Variables 
const int chipSelect = 4;               //Sets CS pin for SD card Module

/*Begins Serial communication bewteen Arduino and connected modules*/
void setup() {
  //Starts communication between Arduino and PC
  Serial.begin(9600);   
  while(!Serial);

  //Initializes SPI bus
  SPI.begin();

  //Initializes MFRC522 Module
  mfrc522.PCD_Init();
   
  //Initializes SD Card Module
  if(!SD.begin(chipSelect)){
    while(1);
  }
  
  //Initializes DS3231 and reclocks time if the module was previously off. Must set time previously through RTClib library.
  if(!rtc.begin()) {
    Serial.flush();
    while (1) delay(10);
  }
  if(rtc.lostPower()) {
    rtc.adjust(DateTime(F(__DATE__), F(__TIME__)));
  }
  Serial.println(F("Initialization complete. Tap your card."));
}

//************************************************************************//

/*The following is the primary loop that runs the main functions of the code*/
void loop() {
  
  //Resets variables
  String cardUID = "";
  String name = "";

  prepareKeys();

  //Resets loop is no card is being read 
  if (!mfrc522.PICC_IsNewCardPresent()) {
    return;
  }
  if (!mfrc522.PICC_ReadCardSerial()) {
    return;
  }

  //Gets card UID
  for (byte i = 0; i < mfrc522.uid.size; i++) {
     cardUID += String(mfrc522.uid.uidByte[i] < 0x10 ? "0" : "");
     cardUID += String(mfrc522.uid.uidByte[i], HEX);
  }

  name = readInfo(1) + " " + readInfo(2);
  Serial.println("UID: " + cardUID + ", Name: " + name);
  

  //Halts PICC from reading and encryption on PCD
  mfrc522.PICC_HaltA();
  mfrc522.PCD_StopCrypto1();
}

//Begins preparation for keys A and B by resetting it to its default key from its manufactor
void prepareKeys() {
  for (byte i = 0; i < 6; i++) {
    key.keyByte[i] = 0xFF;
  }
}

//********************************************************************************************************//

/*Reads given block from RIFD card and returns the data's ASCII values as a string of characters*/
String readInfo(byte block) {
  byte length = 18;
  byte bufferName[18];        //Data buffer for block
  String result;              //Stores data as a string of characters
  
  //Authenticates card using Key A 
  MFRC522::StatusCode status;
  status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, block, &key, &(mfrc522.uid)); 
  if (status != MFRC522::STATUS_OK) {
    return "Authentication failed, " + (String) mfrc522.GetStatusCodeName(status);
  }

  //Reads block
  status = mfrc522.MIFARE_Read(block, bufferName, &length);
  if (status != MFRC522::STATUS_OK) {
    return "Authentication failed, " + (String) mfrc522.GetStatusCodeName(status);
  }

  //Converts bytes to ASCII values and displays the conversion to Serial
  for (uint8_t i = 0; i < 16; i++){
    if(bufferName[i] != 32) {
      result += (char)bufferName[i];  //Stores data in variable to return
    }
  }
  //Serial.print(" ");
  return result;
}

//**************************************************************************//

bool readSuccess(String readData) {
  if(readData.equals("Fail")) {
    return false;
  }
  return true;
}

//**************************************************************************//

/*Halts loop until information is available in serial*/
void wait() {
  while (Serial.available() == 0) {};
}
