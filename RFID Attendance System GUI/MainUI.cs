using RFID_Attendance_System_GUI.User_Controls;
using System.Windows.Forms;
using System.IO.Ports;

namespace RFID_Attendance_System_GUI
{
    public partial class MainUI : Form  
    {
        //***Variables***//
        private SerialPort serialP = new SerialPort();
        private static SerialDataReceivedEventHandler? currSerialEvent;

        //Main constructor; sets up and initializes components
        public MainUI()
        {
            InitializeComponent();
            getCOMPorts();
            setRFIDFunction();
            switchToInstructions();
        }

        /* Gets all available Serial Ports and adds them to SerialPortComboBox */
        private void getCOMPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            SerialPortComboBox.Items.AddRange(ports);
        }

        //Creates options for RFID functions and adds them to RFIDFunction combobox
        private void setRFIDFunction()
        {
            string[] functions = { "Register Cards", "Register for Class", "Take Attendance" };
            RFIDFunctionComboBox.Items.AddRange(functions);
        }

        /* Event Handler for opening a Serial Port option from the Serial Port Combo Box. If all information
         is not filled or selected, a MessageBox prompting for input will be displayed. If the options are filled,
        and communication is secure, the selected serial port will be opend. The RFID function desired and the
        className will be transmitted and communication will begin*/
        private void serialCommConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasAllInformation() == false)
                {
                    MessageBox.Show("Not all information inputted.", "Error");
                }
                else
                {
                    if(checkClassNameLength() == false)
                    {
                        MessageBox.Show("Class name is too large", "Error");
                    }
                    else
                    {
                        serialP.PortName = SerialPortComboBox.Text;
                        serialP.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);
                        serialP.Parity = Parity.None;
                        serialP.StopBits = StopBits.One;
                        serialP.DataBits = 8;
                        //serialP.Handshake = Handshake.XOnXOff;
                        

                        try
                        {
                           
                            serialP.Open();
                            serialP.DiscardInBuffer();
                            serialP.DiscardOutBuffer();
                            usReference.Controls.Clear();
                            string className = setClassTextBox.Text;
                            startSystemFunction(className);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error");
                        }

                        SerialPortComboBox.Enabled = false;
                        BaudRateComboBox.Enabled = false;
                        setClassTextBox.Enabled = false;
                        RFIDFunctionComboBox.Enabled = false;
                        SerialCommConnectButton.Enabled = false;
                        SerialCommDisconnectButton.Enabled = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        /*Event handler for closing serial port*/
        private void serialCommDisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialP.IsOpen)
                {
                    serialP.DataReceived -= currSerialEvent;
                    serialP.DiscardInBuffer();
                    serialP.DiscardOutBuffer();
                    serialP.Close();
                    usReference.Controls.Clear();

                    switchToInstructions();
                    SerialPortComboBox.Enabled = true;
                    BaudRateComboBox.Enabled = true;
                    setClassTextBox.Enabled = true;
                    RFIDFunctionComboBox.Enabled = true;
                    SerialCommConnectButton.Enabled = true;
                    SerialCommDisconnectButton.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Test");
            }
        }

        //Checks to see if an RFID function radio button is selected
        private Boolean functionChecked()
        {
            if (!string.IsNullOrEmpty(RFIDFunctionComboBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checks to see if class name is less than or equal to 8
        private Boolean checkClassNameLength()
        {
            if(setClassTextBox.Text.Length <= 8)
            {
                return true;
            }
            return false;
        }

        //Checks to see if input fields has information written in them
        private Boolean hasAllInformation()
        {
            if (SerialPortComboBox.SelectedItem != null && BaudRateComboBox.SelectedItem != null &&
                functionChecked() == true && !string.IsNullOrEmpty(setClassTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Sends byte to Arduino code to determine whether attendance or registration will be incorporated
        private void startSystemFunction(string className)
        {
            if (RFIDFunctionComboBox.Text == "Register Cards")
            {
                serialP.WriteLine("W" + className);
                switchToCardRegistration();

            }
            else if (RFIDFunctionComboBox.Text == "Register for Class")
            {
                className = setClassTextBox.Text;
                serialP.WriteLine("R" + className);
                switchToClassRegistration(className);
            }
            else if (RFIDFunctionComboBox.Text == "Take Attendance")
            {
                className = setClassTextBox.Text;
                serialP.WriteLine("A" + className);
                switchToAttendance(className);

            }
        }

        //Swicthes to AttendanceUserControl
        private void switchToAttendance(string className)
        {
            AttendanceUserControl ucAttendance = new AttendanceUserControl(serialP, className);
            usReference.Controls.Add(ucAttendance);
            currSerialEvent = ucAttendance.SerialPort_DataReceived;
            serialP.DataReceived += currSerialEvent;
            
        }

        //Switches to RegistrationUserControl
        private void switchToCardRegistration()
        {
            CardRegistrationUserControl  ucCardRegistration = new CardRegistrationUserControl(serialP);
            usReference.Controls.Add(ucCardRegistration);
            currSerialEvent = ucCardRegistration.SerialPort_DataReceived;
            serialP.DataReceived += currSerialEvent;
        }

        //Switches to ClassRegistrationControl
        private void switchToClassRegistration(string className)
        {
            ClassRegistrationUserControl ucClassRegistration = new ClassRegistrationUserControl(serialP, className);
            usReference.Controls.Add(ucClassRegistration);
            currSerialEvent = ucClassRegistration.SerialPort_DataReceived;
            serialP.DataReceived += currSerialEvent;

        }

        private void switchToInstructions()
        {
            InstructionsUserControl ucInstructions = new InstructionsUserControl();
            usReference.Controls.Add(ucInstructions);
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /*//Switches to DataLogUserControl
        private void switchToDataLog()
        {
            DataLogUserControl ucDataLog = new DataLogUserControl(serialP, className);
            usReference.Controls.Clear();
            usReference.Controls.Add(ucDataLog);
            usReference.Dock = DockStyle.Fill;
        }*/

    }
}