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
    public partial class AttendanceUserControl : UserControl
    {
        //***Variables***
        private SerialPort localSP;
        private string inputData = "";
        private string className;
        private DateTime time;
        DataTable attendanceRecord = new DataTable();

        //private delegate void printData(string data);
        private delegate void addData(string data);

        //Constructor that initializes components and starts DataReceived events
        public AttendanceUserControl(SerialPort serialP, string className)
        {
            InitializeComponent();
            setup();
            this.localSP = serialP;
            this.className = className;
            //localSP.DataReceived += SerialPort_DataReceived;
        }

        //Sets up specific designer interfaces
        public void setup()
        {
            setTimeButton.Enabled = true;
            setTimeTextBox.Enabled = true;
            createTable();
        }

        //Creates DataGridView table that holds attendance record when RFID tag is read
        public void createTable()
        { 
            attendanceRecord.Columns.Add("ID", typeof(string));
            attendanceRecord.Columns.Add("First Name", typeof(string));
            attendanceRecord.Columns.Add("Last Name", typeof(string));
            attendanceRecord.Columns.Add("Time", typeof(string));
            attendanceRecord.Columns.Add("Status", typeof(string));
            attendanceDataGrid.DataSource = attendanceRecord;

        }

        /*Event Handler that adds attendance information to the data grid once an RFID card is detected
         * by the MFRC522 module */
        public void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                inputData = localSP.ReadLine().TrimEnd('\n');
                if(inputData.Equals("File failed to open.\r") || inputData.Equals("Not registered for class.\r"))
                {
                    MessageBox.Show("Error: " + inputData, "Error");
                }
                else
                {
                    string[] variables = inputData.Split(" ");
                    int variable = variables.Length;
                    if(variables.Length == 4)
                    {
                        string attendanceStatus = "";
                        DateTime receivedTime = DateTime.ParseExact(variables[3].TrimEnd('\r'), "HH:mm", null);
                        DateTime newTime = receivedTime.Subtract(TimeSpan.FromHours(1));
                        if (!string.IsNullOrEmpty(setTimeTextBox.Text))
                        {
                            
                            MessageBox.Show(receivedTime + " Vs" + newTime);
                            if (newTime < time)
                            {
                                attendanceStatus = "On Time";
                            }
                            else
                            {
                                attendanceStatus = "Late";
                            }
                        }
                        else
                        {
                            attendanceStatus = "Unknown";
                        }

                        printAttendance(variables, newTime, attendanceStatus);
                    }
                    else
                    {
                        MessageBox.Show("Error: Data received too small to be correct", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void printAttendance(string[] data, DateTime time, string status)
        {
            if (attendanceDataGrid.InvokeRequired)
            {
                attendanceDataGrid.Invoke(new Action(delegate ()
                {
                    attendanceRecord.Rows.Add(data[0], data[1], data[2], time.ToString("HH:mm"), status);
                }));
            }
            else
            {
                attendanceRecord.Rows.Add(data[0], data[1], data[2], time.ToString("HH:mm"), status);
            }
        }

        //Event handler that sets time of attendance
        private void setTimeButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(setTimeTextBox.Text))
            {
                MessageBox.Show("Error: Attendance time not inputted.", "Error");
            }

            try
            {
                time = DateTime.ParseExact(setTimeTextBox.Text, "HH:mm", null);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.StackTrace, "Error");
            }
            setTimeButton.Enabled = false;
            setTimeTextBox.Enabled = false;
        }

        private void setTime(DateTime time)
        {

        }
    } 
}
