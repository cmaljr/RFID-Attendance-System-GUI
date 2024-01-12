/*The following project is an attendence system prototype using RFID technology and hardware. It allows users to scan a Mifare RFID card to an RFID reader and write data, 
 * such as one's name, onto the card. The data can then be read and recorded into text files saved on an SD Card.
 * 
 * Main Hardware:
   * Arduino Uno R3
   * NXP MFRC522 13.56 mHz
   * DS3231 AT24C32 IIC RTC Module 
   * HiLetgo Micro SD TF Card Adater 
   * MIFARE Classic 1k Cards
   * 
 * External components:
 *  Breadboard
 *  USB 2.0 Cable Type A/B
 *  microSD card and adapter
 *  
 * Pinouts(From module to Arduino):
 *  MFRC522                DS3231                SD Card Adater
 *  --------------------------------------------------------------
 *  GND--->GND             GND--->GND            GND--->GND
 *  3.3v-->3.3v            VCC--->5V             VCC--->5V
 *  RST--->9               SDA--->A4             MISO-->12
 *  SDA--->10              SCL--->A5             MOSI-->11
 *  MOSI-->11                                    SCK--->13
 *  MISO-->12                                    CS---->4
 *  SCK--->13
 *  
 *  Several pins will need to be connected by a bread board to provide proper electrical current.
 *  
 * External Libaries:
 *  MFRC522 by miguelbalboa
 *  RTClib by Adafruit
 *  
 * Instructions:
 * Once the modules are connected and SD card is provided, connect your Arduino to your computer using a USB cable. Compile and upload the code to Arduino. Run the Serial 
 * Monitor under Tools. Change the line ending settings to no new line. Place and hold your card on the reader. PICC communication will begin and the card's UID will be recorded. 
 * If the UID has not been logged before, write first and last names into serial input when prompted. The data will be written to a given block of the card if its key is 
 * successfully authenticated. Remove card from reader once prompted to do so. Once completed, place card again on reader. The data written on the card will be read and
 * displayed on Serial. The name, UID, and time will also be recorded on your microSD card. To view records, place your microSD card into an SD car adapter and insert it into 
 * your computer. Open cardIDs.txt to view the UIDs and record.txt to view the attendance.
 * 
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
String cardUID;                        //Gets card UID
String className;                      //Stores class name recieved inputted from GUI
char function;                          //Determines whether attendance or registration occurs

                                        


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

  //Prompts for input to determine if recording or registration is enabled
  setFunction();
  setClass();
}

//************************************************************************//

/*The following is the primary loop that runs the main functions of the code*/
void loop() {
  if(Serial.available)
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

  //Begins event from given function command
  actionHandler(function);

  //Resets cardUID variable
  cardUID = "";
  
  //Halts PICC from reading and encryption on PCD
  mfrc522.PICC_HaltA();
  mfrc522.PCD_StopCrypto1();
}

//************************************************************************************************

/*Method receives serial data from GUI event handlers and calls appropriate submethods for  
 * data logging and storage. Each statement searches for a specific character byte that 
 * satisfies their conditions. If RFID tags are scanned and data is logged, the handler 
 * return a 'T' character byte acting as a true boolean type to the serial port. The character 
 * is received by the GUI and continues functionality. An 'F' character, representing  a false
 * boolean type, is returned to the GUI if errors occur.
 ************************************************************************************************/
void actionHandler(char function) {
  switch(function){
    case 'W' : 
      if(registerCardInfo()) {
        Serial.println(F("Complete"));
      }
      else{Serial.println(F("Name could not be written to file."));}
      break;
    case 'R' :
      if(registerToClass()){
         Serial.println(F("Complete"));
      }
      else {return;}
      break;
      
    case 'A' :
      if(searchForUID() == 'S'){
        if(recordAttendance() == true){
          return;
        }
        else{Serial.println(F("File failed to open."));}
      }
      else{Serial.println(F("Not registered for class."));}
      break;
    }
}

//******************************************************************************************************//


//Receives byte that determine whether attendance recording or registration is enabled
void setFunction() {
  wait();
  function = Serial.read();
}

//Recieves class name from serial port and creates/opens the directory;
void setClass() {
  wait();
  className = Serial.readStringUntil('\n');
  if(SD.mkdir(className)) {
    file = SD.open(className + "/Students.txt", FILE_WRITE);
    file.close();
  }
}

