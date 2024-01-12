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
    public partial class DataLogUserControl : UserControl
    {
        private SerialPort dataSerialPControl;
        private string className;
        

        public DataLogUserControl(SerialPort serialP, string className)
        {
            InitializeComponent();
            this.dataSerialPControl = serialP;
            this.className = className;
        }
    }
}
