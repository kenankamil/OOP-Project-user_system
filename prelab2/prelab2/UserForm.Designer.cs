namespace ooplab
{
    partial class UserForm
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
            this.lblPhoneBook = new System.Windows.Forms.Label();
            this.btnPhoneBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhoneBook
            // 
            this.lblPhoneBook.AutoSize = true;
            this.lblPhoneBook.Location = new System.Drawing.Point(37, 142);
            this.lblPhoneBook.Name = "lblPhoneBook";
            this.lblPhoneBook.Size = new System.Drawing.Size(89, 17);
            this.lblPhoneBook.TabIndex = 0;
            this.lblPhoneBook.Text = "Phone Book:";
            // 
            // btnPhoneBook
            // 
            this.btnPhoneBook.Location = new System.Drawing.Point(147, 142);
            this.btnPhoneBook.Name = "btnPhoneBook";
            this.btnPhoneBook.Size = new System.Drawing.Size(75, 23);
            this.btnPhoneBook.TabIndex = 1;
            this.btnPhoneBook.Text = "Edit";
            this.btnPhoneBook.UseVisualStyleBackColor = true;
            this.btnPhoneBook.Click += new System.EventHandler(this.btnPhoneBook_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhoneBook);
            this.Controls.Add(this.lblPhoneBook);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhoneBook;
        private System.Windows.Forms.Button btnPhoneBook;
    }
}