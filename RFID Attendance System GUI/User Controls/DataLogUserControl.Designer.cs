namespace RFID_Attendance_System_GUI.User_Controls
{
    partial class DataLogUserControl
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
            this.DataLogTitle = new System.Windows.Forms.Label();
            this.dataLogBox = new System.Windows.Forms.GroupBox();
            this.classLogTextBox = new System.Windows.Forms.MaskedTextBox();
            this.classLogLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registeredStudemtsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataLogBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataLogTitle
            // 
            this.DataLogTitle.AutoSize = true;
            this.DataLogTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataLogTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataLogTitle.Location = new System.Drawing.Point(0, 0);
            this.DataLogTitle.Name = "DataLogTitle";
            this.DataLogTitle.Size = new System.Drawing.Size(125, 37);
            this.DataLogTitle.TabIndex = 2;
            this.DataLogTitle.Text = "Data Log";
            // 
            // dataLogBox
            // 
            this.dataLogBox.Controls.Add(this.button1);
            this.dataLogBox.Controls.Add(this.registeredStudemtsButton);
            this.dataLogBox.Controls.Add(this.classLogTextBox);
            this.dataLogBox.Controls.Add(this.classLogLabel);
            this.dataLogBox.Controls.Add(this.dataGridView1);
            this.dataLogBox.Location = new System.Drawing.Point(22, 105);
            this.dataLogBox.Name = "dataLogBox";
            this.dataLogBox.Size = new System.Drawing.Size(553, 239);
            this.dataLogBox.TabIndex = 3;
            this.dataLogBox.TabStop = false;
            this.dataLogBox.Text = "Data Log";
            // 
            // classLogTextBox
            // 
            this.classLogTextBox.Location = new System.Drawing.Point(39, 68);
            this.classLogTextBox.Name = "classLogTextBox";
            this.classLogTextBox.Size = new System.Drawing.Size(100, 23);
            this.classLogTextBox.TabIndex = 2;
            // 
            // classLogLabel
            // 
            this.classLogLabel.AutoSize = true;
            this.classLogLabel.Location = new System.Drawing.Point(39, 50);
            this.classLogLabel.Name = "classLogLabel";
            this.classLogLabel.Size = new System.Drawing.Size(80, 15);
            this.classLogLabel.TabIndex = 1;
            this.classLogLabel.Text = "Current Class:";
            // 
            // registeredStudemtsButton
            // 
            this.registeredStudemtsButton.CausesValidation = false;
            this.registeredStudemtsButton.Location = new System.Drawing.Point(39, 137);
            this.registeredStudemtsButton.Name = "registeredStudemtsButton";
            this.registeredStudemtsButton.Size = new System.Drawing.Size(75, 51);
            this.registeredStudemtsButton.TabIndex = 3;
            this.registeredStudemtsButton.Text = "Open Students";
            this.registeredStudemtsButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(137, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open Students";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DataLogUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.dataLogBox);
            this.Controls.Add(this.DataLogTitle);
            this.Name = "DataLogUserControl";
            this.Size = new System.Drawing.Size(600, 417);
            this.dataLogBox.ResumeLayout(false);
            this.dataLogBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DataLogTitle;
        private GroupBox dataLogBox;
        private MaskedTextBox classLogTextBox;
        private Label classLogLabel;
        private DataGridView dataGridView1;
        private Button button1;
        private Button registeredStudemtsButton;
    }
}
