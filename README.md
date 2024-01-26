# RFID Attendance System GUI

## Introduction
Radio frequency identification (RFID) is a wireless technology that uses radio frequencies to scan and transmit data from a tag to a reader when the tagged object comes within the vicinity of the reader. This project explores the hardware and software implementation of RFID technology through a class attendance system to improve the efficiency and accuracy of traditional roll calls. The attendance system has three main functions: writing student names onto RFID tags, enrolling classes, and collecting attendance data. To implement these functions, the following low-cost hardware are used to n Arduino UNO R3 microcontroller is used to control and process serial data communication between passive RFID tags and a high-frequency MFRC522 reader module, a DS321 real-time clock module keeps the time with crystal oscillator frequencies and a MicroSD Card module logs the tag IDs and attendance information into text files. A C++ program is developed, and the compiled software is uploaded to the microcontroller using the Arduino IDE. A GUI is also developed to provide a user-friendly interface to control serial communication with RFIDs. Tests with various data inputs, communication speed, and storage verified that the attendance system is implemented successfully. 

## Table of Content
1. Circuit Configuration
2. Arduino Configuration
3. Application Set Up
4. Usage
5. Sources & Credits

## Circuit Configuration
### Electronic Components Used
* Microcontroller: Arduino Uno R3
* RFID Reader: NXP MFRC522 13.56 mHz
* Clock: DS3231 AT24C32 IIC RTC Module 
* SD Card Reader: HiLetgo Micro SD TF Card Adater 
* RFID Tags: MIFARE Classic 1k Cards
* Breadboard
* Dupont Wires

### Circuit Pinout
Once you acquire all the required electrical components, wire all the devices together using the following pinout: 

| MFRC522 | DS3231 | SD Card Adater |
| --- | --- | --- |
| GND ---> GND | GND ---> GND | GND ---> GND |
| 3.3v ---> 3.3v | VCC ---> 5V | VCC ---> 5V |
| RST ---> 9 | SDA ---> A4 | MISO ---> 12 |
| SDA ---> 10 | SCL ---> A5 | MOSI --->11 |
| MOSI ---> 11  | | SCK ---> 13 |
| MISO ---> 12 | | CS ---> 4 |
| SCK ---> 13 |

The pinout depicts which pins on the electric components connect to the Arduino pins. The left label indicates the pin on the electrical device, while the right label indicates which pin to connect to on the Arduino. Several pins will need to be connected by a bread board to provide proper electrical current. The circuit layout should appear as follows:

##Arduino Configuration
