using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_Attendance_System_GUI.User_Controls
{
    public partial class InstructionsUserControl : UserControl
    {
        public InstructionsUserControl()
        {
            InitializeComponent();
        }

        private void cardInstructionButton_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Text = "1) Configure serial port settings and connect." + Environment.NewLine + "2) Input name into text boxes" + Environment.NewLine + "3) PLACE " +
                "AND HOLD card on reader and immediately press submit Do not release until status is received." + Environment.NewLine + "4) Observe status" +
                " in provided textbox." + Environment.NewLine + "5) Repeat until registration complete" + Environment.NewLine + "6) Disconnect serial port and reset Arduino.";
        }

        private void classInstructionButton_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Text = "1) Configure serial port settings and connect." + Environment.NewLine + "2) TAP card onto reader and wait" +
                " for input" + Environment.NewLine + "3) Observe registration status in text box below" + Environment.NewLine + "4) Repeat until registration complete"
                + Environment.NewLine + "5) Disconnect serial port and reset Arduino.";
        }

        private void attendanceInstructionButton_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Text = "1) Configure serial port settings and connect." + Environment.NewLine + "2) Set time of attendace is desired" +
                Environment.NewLine + "3) TAP card onto reader and wait for input." + Environment.NewLine + "4) Observe registration status in text box below" + Environment.NewLine + "5) Repeat " +
                "until registration complete" + Environment.NewLine + "5) Disconnect serial port and reset Arduino.";
        }
    }
}
