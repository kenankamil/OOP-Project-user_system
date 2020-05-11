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
            this.btnPreviosPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsignup = new System.Windows.Forms.Label();
            this.lblminimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(10, 129);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // btnReminderSave
            // 
            this.btnReminderSave.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReminderSave.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminderSave.ForeColor = System.Drawing.Color.White;
            this.btnReminderSave.Location = new System.Drawing.Point(225, 441);
            this.btnReminderSave.Name = "btnReminderSave";
            this.btnReminderSave.Size = new System.Drawing.Size(75, 38);
            this.btnReminderSave.TabIndex = 3;
            this.btnReminderSave.Text = "Save";
            this.btnReminderSave.UseVisualStyleBackColor = false;
            this.btnReminderSave.Click += new System.EventHandler(this.btnReminderSave_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(10, 175);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 17);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSummary.Location = new System.Drawing.Point(6, 221);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(79, 17);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "Summary:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(6, 267);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 17);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(47, 195);
            this.maskedTextBox1.Mask = "00:00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 23);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // cmbTimeAmPm
            // 
            this.cmbTimeAmPm.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTimeAmPm.FormattingEnabled = true;
            this.cmbTimeAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbTimeAmPm.Location = new System.Drawing.Point(180, 193);
            this.cmbTimeAmPm.Name = "cmbTimeAmPm";
            this.cmbTimeAmPm.Size = new System.Drawing.Size(65, 24);
            this.cmbTimeAmPm.TabIndex = 8;
            // 
            // txtboxSummary
            // 
            this.txtboxSummary.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSummary.Location = new System.Drawing.Point(47, 241);
            this.txtboxSummary.Name = "txtboxSummary";
            this.txtboxSummary.Size = new System.Drawing.Size(127, 23);
            this.txtboxSummary.TabIndex = 9;
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxDescription.Location = new System.Drawing.Point(47, 287);
            this.txtboxDescription.Multiline = true;
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(253, 148);
            this.txtboxDescription.TabIndex = 10;
            // 
            // lblReminderMessage
            // 
            this.lblReminderMessage.AutoSize = true;
            this.lblReminderMessage.Location = new System.Drawing.Point(142, 454);
            this.lblReminderMessage.Name = "lblReminderMessage";
            this.lblReminderMessage.Size = new System.Drawing.Size(0, 17);
            this.lblReminderMessage.TabIndex = 11;
            // 
            // lblReminderType
            // 
            this.lblReminderType.AutoSize = true;
            this.lblReminderType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReminderType.Location = new System.Drawing.Point(10, 66);
            this.lblReminderType.Name = "lblReminderType";
            this.lblReminderType.Size = new System.Drawing.Size(47, 17);
            this.lblReminderType.TabIndex = 12;
            this.lblReminderType.Text = "Type:";
            // 
            // rdoMeeting
            // 
            this.rdoMeeting.AutoSize = true;
            this.rdoMeeting.Checked = true;
            this.rdoMeeting.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoMeeting.Location = new System.Drawing.Point(47, 86);
            this.rdoMeeting.Name = "rdoMeeting";
            this.rdoMeeting.Size = new System.Drawing.Size(84, 21);
            this.rdoMeeting.TabIndex = 13;
            this.rdoMeeting.TabStop = true;
            this.rdoMeeting.Text = "Meeting";
            this.rdoMeeting.UseVisualStyleBackColor = true;
            this.rdoMeeting.CheckedChanged += new System.EventHandler(this.rdoMeeting_CheckedChanged);
            // 
            // rdoTask
            // 
            this.rdoTask.AutoSize = true;
            this.rdoTask.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoTask.Location = new System.Drawing.Point(47, 105);
            this.rdoTask.Name = "rdoTask";
            this.rdoTask.Size = new System.Drawing.Size(61, 21);
            this.rdoTask.TabIndex = 14;
            this.rdoTask.Text = "Task";
            this.rdoTask.UseVisualStyleBackColor = true;
            this.rdoTask.CheckedChanged += new System.EventHandler(this.rdoTask_CheckedChanged);
            // 
            // btnPreviosPage
            // 
            this.btnPreviosPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnPreviosPage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviosPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviosPage.Location = new System.Drawing.Point(47, 441);
            this.btnPreviosPage.Name = "btnPreviosPage";
            this.btnPreviosPage.Size = new System.Drawing.Size(75, 38);
            this.btnPreviosPage.TabIndex = 15;
            this.btnPreviosPage.Text = "<--";
            this.btnPreviosPage.UseVisualStyleBackColor = false;
            this.btnPreviosPage.Click += new System.EventHandler(this.btnPreviosPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 60);
            this.panel2.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblsignup);
            this.panel1.Controls.Add(this.lblminimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 60);
            this.panel1.TabIndex = 34;
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsignup.ForeColor = System.Drawing.Color.White;
            this.lblsignup.Location = new System.Drawing.Point(111, 20);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(146, 21);
            this.lblsignup.TabIndex = 5;
            this.lblsignup.Text = "ADD REMINDER";
            // 
            // lblminimize
            // 
            this.lblminimize.AutoSize = true;
            this.lblminimize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminimize.ForeColor = System.Drawing.Color.White;
            this.lblminimize.Location = new System.Drawing.Point(305, 0);
            this.lblminimize.Name = "lblminimize";
            this.lblminimize.Size = new System.Drawing.Size(21, 21);
            this.lblminimize.TabIndex = 4;
            this.lblminimize.Text = "_";
            this.lblminimize.Click += new System.EventHandler(this.lblminimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPreviosPage);
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
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddReminders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnPreviosPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label label1;
    }
}