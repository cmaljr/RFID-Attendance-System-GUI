namespace RFID_Attendance_System_GUI.User_Controls
{
    partial class ClassRegistrationUserControl
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
            this.classRegistrationLabel = new System.Windows.Forms.Label();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.currentClassTextBox = new System.Windows.Forms.TextBox();
            this.currentClassLabel = new System.Windows.Forms.Label();
            this.classStatusTextBox = new System.Windows.Forms.TextBox();
            this.attendancePicture = new System.Windows.Forms.PictureBox();
            this.statusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendancePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // classRegistrationLabel
            // 
            this.classRegistrationLabel.AutoSize = true;
            this.classRegistrationLabel.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classRegistrationLabel.Location = new System.Drawing.Point(120, 41);
            this.classRegistrationLabel.Name = "classRegistrationLabel";
            this.classRegistrationLabel.Size = new System.Drawing.Size(303, 35);
            this.classRegistrationLabel.TabIndex = 0;
            this.classRegistrationLabel.Text = "Class Registration";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.currentClassTextBox);
            this.statusGroupBox.Controls.Add(this.currentClassLabel);
            this.statusGroupBox.Controls.Add(this.classStatusTextBox);
            this.statusGroupBox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusGroupBox.Location = new System.Drawing.Point(5, 123);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(466, 267);
            this.statusGroupBox.TabIndex = 1;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Registration Status";
            // 
            // currentClassTextBox
            // 
            this.currentClassTextBox.Location = new System.Drawing.Point(120, 28);
            this.currentClassTextBox.Name = "currentClassTextBox";
            this.currentClassTextBox.ReadOnly = true;
            this.currentClassTextBox.Size = new System.Drawing.Size(100, 21);
            this.currentClassTextBox.TabIndex = 2;
            // 
            // currentClassLabel
            // 
            this.currentClassLabel.AutoSize = true;
            this.currentClassLabel.Location = new System.Drawing.Point(9, 31);
            this.currentClassLabel.Name = "currentClassLabel";
            this.currentClassLabel.Size = new System.Drawing.Size(105, 16);
            this.currentClassLabel.TabIndex = 1;
            this.currentClassLabel.Text = "Current Class:";
            // 
            // classStatusTextBox
            // 
            this.classStatusTextBox.Location = new System.Drawing.Point(6, 58);
            this.classStatusTextBox.Multiline = true;
            this.classStatusTextBox.Name = "classStatusTextBox";
            this.classStatusTextBox.Size = new System.Drawing.Size(454, 203);
            this.classStatusTextBox.TabIndex = 0;
            // 
            // attendancePicture
            // 
            this.attendancePicture.Image = global::RFID_Attendance_System_GUI.Properties.Resources.attendance;
            this.attendancePicture.Location = new System.Drawing.Point(14, 12);
            this.attendancePicture.Name = "attendancePicture";
            this.attendancePicture.Size = new System.Drawing.Size(100, 94);
            this.attendancePicture.TabIndex = 2;
            this.attendancePicture.TabStop = false;
            // 
            // ClassRegistrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.attendancePicture);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.classRegistrationLabel);
            this.Name = "ClassRegistrationUserControl";
            this.Size = new System.Drawing.Size(474, 405);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendancePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label classRegistrationLabel;
        private GroupBox statusGroupBox;
        private TextBox currentClassTextBox;
        private Label currentClassLabel;
        private TextBox classStatusTextBox;
        private PictureBox attendancePicture;
    }
}
