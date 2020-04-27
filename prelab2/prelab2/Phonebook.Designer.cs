namespace ooplab
{
    partial class Phonebook
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
            this.btnCreateRecords = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.dgwRecords = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblminimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnPreviosPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateRecords
            // 
            this.btnCreateRecords.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCreateRecords.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateRecords.ForeColor = System.Drawing.Color.White;
            this.btnCreateRecords.Location = new System.Drawing.Point(12, 142);
            this.btnCreateRecords.Name = "btnCreateRecords";
            this.btnCreateRecords.Size = new System.Drawing.Size(75, 31);
            this.btnCreateRecords.TabIndex = 0;
            this.btnCreateRecords.Text = "Create";
            this.btnCreateRecords.UseVisualStyleBackColor = false;
            this.btnCreateRecords.Click += new System.EventHandler(this.BtnCreateRecords_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnList.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(12, 184);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 31);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dgwRecords
            // 
            this.dgwRecords.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecords.Location = new System.Drawing.Point(101, 120);
            this.dgwRecords.Name = "dgwRecords";
            this.dgwRecords.RowHeadersWidth = 51;
            this.dgwRecords.RowTemplate.Height = 24;
            this.dgwRecords.Size = new System.Drawing.Size(490, 210);
            this.dgwRecords.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(186, 366);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 60);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblminimize);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 60);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(242, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "PHONEBOOK";
            // 
            // lblminimize
            // 
            this.lblminimize.AutoSize = true;
            this.lblminimize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminimize.ForeColor = System.Drawing.Color.White;
            this.lblminimize.Location = new System.Drawing.Point(570, 0);
            this.lblminimize.Name = "lblminimize";
            this.lblminimize.Size = new System.Drawing.Size(21, 21);
            this.lblminimize.TabIndex = 3;
            this.lblminimize.Text = "_";
            this.lblminimize.Click += new System.EventHandler(this.lblminimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(592, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 21);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnPreviosPage
            // 
            this.btnPreviosPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnPreviosPage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviosPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviosPage.Location = new System.Drawing.Point(12, 366);
            this.btnPreviosPage.Name = "btnPreviosPage";
            this.btnPreviosPage.Size = new System.Drawing.Size(75, 34);
            this.btnPreviosPage.TabIndex = 31;
            this.btnPreviosPage.Text = "<--";
            this.btnPreviosPage.UseVisualStyleBackColor = false;
            this.btnPreviosPage.Click += new System.EventHandler(this.btnPreviosPage_Click);
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 478);
            this.Controls.Add(this.btnPreviosPage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgwRecords);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCreateRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phonebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Phonebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRecords;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dgwRecords;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPreviosPage;
    }
}