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
            this.btnPreviosPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblminimize = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReminders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReminderList
            // 
            this.btnReminderList.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReminderList.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminderList.ForeColor = System.Drawing.Color.White;
            this.btnReminderList.Location = new System.Drawing.Point(12, 90);
            this.btnReminderList.Name = "btnReminderList";
            this.btnReminderList.Size = new System.Drawing.Size(75, 38);
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
            this.btnReminderAdd.Location = new System.Drawing.Point(12, 138);
            this.btnReminderAdd.Name = "btnReminderAdd";
            this.btnReminderAdd.Size = new System.Drawing.Size(75, 38);
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
            this.btnReminderUpdate.Location = new System.Drawing.Point(12, 187);
            this.btnReminderUpdate.Name = "btnReminderUpdate";
            this.btnReminderUpdate.Size = new System.Drawing.Size(75, 38);
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
            this.btnReminderDelete.Location = new System.Drawing.Point(12, 233);
            this.btnReminderDelete.Name = "btnReminderDelete";
            this.btnReminderDelete.Size = new System.Drawing.Size(75, 38);
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
            this.dgwReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReminders.Location = new System.Drawing.Point(93, 90);
            this.dgwReminders.Name = "dgwReminders";
            this.dgwReminders.RowHeadersWidth = 51;
            this.dgwReminders.RowTemplate.Height = 24;
            this.dgwReminders.Size = new System.Drawing.Size(597, 220);
            this.dgwReminders.TabIndex = 5;
            // 
            // btnPreviosPage
            // 
            this.btnPreviosPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnPreviosPage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviosPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviosPage.Location = new System.Drawing.Point(12, 320);
            this.btnPreviosPage.Name = "btnPreviosPage";
            this.btnPreviosPage.Size = new System.Drawing.Size(75, 45);
            this.btnPreviosPage.TabIndex = 28;
            this.btnPreviosPage.Text = "<--";
            this.btnPreviosPage.UseVisualStyleBackColor = false;
            this.btnPreviosPage.Click += new System.EventHandler(this.btnPreviosPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 60);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblminimize);
            this.panel1.Controls.Add(this.lblclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 60);
            this.panel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(309, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "REMINDER";
            // 
            // lblminimize
            // 
            this.lblminimize.AutoSize = true;
            this.lblminimize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminimize.ForeColor = System.Drawing.Color.White;
            this.lblminimize.Location = new System.Drawing.Point(659, 0);
            this.lblminimize.Name = "lblminimize";
            this.lblminimize.Size = new System.Drawing.Size(21, 21);
            this.lblminimize.TabIndex = 4;
            this.lblminimize.Text = "_";
            this.lblminimize.Click += new System.EventHandler(this.lblminimize_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(686, 0);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(22, 21);
            this.lblclose.TabIndex = 3;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(711, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPreviosPage);
            this.Controls.Add(this.dgwReminders);
            this.Controls.Add(this.btnReminderDelete);
            this.Controls.Add(this.btnReminderUpdate);
            this.Controls.Add(this.btnReminderAdd);
            this.Controls.Add(this.btnReminderList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReminders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReminderList;
        private System.Windows.Forms.Button btnReminderAdd;
        private System.Windows.Forms.Button btnReminderUpdate;
        private System.Windows.Forms.Button btnReminderDelete;
        private System.Windows.Forms.DataGridView dgwReminders;
        private System.Windows.Forms.Button btnPreviosPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label lblclose;
    }
}