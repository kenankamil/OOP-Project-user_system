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
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwNotes
            // 
            this.dgwNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotes.Location = new System.Drawing.Point(121, 12);
            this.dgwNotes.Name = "dgwNotes";
            this.dgwNotes.RowHeadersWidth = 51;
            this.dgwNotes.RowTemplate.Height = 24;
            this.dgwNotes.Size = new System.Drawing.Size(562, 169);
            this.dgwNotes.TabIndex = 0;
            // 
            // txtNewNote
            // 
            this.txtNewNote.Location = new System.Drawing.Point(121, 224);
            this.txtNewNote.Name = "txtNewNote";
            this.txtNewNote.Size = new System.Drawing.Size(388, 22);
            this.txtNewNote.TabIndex = 1;
            // 
            // lblmassage
            // 
            this.lblmassage.AutoSize = true;
            this.lblmassage.Location = new System.Drawing.Point(255, 338);
            this.lblmassage.Name = "lblmassage";
            this.lblmassage.Size = new System.Drawing.Size(0, 17);
            this.lblmassage.TabIndex = 2;
            // 
            // btnCreatNote
            // 
            this.btnCreatNote.Location = new System.Drawing.Point(247, 292);
            this.btnCreatNote.Name = "btnCreatNote";
            this.btnCreatNote.Size = new System.Drawing.Size(101, 29);
            this.btnCreatNote.TabIndex = 3;
            this.btnCreatNote.Text = "New Note";
            this.btnCreatNote.UseVisualStyleBackColor = true;
            this.btnCreatNote.Click += new System.EventHandler(this.BtnCreatNote_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(22, 35);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCreatNote);
            this.Controls.Add(this.lblmassage);
            this.Controls.Add(this.txtNewNote);
            this.Controls.Add(this.dgwNotes);
            this.Name = "Notes";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).EndInit();
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
    }
}