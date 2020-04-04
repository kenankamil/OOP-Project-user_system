namespace prelab2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.LOGİN = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hashbtn = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.btnnewaccount = new System.Windows.Forms.Button();
            this.checkremember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(144, 36);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(100, 22);
            this.usernametxt.TabIndex = 0;
            this.usernametxt.Text = "username";
            this.usernametxt.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(144, 64);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(100, 22);
            this.passwordtxt.TabIndex = 1;
            this.passwordtxt.Text = "password";
            this.passwordtxt.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // LOGİN
            // 
            this.LOGİN.Location = new System.Drawing.Point(156, 92);
            this.LOGİN.Name = "LOGİN";
            this.LOGİN.Size = new System.Drawing.Size(75, 23);
            this.LOGİN.TabIndex = 2;
            this.LOGİN.Text = "LOGIN";
            this.LOGİN.UseVisualStyleBackColor = true;
            this.LOGİN.Click += new System.EventHandler(this.LOGİN_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(114, 182);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 17);
            this.lblSonuc.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hashbtn
            // 
            this.hashbtn.Location = new System.Drawing.Point(13, 178);
            this.hashbtn.Name = "hashbtn";
            this.hashbtn.Size = new System.Drawing.Size(75, 23);
            this.hashbtn.TabIndex = 4;
            this.hashbtn.Text = "HASH";
            this.hashbtn.UseVisualStyleBackColor = true;
            this.hashbtn.Click += new System.EventHandler(this.hashbtn_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(13, 207);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(180, 89);
            this.sifre.TabIndex = 5;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // btnnewaccount
            // 
            this.btnnewaccount.Location = new System.Drawing.Point(128, 121);
            this.btnnewaccount.Name = "btnnewaccount";
            this.btnnewaccount.Size = new System.Drawing.Size(129, 23);
            this.btnnewaccount.TabIndex = 6;
            this.btnnewaccount.Text = "NEW ACCOUNT";
            this.btnnewaccount.UseVisualStyleBackColor = true;
            this.btnnewaccount.Click += new System.EventHandler(this.btnewaccount_Click);
            // 
            // checkremember
            // 
            this.checkremember.AutoSize = true;
            this.checkremember.Location = new System.Drawing.Point(28, 92);
            this.checkremember.Name = "checkremember";
            this.checkremember.Size = new System.Drawing.Size(122, 21);
            this.checkremember.TabIndex = 7;
            this.checkremember.Text = "Remember Me";
            this.checkremember.UseVisualStyleBackColor = true;
            this.checkremember.CheckedChanged += new System.EventHandler(this.checkremember_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 363);
            this.Controls.Add(this.checkremember);
            this.Controls.Add(this.btnnewaccount);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.hashbtn);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.LOGİN);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "username";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button LOGİN;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button hashbtn;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button btnnewaccount;
        private System.Windows.Forms.CheckBox checkremember;
    }
}