//*****************************************************************************************************//

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
    return "Fail";
  }

  //Reads block
  status = mfrc522.MIFARE_Read(block, bufferName, &length);
  if (status != MFRC522::STATUS_OK) {
    return "Fail";
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

bool readSuccess(String readData) {
  if(readData.equals("Fail")) {
    return false;
  }
  return true;
}

//*********************************************************************************//

/*Records data retrieved from RFID cards and RTC to SD card*/
bool recordAttendance() {
  String currTime = recordTime();
  char bufferDate[] = "MMMDD_YY.txt";
  String dateFileName= rtc.now().toString(bufferDate);


  file = SD.open(className + "/" + dateFileName, FILE_WRITE);
  if(file) {
    file.println(cardUID + " " + readInfo(1) + " " + readInfo(2) +  " " + currTime);
    file.close();
  }
  else{
    return false;
  }

  Serial.println(cardUID + " " + readInfo(1) + " " + readInfo(2) +  " " + currTime);
  return true;  
}

//**************************************************************************************//

/*Records the current time calculated by DS3231 module*/
String recordTime() {
  DateTime current = rtc.now();             
  char bufferTime[] = "hh:mm";
  return current.toString(bufferTime);
}

//****************************************************************************************************************//

/*Method that conducts the registration of a MIFARE card if UID not found in cardIDs.txt*/
bool registerToClass() {
  switch(searchForUID()) {
    case 'N' : 
      if(writeUIDToSD()) {
        return true;
      }
      return false;
    case 'S' :
    Serial.println(F("Already registered"));
      return false;
    case 'F' : 
    Serial.println(F("File could not load"));
      return false;
  }
}

bool registerCardInfo() {
  byte inputFirstName;          //First name input from Serial
  byte inputLastName;           //Last name input from Serial
  byte bufferFN[18];            //Buffer to store first name data
  byte bufferLN[18];            //Buffer to store last name data
  byte block;                   //Block number that will hold the data
  

  //Detects new card and prompts user to input name in Serial.
  wait();
  inputFirstName = Serial.readBytesUntil(',', (char *) bufferFN, 20);
  for(byte i = inputFirstName; i < 18; i++) {
    bufferFN[i] = ' ';
  }

  //Writes retrieved data to block 1 of RFID card
  block = 1;
  if(!writeInfo(block, bufferFN)){
    return false;
  }

  //Prompts user to input last name in the serial port
  inputLastName = Serial.readBytesUntil('\n', (char *) bufferLN, 20);
  for(byte i = inputLastName; i < 18; i++) {
    bufferLN[i] = ' ';
  }

  //Writes retrieved data to block 2 of RFID card
  block = 2;
  if(!writeInfo(block, bufferLN)) {
    return false;
  }
  return true;
}

//******************************************************************************************//

/*Searches for UID in cardIDs.txt and returns whether the UID is found*/
char searchForUID() {
  String search;

  //Attempts to open class and student text file
  file = SD.open(className + "/Students.txt", FILE_READ);
  if(!file){
    return 'F';
  }

 //Reads each line of text file until UID is found or all lines have been read
  while(file.available()) {
    search = file.readStringUntil('\n');
    if(search.equals(cardUID)) {
      file.close();
      return 'S';
    }
  }
  file.close();
  return 'N';
}

//**************************************************************************//

/*Halts loop until information is available in serial*/
void wait() {
  while (Serial.available() == 0) {};
}

//***************************************************************************//

/*Writes given information to a given block of  RFID card*/
bool writeInfo(byte block, byte *bufferName) {
   //Authenticates card using Key A
   MFRC522::StatusCode status;  
   status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, block, &key, &(mfrc522.uid));
   if (status != MFRC522::STATUS_OK) {
     return false;
   }

   //Writes buffer to block
   status = mfrc522.MIFARE_Write(block, bufferName, 16);
   if (status != MFRC522::STATUS_OK) {
     return false;
   }
   return true;
}

//********************************************************************************//

/*Writes UID to cardIds.txt on SD card*/
bool writeUIDToSD() {
  file = SD.open(className + "/Students.txt", FILE_WRITE);
  if(file){
    file.println(cardUID + "\n");
    file.close();
    return true;
  }
    return false;
}
