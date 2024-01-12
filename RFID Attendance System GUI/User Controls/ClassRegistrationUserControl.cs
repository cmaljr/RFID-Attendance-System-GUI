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
    public partial class ClassRegistrationUserControl : UserControl
    {
        //***Variables**
        SerialPort localSP;
        string className;

        private delegate void AddText(string data);

        public ClassRegistrationUserControl(SerialPort serialP, string className)
        {
            InitializeComponent();
            this.localSP = serialP;
            this.className = className;
            setCurrentClass();
            //localSP.DataReceived += SerialPort_DataReceived;
        }

        //Sets local className variable as the passed parameter
        public void setCurrentClass()
        {
            currentClassTextBox.Text = className;
        }

        //Serial data event handler that receives information
        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string inputData = localSP.ReadLine().TrimEnd('\r');
                Boolean test = String.Equals("Complete", inputData);
                if (inputData.Equals("Complete"))
                {
                    printStatus("Card registered to class!");
                }
                else
                {
                    printStatus("Error: " + inputData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }

        }

        //Prints error to status textbox
        private void printStatus(string data)
        {
            if (classStatusTextBox.InvokeRequired)
            {
                AddText text = new AddText(printStatus);
                classStatusTextBox.Invoke(text, new object[] { data });
            }
            else
            {
                classStatusTextBox.AppendText(data + Environment.NewLine);
            }
            
        }

        /*private void turnOffSerialEvent()
        {
            if (!localSP.IsOpen)
            {
                localSP.DataReceived -= SerialPort_DataReceived;
            }
        }*/

    }
}