namespace RFID_Attendance_System_GUI.User_Controls
{
    partial class AttendanceUserControl
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
            this.attendanceTitle = new System.Windows.Forms.Label();
            this.attendanceDataBox = new System.Windows.Forms.GroupBox();
            this.setTimeButton = new System.Windows.Forms.Button();
            this.setTimeTextBox = new System.Windows.Forms.TextBox();
            this.setTimeLabel = new System.Windows.Forms.Label();
            this.attendanceDataGrid = new System.Windows.Forms.DataGridView();
            this.pencilImage = new System.Windows.Forms.PictureBox();
            this.attendanceDataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilImage)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceTitle
            // 
            this.attendanceTitle.AutoSize = true;
            this.attendanceTitle.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attendanceTitle.Location = new System.Drawing.Point(130, 33);
            this.attendanceTitle.Name = "attendanceTitle";
            this.attendanceTitle.Size = new System.Drawing.Size(175, 35);
            this.attendanceTitle.TabIndex = 0;
            this.attendanceTitle.Text = "Attendance";
            // 
            // attendanceDataBox
            // 
            this.attendanceDataBox.Controls.Add(this.setTimeButton);
            this.attendanceDataBox.Controls.Add(this.setTimeTextBox);
            this.attendanceDataBox.Controls.Add(this.setTimeLabel);
            this.attendanceDataBox.Controls.Add(this.attendanceDataGrid);
            this.attendanceDataBox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attendanceDataBox.Location = new System.Drawing.Point(3, 100);
            this.attendanceDataBox.Name = "attendanceDataBox";
            this.attendanceDataBox.Size = new System.Drawing.Size(468, 302);
            this.attendanceDataBox.TabIndex = 1;
            this.attendanceDataBox.TabStop = false;
            this.attendanceDataBox.Text = "Attendance Record";
            // 
            // setTimeButton
            // 
            this.setTimeButton.Location = new System.Drawing.Point(201, 45);
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.Size = new System.Drawing.Size(75, 23);
            this.setTimeButton.TabIndex = 3;
            this.setTimeButton.Text = "Submit";
            this.setTimeButton.UseVisualStyleBackColor = true;
            this.setTimeButton.Click += new System.EventHandler(this.setTimeButton_Click);
            // 
            // setTimeTextBox
            // 
            this.setTimeTextBox.Location = new System.Drawing.Point(6, 47);
            this.setTimeTextBox.Name = "setTimeTextBox";
            this.setTimeTextBox.Size = new System.Drawing.Size(189, 21);
            this.setTimeTextBox.TabIndex = 2;
            // 
            // setTimeLabel
            // 
            this.setTimeLabel.AutoSize = true;
            this.setTimeLabel.Location = new System.Drawing.Point(6, 29);
            this.setTimeLabel.Name = "setTimeLabel";
            this.setTimeLabel.Size = new System.Drawing.Size(189, 16);
            this.setTimeLabel.TabIndex = 1;
            this.setTimeLabel.Text = "Set time (24-Hour Format):";
            // 
            // attendanceDataGrid
            // 
            this.attendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceDataGrid.Location = new System.Drawing.Point(6, 84);
            this.attendanceDataGrid.Name = "attendanceDataGrid";
            this.attendanceDataGrid.RowTemplate.Height = 25;
            this.attendanceDataGrid.Size = new System.Drawing.Size(456, 200);
            this.attendanceDataGrid.TabIndex = 0;
            // 
            // pencilImage
            // 
            this.pencilImage.Image = global::RFID_Attendance_System_GUI.Properties.Resources.pencil;
            this.pencilImage.Location = new System.Drawing.Point(18, 0);
            this.pencilImage.Name = "pencilImage";
            this.pencilImage.Size = new System.Drawing.Size(95, 94);
            this.pencilImage.TabIndex = 2;
            this.pencilImage.TabStop = false;
            // 
            // AttendanceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pencilImage);
            this.Controls.Add(this.attendanceDataBox);
            this.Controls.Add(this.attendanceTitle);
            this.Name = "AttendanceUserControl";
            this.Size = new System.Drawing.Size(474, 405);
            this.attendanceDataBox.ResumeLayout(false);
            this.attendanceDataBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label attendanceTitle;
        private GroupBox attendanceDataBox;
        private DataGridView attendanceDataGrid;
        private Button setTimeButton;
        private TextBox setTimeTextBox;
        private Label setTimeLabel;
        private PictureBox pencilImage;
    }
}
