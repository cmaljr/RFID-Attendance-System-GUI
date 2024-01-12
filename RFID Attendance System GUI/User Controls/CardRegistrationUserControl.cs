using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Attendance_System_GUI.User_Controls
{
    public partial class CardRegistrationUserControl : UserControl
    {
        //***Variables***
        private SerialPort localSP;
        private const int MAX_BLOCKSIZE = 16;
        private string firstName = "";
        private string lastName = "";

        private delegate void NameDelegate(Control c, string name);
        private delegate void AddText(string data);

        //Constructor that initializes componenents and starts DataReceived 
        public CardRegistrationUserControl(SerialPort serialP)
        {
            this.localSP = serialP;
            InitializeComponent();
            //localSP.DataReceived += SerialPort_DataReceived;
        }

        /*Event handler that writes the inputted name to the serial port once the button is clicked. The data
         * is then encoded into one of the MIFARE card's blocks.*/
        private void cardSubmitButton_Click(object sender, EventArgs e)
        {
            //invokeName(firstNameTextBox, firstName);
            //invokeName(lastNameTextBox, lastName);
            if (isDataFilled() == true)
            {
                if (checkNameLength() == true)
                {
                    try
                    {
                        firstName = firstNameTextBox.Text;
                        lastName = lastNameTextBox.Text;
                        localSP.WriteLine(firstName + ',' + lastName);
                        //localSP.DataReceived += SerialPort_DataReceived;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Error: First or last name is greater than block size.", "Error");
                }
            }
        }

        //Checks to see if input fields have information written inside them
        private Boolean isDataFilled()
        {
            if (!string.IsNullOrEmpty(firstNameTextBox.Text) || !string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checks name length to see if the name is small enough to fit in a MIFARE Classic card's memory block
        private Boolean checkNameLength()
        {
            if (firstNameTextBox.Text.Length <= MAX_BLOCKSIZE && lastNameTextBox.Text.Length <= MAX_BLOCKSIZE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Event handler that displays whether information was successfully sent through the serial port
        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string inputData = localSP.ReadLine().TrimEnd('\r');
                if (inputData.Equals("Complete"))
                {
                    printData(inputData);
                }
                else
                {
                    printData("Error: " + inputData);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        //Invokes given control to print name
        private void invokeName(Control c, string name)
        {
            if(c.InvokeRequired)
            {
                NameDelegate del = new NameDelegate(invokeName);
                c.Invoke(del, new object[] { name });
            }
            else
            {
                name = c.Text;
            }
        }

        //Prints registration data to status box if received from RFID circuit
        private void printData(string data)
        {
            if(cardStatusTextBox.InvokeRequired)
            {
                AddText text = new AddText(printData);
                cardStatusTextBox.Invoke(text, new object[] { data });
            }
            else
            {
                cardStatusTextBox.AppendText(data + Environment.NewLine);
            }
        }
    }
}
