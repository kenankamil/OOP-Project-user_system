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
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCreateRecords);
            this.Controls.Add(this.btnCreateRecords);
            this.Name = "Phonebook";
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Phonebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRecords;
        private System.Windows.Forms.Label lblCreateRecords;
    }
}