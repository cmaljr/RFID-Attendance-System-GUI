namespace RFID_Attendance_System_GUI.User_Controls
{
    partial class CardRegistrationUserControl
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
            this.cardRegistrationButton = new System.Windows.Forms.Label();
            this.cardRegistrationBox = new System.Windows.Forms.GroupBox();
            this.cardSubmitButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.cardStatusBox = new System.Windows.Forms.GroupBox();
            this.cardStatusTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardRegistrationBox.SuspendLayout();
            this.cardStatusBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cardRegistrationButton
            // 
            this.cardRegistrationButton.AutoSize = true;
            this.cardRegistrationButton.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardRegistrationButton.Location = new System.Drawing.Point(118, 30);
            this.cardRegistrationButton.Name = "cardRegistrationButton";
            this.cardRegistrationButton.Size = new System.Drawing.Size(287, 35);
            this.cardRegistrationButton.TabIndex = 0;
            this.cardRegistrationButton.Text = "Card Registration";
            // 
            // cardRegistrationBox
            // 
            this.cardRegistrationBox.Controls.Add(this.cardSubmitButton);
            this.cardRegistrationBox.Controls.Add(this.lastNameTextBox);
            this.cardRegistrationBox.Controls.Add(this.lastNameLabel);
            this.cardRegistrationBox.Controls.Add(this.firstNameTextBox);
            this.cardRegistrationBox.Controls.Add(this.firstNameLabel);
            this.cardRegistrationBox.Controls.Add(this.cardStatusBox);
            this.cardRegistrationBox.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardRegistrationBox.Location = new System.Drawing.Point(12, 97);
            this.cardRegistrationBox.Name = "cardRegistrationBox";
            this.cardRegistrationBox.Size = new System.Drawing.Size(444, 289);
            this.cardRegistrationBox.TabIndex = 1;
            this.cardRegistrationBox.TabStop = false;
            // 
            // cardSubmitButton
            // 
            this.cardSubmitButton.Location = new System.Drawing.Point(8, 179);
            this.cardSubmitButton.Name = "cardSubmitButton";
            this.cardSubmitButton.Size = new System.Drawing.Size(184, 56);
            this.cardSubmitButton.TabIndex = 5;
            this.cardSubmitButton.Text = "Submit";
            this.cardSubmitButton.UseVisualStyleBackColor = true;
            this.cardSubmitButton.Click += new System.EventHandler(this.cardSubmitButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(8, 147);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(182, 21);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 114);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(126, 32);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Enter last name: \r\n(<16 characters) ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(8, 81);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(182, 21);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 46);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(133, 32);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Enter first name: \r\n(<16 characters) ";
            // 
            // cardStatusBox
            // 
            this.cardStatusBox.Controls.Add(this.cardStatusTextBox);
            this.cardStatusBox.Location = new System.Drawing.Point(203, 13);
            this.cardStatusBox.Name = "cardStatusBox";
            this.cardStatusBox.Size = new System.Drawing.Size(235, 270);
            this.cardStatusBox.TabIndex = 0;
            this.cardStatusBox.TabStop = false;
            this.cardStatusBox.Text = "Status";
            // 
            // cardStatusTextBox
            // 
            this.cardStatusTextBox.Location = new System.Drawing.Point(6, 22);
            this.cardStatusTextBox.Multiline = true;
            this.cardStatusTextBox.Name = "cardStatusTextBox";
            this.cardStatusTextBox.ReadOnly = true;
            this.cardStatusTextBox.Size = new System.Drawing.Size(223, 238);
            this.cardStatusTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFID_Attendance_System_GUI.Properties.Resources.card;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CardRegistrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cardRegistrationBox);
            this.Controls.Add(this.cardRegistrationButton);
            this.Name = "CardRegistrationUserControl";
            this.Size = new System.Drawing.Size(474, 405);
            this.cardRegistrationBox.ResumeLayout(false);
            this.cardRegistrationBox.PerformLayout();
            this.cardStatusBox.ResumeLayout(false);
            this.cardStatusBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cardRegistrationButton;
        private GroupBox cardRegistrationBox;
        private GroupBox cardStatusBox;
        private TextBox cardStatusTextBox;
        private Button cardSubmitButton;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private PictureBox pictureBox1;
    }
}
