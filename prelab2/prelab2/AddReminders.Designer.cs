namespace ooplab
{
    partial class AddReminders
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnReminderSave = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbTimeAmPm = new System.Windows.Forms.ComboBox();
            this.txtboxSummary = new System.Windows.Forms.TextBox();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.lblReminderMessage = new System.Windows.Forms.Label();
            this.lblReminderType = new System.Windows.Forms.Label();
            this.rdoMeeting = new System.Windows.Forms.RadioButton();
            this.rdoTask = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 72);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // btnReminderSave
            // 
            this.btnReminderSave.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReminderSave.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminderSave.ForeColor = System.Drawing.Color.White;
            this.btnReminderSave.Location = new System.Drawing.Point(11, 407);
            this.btnReminderSave.Name = "btnReminderSave";
            this.btnReminderSave.Size = new System.Drawing.Size(75, 31);
            this.btnReminderSave.TabIndex = 3;
            this.btnReminderSave.Text = "Save";
            this.btnReminderSave.UseVisualStyleBackColor = false;
            this.btnReminderSave.Click += new System.EventHandler(this.btnReminderSave_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(16, 127);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(12, 178);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(71, 17);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "Summary:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 223);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(53, 147);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 28);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // cmbTimeAmPm
            // 
            this.cmbTimeAmPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTimeAmPm.FormattingEnabled = true;
            this.cmbTimeAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbTimeAmPm.Location = new System.Drawing.Point(186, 145);
            this.cmbTimeAmPm.Name = "cmbTimeAmPm";
            this.cmbTimeAmPm.Size = new System.Drawing.Size(65, 30);
            this.cmbTimeAmPm.TabIndex = 8;
            // 
            // txtboxSummary
            // 
            this.txtboxSummary.Location = new System.Drawing.Point(53, 198);
            this.txtboxSummary.Name = "txtboxSummary";
            this.txtboxSummary.Size = new System.Drawing.Size(127, 22);
            this.txtboxSummary.TabIndex = 9;
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(53, 243);
            this.txtboxDescription.Multiline = true;
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(253, 148);
            this.txtboxDescription.TabIndex = 10;
            // 
            // lblReminderMessage
            // 
            this.lblReminderMessage.AutoSize = true;
            this.lblReminderMessage.Location = new System.Drawing.Point(95, 414);
            this.lblReminderMessage.Name = "lblReminderMessage";
            this.lblReminderMessage.Size = new System.Drawing.Size(0, 17);
            this.lblReminderMessage.TabIndex = 11;
            // 
            // lblReminderType
            // 
            this.lblReminderType.AutoSize = true;
            this.lblReminderType.Location = new System.Drawing.Point(16, 9);
            this.lblReminderType.Name = "lblReminderType";
            this.lblReminderType.Size = new System.Drawing.Size(44, 17);
            this.lblReminderType.TabIndex = 12;
            this.lblReminderType.Text = "Type:";
            // 
            // rdoMeeting
            // 
            this.rdoMeeting.AutoSize = true;
            this.rdoMeeting.Checked = true;
            this.rdoMeeting.Location = new System.Drawing.Point(53, 29);
            this.rdoMeeting.Name = "rdoMeeting";
            this.rdoMeeting.Size = new System.Drawing.Size(79, 21);
            this.rdoMeeting.TabIndex = 13;
            this.rdoMeeting.TabStop = true;
            this.rdoMeeting.Text = "Meeting";
            this.rdoMeeting.UseVisualStyleBackColor = true;
            this.rdoMeeting.CheckedChanged += new System.EventHandler(this.rdoMeeting_CheckedChanged);
            // 
            // rdoTask
            // 
            this.rdoTask.AutoSize = true;
            this.rdoTask.Location = new System.Drawing.Point(53, 56);
            this.rdoTask.Name = "rdoTask";
            this.rdoTask.Size = new System.Drawing.Size(60, 21);
            this.rdoTask.TabIndex = 14;
            this.rdoTask.Text = "Task";
            this.rdoTask.UseVisualStyleBackColor = true;
            this.rdoTask.CheckedChanged += new System.EventHandler(this.rdoTask_CheckedChanged);
            // 
            // AddReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.rdoTask);
            this.Controls.Add(this.rdoMeeting);
            this.Controls.Add(this.lblReminderType);
            this.Controls.Add(this.lblReminderMessage);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.txtboxSummary);
            this.Controls.Add(this.cmbTimeAmPm);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReminderSave);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddReminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReminders";
            this.Load += new System.EventHandler(this.AddReminders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnReminderSave;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cmbTimeAmPm;
        private System.Windows.Forms.TextBox txtboxSummary;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.Label lblReminderMessage;
        private System.Windows.Forms.Label lblReminderType;
        private System.Windows.Forms.RadioButton rdoMeeting;
        private System.Windows.Forms.RadioButton rdoTask;
    }
}