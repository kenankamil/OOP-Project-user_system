namespace ooplab
{
    partial class Part_time_User
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
            this.btnPhonebook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPhonebook
            // 
            this.btnPhonebook.Location = new System.Drawing.Point(103, 201);
            this.btnPhonebook.Name = "btnPhonebook";
            this.btnPhonebook.Size = new System.Drawing.Size(103, 30);
            this.btnPhonebook.TabIndex = 0;
            this.btnPhonebook.Text = "Phonebook";
            this.btnPhonebook.UseVisualStyleBackColor = true;
            this.btnPhonebook.Click += new System.EventHandler(this.btnPhonebook_Click);
            // 
            // Part_time_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhonebook);
            this.Name = "Part_time_User";
            this.Text = "Part_time_User";
            this.Load += new System.EventHandler(this.Part_time_User_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPhonebook;
    }
}