namespace ooplab
{
    partial class Reminder
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
            this.btnReminderList = new System.Windows.Forms.Button();
            this.btnReminderAdd = new System.Windows.Forms.Button();
            this.btnReminderUpdate = new System.Windows.Forms.Button();
            this.btnReminderDelete = new System.Windows.Forms.Button();
            this.dgwReminders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReminderList
            // 
            this.btnReminderList.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReminderList.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminderList.ForeColor = System.Drawing.Color.White;
            this.btnReminderList.Location = new System.Drawing.Point(12, 24);
            this.btnReminderList.Name = "btnReminderList";
            this.btnReminderList.Size = new System.Drawing.Size(75, 31);
            this.btnReminderList.TabIndex = 1;
            this.btnReminderList.Text = "List";
            this.btnReminderList.UseVisualStyleBackColor = false;
            this.btnReminderList.Click += new System.EventHandler(this.btnReminderList_Click);
            // 
            // btnReminderAdd
            // 
            this.btnReminderAdd.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReminderAdd.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminderAdd.ForeColor = System.Drawing.Color.White;
            this.btnReminderAdd.Location = new System.Drawing.Point(12, 72);
            this.btnReminderAdd.Name = "btnReminderAdd";
            this.btnReminderAdd.Size = new System.Drawing.Size(75, 31);
            this.btnReminderAdd.TabIndex = 2;
            this.btnReminderAdd.Text = "Add";
            this.btnReminderAdd.UseVisualStyleBackColor = false;
            this.btnReminderAdd.Click += new System.EventHandler(this.btnReminderAdd_Click);
            // 
            // btnReminderUpdate
            // 
            this.btnReminderUpdate.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReminderUpdate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminderUpdate.ForeColor = System.Drawing.Color.White;
            this.btnReminderUpdate.Location = new System.Drawing.Point(12, 121);
            this.btnReminderUpdate.Name = "btnReminderUpdate";
            this.btnReminderUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnReminderUpdate.TabIndex = 3;
            this.btnReminderUpdate.Text = "Update";
            this.btnReminderUpdate.UseVisualStyleBackColor = false;
            this.btnReminderUpdate.Click += new System.EventHandler(this.btnReminderUpdate_Click);
            // 
            // btnReminderDelete
            // 
            this.btnReminderDelete.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReminderDelete.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminderDelete.ForeColor = System.Drawing.Color.White;
            this.btnReminderDelete.Location = new System.Drawing.Point(12, 167);
            this.btnReminderDelete.Name = "btnReminderDelete";
            this.btnReminderDelete.Size = new System.Drawing.Size(75, 31);
            this.btnReminderDelete.TabIndex = 4;
            this.btnReminderDelete.Text = "Delete";
            this.btnReminderDelete.UseVisualStyleBackColor = false;
            this.btnReminderDelete.Click += new System.EventHandler(this.btnReminderDelete_Click);
            // 
            // dgwReminders
            // 
            this.dgwReminders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgwReminders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwReminders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReminders.Location = new System.Drawing.Point(93, 12);
            this.dgwReminders.Name = "dgwReminders";
            this.dgwReminders.RowHeadersWidth = 51;
            this.dgwReminders.RowTemplate.Height = 24;
            this.dgwReminders.Size = new System.Drawing.Size(597, 220);
            this.dgwReminders.TabIndex = 5;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(711, 261);
            this.Controls.Add(this.dgwReminders);
            this.Controls.Add(this.btnReminderDelete);
            this.Controls.Add(this.btnReminderUpdate);
            this.Controls.Add(this.btnReminderAdd);
            this.Controls.Add(this.btnReminderList);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReminderList;
        private System.Windows.Forms.Button btnReminderAdd;
        private System.Windows.Forms.Button btnReminderUpdate;
        private System.Windows.Forms.Button btnReminderDelete;
        private System.Windows.Forms.DataGridView dgwReminders;
    }
}