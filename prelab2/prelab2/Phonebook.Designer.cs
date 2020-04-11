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
            this.lblCreateRecords = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.lsbPhoneBook = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCreateRecords
            // 
            this.btnCreateRecords.Location = new System.Drawing.Point(128, 53);
            this.btnCreateRecords.Name = "btnCreateRecords";
            this.btnCreateRecords.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRecords.TabIndex = 0;
            this.btnCreateRecords.Text = "Create";
            this.btnCreateRecords.UseVisualStyleBackColor = true;
            this.btnCreateRecords.Click += new System.EventHandler(this.BtnCreateRecords_Click);
            // 
            // lblCreateRecords
            // 
            this.lblCreateRecords.AutoSize = true;
            this.lblCreateRecords.Location = new System.Drawing.Point(5, 56);
            this.lblCreateRecords.Name = "lblCreateRecords";
            this.lblCreateRecords.Size = new System.Drawing.Size(111, 17);
            this.lblCreateRecords.TabIndex = 1;
            this.lblCreateRecords.Text = "Create Records:";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(12, 102);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(34, 17);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "List:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(128, 96);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lsbPhoneBook
            // 
            this.lsbPhoneBook.FormattingEnabled = true;
            this.lsbPhoneBook.ItemHeight = 16;
            this.lsbPhoneBook.Location = new System.Drawing.Point(209, 12);
            this.lsbPhoneBook.Name = "lsbPhoneBook";
            this.lsbPhoneBook.Size = new System.Drawing.Size(748, 228);
            this.lsbPhoneBook.TabIndex = 4;
            this.lsbPhoneBook.SelectedIndexChanged += new System.EventHandler(this.lsbPhoneBook_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(429, 246);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(288, 124);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 398);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lsbPhoneBook);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblCreateRecords);
            this.Controls.Add(this.btnCreateRecords);
            this.Name = "Phonebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Phonebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRecords;
        private System.Windows.Forms.Label lblCreateRecords;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox lsbPhoneBook;
        private System.Windows.Forms.ListView listView1;
    }
}