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
            this.lbconfirm = new System.Windows.Forms.Label();
            this.btnnewaccount = new System.Windows.Forms.Button();
            this.lblhata = new System.Windows.Forms.Label();
            this.lbmassage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsignup = new System.Windows.Forms.Label();
            this.lblminimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbsifre = new System.Windows.Forms.Label();
            this.lbkullanıcıadi = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbconfirm
            // 
            this.lbconfirm.AutoSize = true;
            this.lbconfirm.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbconfirm.Location = new System.Drawing.Point(83, 217);
            this.lbconfirm.Name = "lbconfirm";
            this.lbconfirm.Size = new System.Drawing.Size(82, 17);
            this.lbconfirm.TabIndex = 5;
            this.lbconfirm.Text = "CONFIRM:";
            // 
            // btnnewaccount
            // 
            this.btnnewaccount.BackColor = System.Drawing.Color.Black;
            this.btnnewaccount.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnewaccount.ForeColor = System.Drawing.Color.White;
            this.btnnewaccount.Location = new System.Drawing.Point(146, 287);
            this.btnnewaccount.Name = "btnnewaccount";
            this.btnnewaccount.Size = new System.Drawing.Size(75, 34);
            this.btnnewaccount.TabIndex = 6;
            this.btnnewaccount.Text = "Okay";
            this.btnnewaccount.UseVisualStyleBackColor = false;
            this.btnnewaccount.Click += new System.EventHandler(this.btnnewaccount_Click);
            // 
            // lblhata
            // 
            this.lblhata.AutoSize = true;
            this.lblhata.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblhata.ForeColor = System.Drawing.Color.Red;
            this.lblhata.Location = new System.Drawing.Point(117, 415);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblsignup);
            this.panel1.Controls.Add(this.lblminimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 60);
            this.panel1.TabIndex = 25;
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsignup.ForeColor = System.Drawing.Color.White;
            this.lblsignup.Location = new System.Drawing.Point(158, 20);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(84, 21);
            this.lblsignup.TabIndex = 2;
            this.lblsignup.Text = "SIGN UP";
            // 
            // lblminimize
            // 
            this.lblminimize.AutoSize = true;
            this.lblminimize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminimize.ForeColor = System.Drawing.Color.White;
            this.lblminimize.Location = new System.Drawing.Point(346, 4);
            this.lblminimize.Name = "lblminimize";
            this.lblminimize.Size = new System.Drawing.Size(21, 21);
            this.lblminimize.TabIndex = 1;
            this.lblminimize.Text = "_";
            this.lblminimize.Click += new System.EventHandler(this.lblminimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 60);
            this.panel2.TabIndex = 26;
            // 
            // lbsifre
            // 
            this.lbsifre.AutoSize = true;
            this.lbsifre.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsifre.Location = new System.Drawing.Point(83, 156);
            this.lbsifre.Name = "lbsifre";
            this.lbsifre.Size = new System.Drawing.Size(95, 17);
            this.lbsifre.TabIndex = 30;
            this.lbsifre.Text = "PASSWORD:";
            // 
            // lbkullanıcıadi
            // 
            this.lbkullanıcıadi.AutoSize = true;
            this.lbkullanıcıadi.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkullanıcıadi.Location = new System.Drawing.Point(83, 95);
            this.lbkullanıcıadi.Name = "lbkullanıcıadi";
            this.lbkullanıcıadi.Size = new System.Drawing.Size(93, 17);
            this.lbkullanıcıadi.TabIndex = 29;
            this.lbkullanıcıadi.Text = "USERNAME:";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtpassword.Location = new System.Drawing.Point(86, 176);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(216, 28);
            this.txtpassword.TabIndex = 28;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtusername.Location = new System.Drawing.Point(86, 115);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(216, 28);
            this.txtusername.TabIndex = 27;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtconfirm.Location = new System.Drawing.Point(86, 237);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Size = new System.Drawing.Size(216, 28);
            this.txtconfirm.TabIndex = 31;
            this.txtconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Newaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(390, 505);
            this.Controls.Add(this.lblhata);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.btnnewaccount);
            this.Controls.Add(this.lbsifre);
            this.Controls.Add(this.lbkullanıcıadi);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbmassage);
            this.Controls.Add(this.lbconfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Newaccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newaccount";
            this.Load += new System.EventHandler(this.Newaccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbconfirm;
        private System.Windows.Forms.Button btnnewaccount;
        private System.Windows.Forms.Label lblhata;
        private System.Windows.Forms.Label lbmassage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Label lbsifre;
        private System.Windows.Forms.Label lbkullanıcıadi;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtconfirm;
    }
}