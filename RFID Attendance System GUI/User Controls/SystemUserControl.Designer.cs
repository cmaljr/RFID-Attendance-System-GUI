namespace RFID_Attendance_System_GUI.User_Controls
{
    partial class SystemUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.systemTitle = new System.Windows.Forms.Label();
            this.setupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RFIDFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.setClassLabel = new System.Windows.Forms.Label();
            this.setClassTextBox = new System.Windows.Forms.TextBox();
            this.SerialCommDisconnectButton = new System.Windows.Forms.Button();
            this.SerialCommConnectButton = new System.Windows.Forms.Button();
            this.communicationLabel = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.SerialPortComboBox = new System.Windows.Forms.ComboBox();
            this.serialPortLabel = new System.Windows.Forms.Label();
            this.setupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemTitle
            // 
            this.systemTitle.AutoSize = true;
            this.systemTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.systemTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.systemTitle.Location = new System.Drawing.Point(0, 0);
            this.systemTitle.Name = "systemTitle";
            this.systemTitle.Size = new System.Drawing.Size(100, 37);
            this.systemTitle.TabIndex = 2;
            this.systemTitle.Text = "System";
            this.systemTitle.Click += new System.EventHandler(this.registrationTitle_Click);
            // 
            // setupBox
            // 
            this.setupBox.Controls.Add(this.label1);
            this.setupBox.Controls.Add(this.RFIDFunctionComboBox);
            this.setupBox.Controls.Add(this.setClassLabel);
            this.setupBox.Controls.Add(this.setClassTextBox);
            this.setupBox.Controls.Add(this.SerialCommDisconnectButton);
            this.setupBox.Controls.Add(this.SerialCommConnectButton);
            this.setupBox.Controls.Add(this.communicationLabel);
            this.setupBox.Controls.Add(this.BaudRateComboBox);
            this.setupBox.Controls.Add(this.baudRateLabel);
            this.setupBox.Controls.Add(this.SerialPortComboBox);
            this.setupBox.Controls.Add(this.serialPortLabel);
            this.setupBox.Location = new System.Drawing.Point(74, 121);
            this.setupBox.Name = "setupBox";
            this.setupBox.Size = new System.Drawing.Size(409, 235);
            this.setupBox.TabIndex = 3;
            this.setupBox.TabStop = false;
            this.setupBox.Text = "Setup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select RFID function: ";
            // 
            // RFIDFunctionComboBox
            // 
            this.RFIDFunctionComboBox.FormattingEnabled = true;
            this.RFIDFunctionComboBox.Location = new System.Drawing.Point(21, 179);
            this.RFIDFunctionComboBox.Name = "RFIDFunctionComboBox";
            this.RFIDFunctionComboBox.Size = new System.Drawing.Size(179, 23);
            this.RFIDFunctionComboBox.TabIndex = 11;
            // 
            // setClassLabel
            // 
            this.setClassLabel.AutoSize = true;
            this.setClassLabel.Location = new System.Drawing.Point(21, 101);
            this.setClassLabel.Name = "setClassLabel";
            this.setClassLabel.Size = new System.Drawing.Size(178, 15);
            this.setClassLabel.TabIndex = 10;
            this.setClassLabel.Text = "Set class name: (<16 characters):";
            // 
            // setClassTextBox
            // 
            this.setClassTextBox.Location = new System.Drawing.Point(21, 119);
            this.setClassTextBox.Name = "setClassTextBox";
            this.setClassTextBox.Size = new System.Drawing.Size(179, 23);
            this.setClassTextBox.TabIndex = 9;
            // 
            // SerialCommDisconnectButton
            // 
            this.SerialCommDisconnectButton.Location = new System.Drawing.Point(272, 157);
            this.SerialCommDisconnectButton.Name = "SerialCommDisconnectButton";
            this.SerialCommDisconnectButton.Size = new System.Drawing.Size(75, 45);
            this.SerialCommDisconnectButton.TabIndex = 6;
            this.SerialCommDisconnectButton.Text = "Disconnect";
            this.SerialCommDisconnectButton.UseVisualStyleBackColor = true;
            this.SerialCommDisconnectButton.Click += new System.EventHandler(this.serialCommDisconnectButton_Click);
            // 
            // SerialCommConnectButton
            // 
            this.SerialCommConnectButton.Location = new System.Drawing.Point(272, 71);
            this.SerialCommConnectButton.Name = "SerialCommConnectButton";
            this.SerialCommConnectButton.Size = new System.Drawing.Size(75, 45);
            this.SerialCommConnectButton.TabIndex = 5;
            this.SerialCommConnectButton.Text = "Connect";
            this.SerialCommConnectButton.UseVisualStyleBackColor = true;
            this.SerialCommConnectButton.Click += new System.EventHandler(this.serialCommConnectButton_Click);
            // 
            // communicationLabel
            // 
            this.communicationLabel.AutoSize = true;
            this.communicationLabel.Location = new System.Drawing.Point(262, 39);
            this.communicationLabel.Name = "communicationLabel";
            this.communicationLabel.Size = new System.Drawing.Size(94, 15);
            this.communicationLabel.TabIndex = 4;
            this.communicationLabel.Text = "Communication";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(139, 62);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(60, 23);
            this.BaudRateComboBox.TabIndex = 3;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(136, 39);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(63, 15);
            this.baudRateLabel.TabIndex = 2;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // SerialPortComboBox
            // 
            this.SerialPortComboBox.FormattingEnabled = true;
            this.SerialPortComboBox.Location = new System.Drawing.Point(21, 62);
            this.SerialPortComboBox.Name = "SerialPortComboBox";
            this.SerialPortComboBox.Size = new System.Drawing.Size(60, 23);
            this.SerialPortComboBox.TabIndex = 1;
            // 
            // serialPortLabel
            // 
            this.serialPortLabel.AutoSize = true;
            this.serialPortLabel.Location = new System.Drawing.Point(18, 39);
            this.serialPortLabel.Name = "serialPortLabel";
            this.serialPortLabel.Size = new System.Drawing.Size(63, 15);
            this.serialPortLabel.TabIndex = 0;
            this.serialPortLabel.Text = "Serial Port:";
            // 
            // SystemUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.setupBox);
            this.Controls.Add(this.systemTitle);
            this.Name = "SystemUserControl";
            this.Size = new System.Drawing.Size(600, 417);
            this.setupBox.ResumeLayout(false);
            this.setupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label systemTitle;
        private GroupBox setupBox;
        private Label communicationLabel;
        private ComboBox BaudRateComboBox;
        private Label baudRateLabel;
        private ComboBox SerialPortComboBox;
        private Label serialPortLabel;
        private Button SerialCommConnectButton;
        private Button SerialCommDisconnectButton;
        private Label setClassLabel;
        private TextBox setClassTextBox;
        private Label label1;
        private ComboBox RFIDFunctionComboBox;
    }
}
