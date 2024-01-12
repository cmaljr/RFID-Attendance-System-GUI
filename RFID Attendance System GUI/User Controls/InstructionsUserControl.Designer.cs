namespace RFID_Attendance_System_GUI.User_Controls
{
    partial class InstructionsUserControl
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
            this.attendanceInstructionButton = new System.Windows.Forms.Button();
            this.classInstructionButton = new System.Windows.Forms.Button();
            this.cardInstructionButton = new System.Windows.Forms.Button();
            this.InstructionTextBox = new System.Windows.Forms.TextBox();
            this.pencilPictureLabel = new System.Windows.Forms.Label();
            this.bookletPictureLabel = new System.Windows.Forms.Label();
            this.cardPictureLabel = new System.Windows.Forms.Label();
            this.attendancePictureBox = new System.Windows.Forms.PictureBox();
            this.registrationPictureBox = new System.Windows.Forms.PictureBox();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attendancePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceInstructionButton
            // 
            this.attendanceInstructionButton.BackColor = System.Drawing.Color.Navy;
            this.attendanceInstructionButton.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attendanceInstructionButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.attendanceInstructionButton.Location = new System.Drawing.Point(355, 225);
            this.attendanceInstructionButton.Name = "attendanceInstructionButton";
            this.attendanceInstructionButton.Size = new System.Drawing.Size(95, 23);
            this.attendanceInstructionButton.TabIndex = 22;
            this.attendanceInstructionButton.Text = "Instructions";
            this.attendanceInstructionButton.UseVisualStyleBackColor = false;
            this.attendanceInstructionButton.Click += new System.EventHandler(this.attendanceInstructionButton_Click);
            // 
            // classInstructionButton
            // 
            this.classInstructionButton.BackColor = System.Drawing.Color.Navy;
            this.classInstructionButton.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classInstructionButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.classInstructionButton.Location = new System.Drawing.Point(187, 225);
            this.classInstructionButton.Name = "classInstructionButton";
            this.classInstructionButton.Size = new System.Drawing.Size(95, 23);
            this.classInstructionButton.TabIndex = 21;
            this.classInstructionButton.Text = "Instructions";
            this.classInstructionButton.UseVisualStyleBackColor = false;
            this.classInstructionButton.Click += new System.EventHandler(this.classInstructionButton_Click);
            // 
            // cardInstructionButton
            // 
            this.cardInstructionButton.BackColor = System.Drawing.Color.Navy;
            this.cardInstructionButton.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardInstructionButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cardInstructionButton.Location = new System.Drawing.Point(19, 225);
            this.cardInstructionButton.Name = "cardInstructionButton";
            this.cardInstructionButton.Size = new System.Drawing.Size(95, 23);
            this.cardInstructionButton.TabIndex = 20;
            this.cardInstructionButton.Text = "Instructions";
            this.cardInstructionButton.UseVisualStyleBackColor = false;
            this.cardInstructionButton.Click += new System.EventHandler(this.cardInstructionButton_Click);
            // 
            // InstructionTextBox
            // 
            this.InstructionTextBox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstructionTextBox.Location = new System.Drawing.Point(19, 254);
            this.InstructionTextBox.Multiline = true;
            this.InstructionTextBox.Name = "InstructionTextBox";
            this.InstructionTextBox.Size = new System.Drawing.Size(431, 137);
            this.InstructionTextBox.TabIndex = 19;
            // 
            // pencilPictureLabel
            // 
            this.pencilPictureLabel.AutoSize = true;
            this.pencilPictureLabel.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pencilPictureLabel.Location = new System.Drawing.Point(362, 197);
            this.pencilPictureLabel.Name = "pencilPictureLabel";
            this.pencilPictureLabel.Size = new System.Drawing.Size(88, 17);
            this.pencilPictureLabel.TabIndex = 18;
            this.pencilPictureLabel.Text = "Attendance";
            // 
            // bookletPictureLabel
            // 
            this.bookletPictureLabel.AutoSize = true;
            this.bookletPictureLabel.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookletPictureLabel.Location = new System.Drawing.Point(187, 180);
            this.bookletPictureLabel.Name = "bookletPictureLabel";
            this.bookletPictureLabel.Size = new System.Drawing.Size(104, 34);
            this.bookletPictureLabel.TabIndex = 17;
            this.bookletPictureLabel.Text = "Class \r\nRegistration";
            this.bookletPictureLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardPictureLabel
            // 
            this.cardPictureLabel.AutoSize = true;
            this.cardPictureLabel.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardPictureLabel.Location = new System.Drawing.Point(19, 180);
            this.cardPictureLabel.Name = "cardPictureLabel";
            this.cardPictureLabel.Size = new System.Drawing.Size(104, 34);
            this.cardPictureLabel.TabIndex = 16;
            this.cardPictureLabel.Text = "Card\r\nRegistration";
            this.cardPictureLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // attendancePictureBox
            // 
            this.attendancePictureBox.Image = global::RFID_Attendance_System_GUI.Properties.Resources.pencil;
            this.attendancePictureBox.Location = new System.Drawing.Point(355, 89);
            this.attendancePictureBox.Name = "attendancePictureBox";
            this.attendancePictureBox.Size = new System.Drawing.Size(95, 88);
            this.attendancePictureBox.TabIndex = 15;
            this.attendancePictureBox.TabStop = false;
            // 
            // registrationPictureBox
            // 
            this.registrationPictureBox.Image = global::RFID_Attendance_System_GUI.Properties.Resources.attendance;
            this.registrationPictureBox.Location = new System.Drawing.Point(187, 89);
            this.registrationPictureBox.Name = "registrationPictureBox";
            this.registrationPictureBox.Size = new System.Drawing.Size(95, 88);
            this.registrationPictureBox.TabIndex = 14;
            this.registrationPictureBox.TabStop = false;
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.Image = global::RFID_Attendance_System_GUI.Properties.Resources.card;
            this.cardPictureBox.Location = new System.Drawing.Point(19, 89);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(95, 88);
            this.cardPictureBox.TabIndex = 13;
            this.cardPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(155, 15);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(171, 43);
            this.welcomeLabel.TabIndex = 12;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // InstructionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.attendanceInstructionButton);
            this.Controls.Add(this.classInstructionButton);
            this.Controls.Add(this.cardInstructionButton);
            this.Controls.Add(this.InstructionTextBox);
            this.Controls.Add(this.pencilPictureLabel);
            this.Controls.Add(this.bookletPictureLabel);
            this.Controls.Add(this.cardPictureLabel);
            this.Controls.Add(this.attendancePictureBox);
            this.Controls.Add(this.registrationPictureBox);
            this.Controls.Add(this.cardPictureBox);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "InstructionsUserControl";
            this.Size = new System.Drawing.Size(474, 405);
            ((System.ComponentModel.ISupportInitialize)(this.attendancePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button attendanceInstructionButton;
        private Button classInstructionButton;
        private Button cardInstructionButton;
        private TextBox InstructionTextBox;
        private Label pencilPictureLabel;
        private Label bookletPictureLabel;
        private Label cardPictureLabel;
        private PictureBox attendancePictureBox;
        private PictureBox registrationPictureBox;
        private PictureBox cardPictureBox;
        private Label welcomeLabel;
    }
}
