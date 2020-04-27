namespace ooplab
{
    partial class Notes
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
            this.dgwNotes = new System.Windows.Forms.DataGridView();
            this.txtNewNote = new System.Windows.Forms.TextBox();
            this.lblmassage = new System.Windows.Forms.Label();
            this.btnCreatNote = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblminimize = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreviosPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwNotes
            // 
            this.dgwNotes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotes.Location = new System.Drawing.Point(99, 93);
            this.dgwNotes.Name = "dgwNotes";
            this.dgwNotes.RowHeadersWidth = 40;
            this.dgwNotes.RowTemplate.Height = 24;
            this.dgwNotes.Size = new System.Drawing.Size(487, 169);
            this.dgwNotes.TabIndex = 0;
            // 
            // txtNewNote
            // 
            this.txtNewNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewNote.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewNote.Location = new System.Drawing.Point(99, 292);
            this.txtNewNote.Name = "txtNewNote";
            this.txtNewNote.Size = new System.Drawing.Size(487, 16);
            this.txtNewNote.TabIndex = 1;
            this.txtNewNote.Text = "Enter your notes here !";
            this.txtNewNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewNote.Click += new System.EventHandler(this.txtNewNote_Click);
            // 
            // lblmassage
            // 
            this.lblmassage.AutoSize = true;
            this.lblmassage.Location = new System.Drawing.Point(251, 430);
            this.lblmassage.Name = "lblmassage";
            this.lblmassage.Size = new System.Drawing.Size(0, 17);
            this.lblmassage.TabIndex = 2;
            // 
            // btnCreatNote
            // 
            this.btnCreatNote.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCreatNote.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreatNote.ForeColor = System.Drawing.Color.White;
            this.btnCreatNote.Location = new System.Drawing.Point(286, 334);
            this.btnCreatNote.Name = "btnCreatNote";
            this.btnCreatNote.Size = new System.Drawing.Size(101, 37);
            this.btnCreatNote.TabIndex = 3;
            this.btnCreatNote.Text = "New Note";
            this.btnCreatNote.UseVisualStyleBackColor = false;
            this.btnCreatNote.Click += new System.EventHandler(this.BtnCreatNote_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnList.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(12, 102);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 34);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblminimize
            // 
            this.lblminimize.AutoSize = true;
            this.lblminimize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminimize.ForeColor = System.Drawing.Color.White;
            this.lblminimize.Location = new System.Drawing.Point(565, 0);
            this.lblminimize.Name = "lblminimize";
            this.lblminimize.Size = new System.Drawing.Size(21, 21);
            this.lblminimize.TabIndex = 1;
            this.lblminimize.Text = "_";
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(592, 0);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(22, 21);
            this.lblclose.TabIndex = 0;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
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
            this.panel1.Size = new System.Drawing.Size(614, 60);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(293, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "NOTES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 60);
            this.panel2.TabIndex = 31;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreviosPage
            // 
            this.btnPreviosPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnPreviosPage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviosPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviosPage.Location = new System.Drawing.Point(12, 337);
            this.btnPreviosPage.Name = "btnPreviosPage";
            this.btnPreviosPage.Size = new System.Drawing.Size(75, 34);
            this.btnPreviosPage.TabIndex = 33;
            this.btnPreviosPage.Text = "<--";
            this.btnPreviosPage.UseVisualStyleBackColor = false;
            this.btnPreviosPage.Click += new System.EventHandler(this.btnPreviosPage_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(614, 459);
            this.Controls.Add(this.btnPreviosPage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCreatNote);
            this.Controls.Add(this.lblmassage);
            this.Controls.Add(this.txtNewNote);
            this.Controls.Add(this.dgwNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNotes;
        private System.Windows.Forms.TextBox txtNewNote;
        private System.Windows.Forms.Label lblmassage;
        private System.Windows.Forms.Button btnCreatNote;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreviosPage;
    }
}