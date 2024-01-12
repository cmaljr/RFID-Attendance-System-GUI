using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RFID_Attendance_System_GUI.User_Controls
{
    public partial class SystemUserControl : UserControl
    {
        public bool attendanceActivated = false;
        public bool classRegistrationActivated = false;
        public bool cardRegistrationActivated = false;
        private SerialPort systemSerialPControl;
        private string className = "";

        public SystemUserControl(SerialPort serialP, DataGridView attendanceData)
        {
            this.systemSerialPControl = serialP;

            InitializeComponent();
            getCOMPorts();
        }

        private void registrationTitle_Click(object sender, EventArgs e)
        {

        }

        /* Gets all available Serial Ports and adds them to SerialPortComboBox */
        private void getCOMPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            SerialPortComboBox.Items.AddRange(ports);
        }

        private void setRFIDFunction()
        {
            string[] functions = { "Register Cards", "Register for Class", "Take Attendance" };
            RFIDFunctionComboBox.Items.AddRange(functions);
        }

        /* Event Handler for opening a Serial Port option from the Serial Port Combo Box. If all information
         is not filled or selected, a MessageBox prompting for input will be displayed. If the options are filled,
        and communication is secure, the selected serial port will be opend. The function desired (attendance or 
        registration) and the className will be transmitted and communication will begin*/
        private void serialCommConnectButton_Click(object sender, EventArgs e)
        {
            try
            {   
                if(hasAllInformation() == false)
                {
                    string popupMessage = "Not all information inputted .";
                    string popupTitle = "Error";
                    MessageBox.Show(popupMessage, popupTitle);
                }
                else
                {
                    systemSerialPControl.PortName = SerialPortComboBox.Text;
                    systemSerialPControl.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);

                    try
                    {
                        systemSerialPControl.Open();
                        writeSystemFunction();
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }
                    

                    SerialPortComboBox.Enabled = false;
                    BaudRateComboBox.Enabled = false;
                    setClassTextBox.Enabled = false;
                    SerialCommConnectButton.Enabled = false;
                    SerialCommDisconnectButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Test");
            }
        }

        /*Event handler for closing serial port*/
        private void serialCommDisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(systemSerialPControl.IsOpen)
                {
                    systemSerialPControl.Close();
                    disableActivationVariables();
                    SerialPortComboBox.Enabled = true;
                    BaudRateComboBox.Enabled = true;
                    setClassTextBox.Enabled = true;
                    SerialCommDisconnectButton.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Test");
            }
        }

        private Boolean functionChecked()
        {
            if(!string.IsNullOrEmpty(RFIDFunctionComboBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean hasAllInformation()
        {
            if(!string.IsNullOrEmpty(SerialPortComboBox.Text) && !string.IsNullOrEmpty(BaudRateComboBox.Text) && 
                functionChecked() == true && !string.IsNullOrEmpty(setClassTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void disableActivationVariables()
        {
            attendanceActivated = false;
            cardRegistrationActivated = false;
            classRegistrationActivated = false;
        }

        //Sends byte to Arduino code to determine whether attendance or registration will be incorporated
        private void writeSystemFunction()
        {
            if(RFIDFunctionComboBox.Text == "Register Cards")
            {
                className = setClassTextBox.Text;
                systemSerialPControl.WriteLine("W" + className);
                cardRegistrationActivated = true;
                
            }
            else if(RFIDFunctionComboBox.Text == "Register for class")
            {
                className = setClassTextBox.Text;
                systemSerialPControl.WriteLine("R" + className);
                classRegistrationActivated = true;
            }
            else if(RFIDFunctionComboBox.Text == "Take Attendance")
            {
                className = setClassTextBox.Text;
                systemSerialPControl.WriteLine("A" + className);
                attendanceActivated = true;
              
            }
        }
    }
}
