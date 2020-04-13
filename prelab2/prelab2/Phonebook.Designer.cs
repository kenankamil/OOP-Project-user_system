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
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRecords
            // 
            this.btnCreateRecords.Location = new System.Drawing.Point(37, 49);
            this.btnCreateRecords.Name = "btnCreateRecords";
            this.btnCreateRecords.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRecords.TabIndex = 0;
            this.btnCreateRecords.Text = "Create";
            this.btnCreateRecords.UseVisualStyleBackColor = true;
            this.btnCreateRecords.Click += new System.EventHandler(this.BtnCreateRecords_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(37, 91);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dgwRecords
            // 
            this.dgwRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecords.Location = new System.Drawing.Point(224, 21);
            this.dgwRecords.Name = "dgwRecords";
            this.dgwRecords.RowHeadersWidth = 51;
            this.dgwRecords.RowTemplate.Height = 24;
            this.dgwRecords.Size = new System.Drawing.Size(742, 210);
            this.dgwRecords.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(221, 246);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 398);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgwRecords);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCreateRecords);
            this.Name = "Phonebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Phonebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRecords;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dgwRecords;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDelete;
    }
}