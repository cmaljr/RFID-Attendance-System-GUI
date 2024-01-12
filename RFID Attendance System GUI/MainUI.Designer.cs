namespace RFID_Attendance_System_GUI
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideBar = new System.Windows.Forms.Panel();
            this.setupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RFIDFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.setClassLabel = new System.Windows.Forms.Label();
            this.setClassTextBox = new System.Windows.Forms.TextBox();
            this.SerialCommDisconnectButton = new System.Windows.Forms.Button();
            this.SerialCommConnectButton = new System.Windows.Forms.Button();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.serialPortLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.appTitle = new System.Windows.Forms.Label();
            this.usReference = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.setupBox.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.SteelBlue;
            this.sideBar.Controls.Add(this.setupBox);
            this.sideBar.Controls.Add(this.titlePanel);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(223, 429);
            this.sideBar.TabIndex = 0;
            // 
            // setupBox
            // 
            this.setupBox.BackColor = System.Drawing.Color.Transparent;
            this.setupBox.Controls.Add(this.label1);
            this.setupBox.Controls.Add(this.RFIDFunctionComboBox);
            this.setupBox.Controls.Add(this.setClassLabel);
            this.setupBox.Controls.Add(this.setClassTextBox);
            this.setupBox.Controls.Add(this.SerialCommDisconnectButton);
            this.setupBox.Controls.Add(this.SerialCommConnectButton);
            this.setupBox.Controls.Add(this.BaudRateComboBox);
            this.setupBox.Controls.Add(this.baudRateLabel);
            this.setupBox.Controls.Add(this.SerialPortComboBox);
            this.setupBox.Controls.Add(this.serialPortLabel);
            this.setupBox.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setupBox.ForeColor = System.Drawing.Color.Navy;
            this.setupBox.Location = new System.Drawing.Point(7, 74);
            this.setupBox.Name = "setupBox";
            this.setupBox.Size = new System.Drawing.Size(208, 343);
            this.setupBox.TabIndex = 4;
            this.setupBox.TabStop = false;
            this.setupBox.Text = "Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select RFID function: ";
            // 
            // RFIDFunctionComboBox
            // 
            this.RFIDFunctionComboBox.FormattingEnabled = true;
            this.RFIDFunctionComboBox.Location = new System.Drawing.Point(8, 212);
            this.RFIDFunctionComboBox.Name = "RFIDFunctionComboBox";
            this.RFIDFunctionComboBox.Size = new System.Drawing.Size(193, 24);
            this.RFIDFunctionComboBox.TabIndex = 11;
            // 
            // setClassLabel
            // 
            this.setClassLabel.AutoSize = true;
            this.setClassLabel.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setClassLabel.Location = new System.Drawing.Point(8, 108);
            this.setClassLabel.Name = "setClassLabel";
            this.setClassLabel.Size = new System.Drawing.Size(119, 32);
            this.setClassLabel.TabIndex = 10;
            this.setClassLabel.Text = "Set class name: \r\n(<8 characters)";
            // 
            // setClassTextBox
            // 
            this.setClassTextBox.Location = new System.Drawing.Point(8, 143);
            this.setClassTextBox.Name = "setClassTextBox";
            this.setClassTextBox.Size = new System.Drawing.Size(193, 21);
            this.setClassTextBox.TabIndex = 9;
            // 
            // SerialCommDisconnectButton
            // 
            this.SerialCommDisconnectButton.BackColor = System.Drawing.Color.Navy;
            this.SerialCommDisconnectButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SerialCommDisconnectButton.Location = new System.Drawing.Point(107, 262);
            this.SerialCommDisconnectButton.Name = "SerialCommDisconnectButton";
            this.SerialCommDisconnectButton.Size = new System.Drawing.Size(95, 64);
            this.SerialCommDisconnectButton.TabIndex = 6;
            this.SerialCommDisconnectButton.Text = "Disconnect";
            this.SerialCommDisconnectButton.UseVisualStyleBackColor = false;
            this.SerialCommDisconnectButton.Click += new System.EventHandler(this.serialCommDisconnectButton_Click);
            // 
            // SerialCommConnectButton
            // 
            this.SerialCommConnectButton.BackColor = System.Drawing.Color.Navy;
            this.SerialCommConnectButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.SerialCommConnectButton.Location = new System.Drawing.Point(6, 262);
            this.SerialCommConnectButton.Name = "SerialCommConnectButton";
            this.SerialCommConnectButton.Size = new System.Drawing.Size(95, 64);
            this.SerialCommConnectButton.TabIndex = 5;
            this.SerialCommConnectButton.Text = "Connect";
            this.SerialCommConnectButton.UseVisualStyleBackColor = false;
            this.SerialCommConnectButton.Click += new System.EventHandler(this.serialCommConnectButton_Click);
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(125, 63);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(74, 24);
            this.BaudRateComboBox.TabIndex = 3;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baudRateLabel.Location = new System.Drawing.Point(122, 40);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(77, 16);
            this.baudRateLabel.TabIndex = 2;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.BackColor = System.Drawing.Color.White;
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(8, 63);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(88, 24);
            this.SerialPortComboBox.TabIndex = 1;
            // 
            // serialPortLabel
            // 
            this.serialPortLabel.AutoSize = true;
            this.serialPortLabel.Font = new System.Drawing.Font("Cascadia Code SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serialPortLabel.ForeColor = System.Drawing.Color.Navy;
            this.serialPortLabel.Location = new System.Drawing.Point(5, 40);
            this.serialPortLabel.Name = "serialPortLabel";
            this.serialPortLabel.Size = new System.Drawing.Size(91, 16);
            this.serialPortLabel.TabIndex = 0;
            this.serialPortLabel.Text = "Serial Port:";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.titlePanel.Controls.Add(this.appTitle);
            this.titlePanel.ForeColor = System.Drawing.Color.White;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(223, 68);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.BackColor = System.Drawing.Color.Transparent;
            this.appTitle.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.appTitle.Location = new System.Drawing.Point(7, 21);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(208, 21);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "RFID Attendance System";
            // 
            // usReference
            // 
            this.usReference.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usReference.Location = new System.Drawing.Point(229, 12);
            this.usReference.Name = "usReference";
            this.usReference.Size = new System.Drawing.Size(474, 405);
            this.usReference.TabIndex = 3;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(710, 429);
            this.Controls.Add(this.usReference);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.Text = "RFID Application";
            this.sideBar.ResumeLayout(false);
            this.setupBox.ResumeLayout(false);
            this.setupBox.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sideBar;
        private Panel titlePanel;
        private Label appTitle;
        private Panel usReference;
        private GroupBox setupBox;
        private Label label1;
        private ComboBox RFIDFunctionComboBox;
        private Label setClassLabel;
        private TextBox setClassTextBox;
        private Button SerialCommDisconnectButton;
        private Button SerialCommConnectButton;
        private ComboBox BaudRateComboBox;
        private Label baudRateLabel;
        private ComboBox SerialPortComboBox;
        private Label serialPortLabel;
    }
}