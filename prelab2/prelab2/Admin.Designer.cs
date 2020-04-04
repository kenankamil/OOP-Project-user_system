namespace ooplab
{
    partial class Admin
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
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(12, 136);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(153, 29);
            this.btnUserManagement.TabIndex = 0;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(9, 79);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(77, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Username:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 17);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Type";
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(88, 31);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(47, 17);
            this.lblType1.TabIndex = 3;
            this.lblType1.Text = "Admin";
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(92, 79);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(0, 17);
            this.lblName1.TabIndex = 4;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblType1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnUserManagement);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label lblName1;
    }
}