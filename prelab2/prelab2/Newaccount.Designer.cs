namespace prelab2
{
    partial class Newaccount
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.lbkullanıcıadi = new System.Windows.Forms.Label();
            this.lbsifre = new System.Windows.Forms.Label();
            this.lbconfirm = new System.Windows.Forms.Label();
            this.btnnewaccount = new System.Windows.Forms.Button();
            this.lblhata = new System.Windows.Forms.Label();
            this.lbmassage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(140, 87);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 22);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(140, 127);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 22);
            this.txtpassword.TabIndex = 1;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(140, 155);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(100, 22);
            this.txtconfirm.TabIndex = 2;
            // 
            // lbkullanıcıadi
            // 
            this.lbkullanıcıadi.AutoSize = true;
            this.lbkullanıcıadi.Location = new System.Drawing.Point(39, 87);
            this.lbkullanıcıadi.Name = "lbkullanıcıadi";
            this.lbkullanıcıadi.Size = new System.Drawing.Size(83, 17);
            this.lbkullanıcıadi.TabIndex = 3;
            this.lbkullanıcıadi.Text = "User Name:";
            // 
            // lbsifre
            // 
            this.lbsifre.AutoSize = true;
            this.lbsifre.Location = new System.Drawing.Point(39, 130);
            this.lbsifre.Name = "lbsifre";
            this.lbsifre.Size = new System.Drawing.Size(73, 17);
            this.lbsifre.TabIndex = 4;
            this.lbsifre.Text = "Password:";
            // 
            // lbconfirm
            // 
            this.lbconfirm.AutoSize = true;
            this.lbconfirm.Location = new System.Drawing.Point(39, 160);
            this.lbconfirm.Name = "lbconfirm";
            this.lbconfirm.Size = new System.Drawing.Size(60, 17);
            this.lbconfirm.TabIndex = 5;
            this.lbconfirm.Text = "Confirm:";
            // 
            // btnnewaccount
            // 
            this.btnnewaccount.Location = new System.Drawing.Point(151, 183);
            this.btnnewaccount.Name = "btnnewaccount";
            this.btnnewaccount.Size = new System.Drawing.Size(75, 23);
            this.btnnewaccount.TabIndex = 6;
            this.btnnewaccount.Text = "Okay";
            this.btnnewaccount.UseVisualStyleBackColor = true;
            this.btnnewaccount.Click += new System.EventHandler(this.btnnewaccount_Click);
            // 
            // lblhata
            // 
            this.lblhata.AutoSize = true;
            this.lblhata.Location = new System.Drawing.Point(160, 235);
            this.lblhata.Name = "lblhata";
            this.lblhata.Size = new System.Drawing.Size(0, 17);
            this.lblhata.TabIndex = 8;
            // 
            // lbmassage
            // 
            this.lbmassage.AutoSize = true;
            this.lbmassage.Location = new System.Drawing.Point(291, 235);
            this.lbmassage.Name = "lbmassage";
            this.lbmassage.Size = new System.Drawing.Size(0, 17);
            this.lbmassage.TabIndex = 7;
            // 
            // Newaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 304);
            this.Controls.Add(this.lblhata);
            this.Controls.Add(this.lbmassage);
            this.Controls.Add(this.btnnewaccount);
            this.Controls.Add(this.lbconfirm);
            this.Controls.Add(this.lbsifre);
            this.Controls.Add(this.lbkullanıcıadi);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Name = "Newaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newaccount";
            this.Load += new System.EventHandler(this.Newaccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label lbkullanıcıadi;
        private System.Windows.Forms.Label lbsifre;
        private System.Windows.Forms.Label lbconfirm;
        private System.Windows.Forms.Button btnnewaccount;
        private System.Windows.Forms.Label lblhata;
        private System.Windows.Forms.Label lbmassage;
    }
}