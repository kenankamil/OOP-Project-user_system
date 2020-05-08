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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.checkremember = new System.Windows.Forms.CheckBox();
            this.btnnewaccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGİN = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblminimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(162, 280);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 18);
            this.lblSonuc.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkremember
            // 
            this.checkremember.AutoSize = true;
            this.checkremember.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkremember.Location = new System.Drawing.Point(84, 215);
            this.checkremember.Name = "checkremember";
            this.checkremember.Size = new System.Drawing.Size(127, 22);
            this.checkremember.TabIndex = 2;
            this.checkremember.Text = "Remember Me";
            this.checkremember.UseVisualStyleBackColor = true;
            // 
            // btnnewaccount
            // 
            this.btnnewaccount.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnnewaccount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnewaccount.ForeColor = System.Drawing.Color.White;
            this.btnnewaccount.Location = new System.Drawing.Point(192, 243);
            this.btnnewaccount.Name = "btnnewaccount";
            this.btnnewaccount.Size = new System.Drawing.Size(128, 43);
            this.btnnewaccount.TabIndex = 4;
            this.btnnewaccount.Text = "Sign Up";
            this.btnnewaccount.UseVisualStyleBackColor = false;
            this.btnnewaccount.Click += new System.EventHandler(this.btnnewaccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "PASSWORD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "USERNAME:";
            // 
            // LOGİN
            // 
            this.LOGİN.BackColor = System.Drawing.Color.Black;
            this.LOGİN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LOGİN.ForeColor = System.Drawing.Color.White;
            this.LOGİN.Location = new System.Drawing.Point(58, 243);
            this.LOGİN.Name = "LOGİN";
            this.LOGİN.Size = new System.Drawing.Size(128, 43);
            this.LOGİN.TabIndex = 3;
            this.LOGİN.Text = "Login";
            this.LOGİN.UseVisualStyleBackColor = false;
            this.LOGİN.Click += new System.EventHandler(this.LOGİN_Click_1);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtxt.Location = new System.Drawing.Point(84, 172);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(216, 28);
            this.passwordtxt.TabIndex = 1;
            this.passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernametxt
            // 
            this.usernametxt.BackColor = System.Drawing.Color.White;
            this.usernametxt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernametxt.Location = new System.Drawing.Point(84, 111);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(216, 28);
            this.usernametxt.TabIndex = 0;
            this.usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblminimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 60);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(161, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "LOGIN";
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
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 60);
            this.panel2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkremember);
            this.Controls.Add(this.btnnewaccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LOGİN);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.lblSonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "username";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.CheckBox checkremember;
        private System.Windows.Forms.Button btnnewaccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOGİN;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

