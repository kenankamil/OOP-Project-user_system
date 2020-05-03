namespace ooplab
{
    partial class UserManagement
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
            this.txtList = new System.Windows.Forms.TextBox();
            this.lbluserlist = new System.Windows.Forms.Label();
            this.cmbusername = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.lblmassage = new System.Windows.Forms.Label();
            this.lblNewType = new System.Windows.Forms.Label();
            this.btnSaveType = new System.Windows.Forms.Button();
            this.cmbNewType = new System.Windows.Forms.ComboBox();
            this.lblminimize = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreviosPage = new System.Windows.Forms.Button();
            this.btnprofile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(13, 149);
            this.txtList.Margin = new System.Windows.Forms.Padding(4);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(609, 150);
            this.txtList.TabIndex = 0;
            // 
            // lbluserlist
            // 
            this.lbluserlist.AutoSize = true;
            this.lbluserlist.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluserlist.Location = new System.Drawing.Point(10, 98);
            this.lbluserlist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluserlist.Name = "lbluserlist";
            this.lbluserlist.Size = new System.Drawing.Size(51, 17);
            this.lbluserlist.TabIndex = 1;
            this.lbluserlist.Text = "Users:";
            // 
            // cmbusername
            // 
            this.cmbusername.FormattingEnabled = true;
            this.cmbusername.Location = new System.Drawing.Point(69, 98);
            this.cmbusername.Margin = new System.Windows.Forms.Padding(4);
            this.cmbusername.Name = "cmbusername";
            this.cmbusername.Size = new System.Drawing.Size(160, 24);
            this.cmbusername.TabIndex = 4;
            this.cmbusername.Text = "Choose";
            this.cmbusername.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Black;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(132, 380);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 34);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(132, 327);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(100, 22);
            this.txtnewpassword.TabIndex = 6;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(132, 352);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(100, 22);
            this.txtconfirm.TabIndex = 7;
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnewpassword.Location = new System.Drawing.Point(10, 327);
            this.lblnewpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(115, 17);
            this.lblnewpassword.TabIndex = 8;
            this.lblnewpassword.Text = "New Password:";
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblconfirm.Location = new System.Drawing.Point(10, 355);
            this.lblconfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(68, 17);
            this.lblconfirm.TabIndex = 9;
            this.lblconfirm.Text = "Confirm:";
            // 
            // lblmassage
            // 
            this.lblmassage.AutoSize = true;
            this.lblmassage.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmassage.ForeColor = System.Drawing.Color.Green;
            this.lblmassage.Location = new System.Drawing.Point(275, 437);
            this.lblmassage.Name = "lblmassage";
            this.lblmassage.Size = new System.Drawing.Size(0, 17);
            this.lblmassage.TabIndex = 10;
            // 
            // lblNewType
            // 
            this.lblNewType.AutoSize = true;
            this.lblNewType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewType.Location = new System.Drawing.Point(284, 327);
            this.lblNewType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewType.Name = "lblNewType";
            this.lblNewType.Size = new System.Drawing.Size(82, 17);
            this.lblNewType.TabIndex = 11;
            this.lblNewType.Text = "New Type:";
            // 
            // btnSaveType
            // 
            this.btnSaveType.BackColor = System.Drawing.Color.Black;
            this.btnSaveType.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveType.ForeColor = System.Drawing.Color.White;
            this.btnSaveType.Location = new System.Drawing.Point(400, 358);
            this.btnSaveType.Name = "btnSaveType";
            this.btnSaveType.Size = new System.Drawing.Size(75, 35);
            this.btnSaveType.TabIndex = 13;
            this.btnSaveType.Text = "Save";
            this.btnSaveType.UseVisualStyleBackColor = false;
            this.btnSaveType.Click += new System.EventHandler(this.btnSaveType_Click);
            // 
            // cmbNewType
            // 
            this.cmbNewType.FormattingEnabled = true;
            this.cmbNewType.Location = new System.Drawing.Point(400, 327);
            this.cmbNewType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNewType.Name = "cmbNewType";
            this.cmbNewType.Size = new System.Drawing.Size(160, 24);
            this.cmbNewType.TabIndex = 14;
            this.cmbNewType.Text = "Choose";
            // 
            // lblminimize
            // 
            this.lblminimize.AutoSize = true;
            this.lblminimize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminimize.ForeColor = System.Drawing.Color.White;
            this.lblminimize.Location = new System.Drawing.Point(588, 0);
            this.lblminimize.Name = "lblminimize";
            this.lblminimize.Size = new System.Drawing.Size(21, 21);
            this.lblminimize.TabIndex = 1;
            this.lblminimize.Text = "_";
            this.lblminimize.Click += new System.EventHandler(this.lblminimize_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(615, 0);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(22, 21);
            this.lblclose.TabIndex = 0;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblminimize);
            this.panel1.Controls.Add(this.lblclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 60);
            this.panel1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(226, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "USER MANAGEMENT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 60);
            this.panel2.TabIndex = 26;
            // 
            // btnPreviosPage
            // 
            this.btnPreviosPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnPreviosPage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviosPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviosPage.Location = new System.Drawing.Point(13, 437);
            this.btnPreviosPage.Name = "btnPreviosPage";
            this.btnPreviosPage.Size = new System.Drawing.Size(75, 34);
            this.btnPreviosPage.TabIndex = 27;
            this.btnPreviosPage.Text = "<--";
            this.btnPreviosPage.UseVisualStyleBackColor = false;
            this.btnPreviosPage.Click += new System.EventHandler(this.btnPreviosPage_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.Location = new System.Drawing.Point(260, 92);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(139, 35);
            this.btnprofile.TabIndex = 28;
            this.btnprofile.Text = "Profile";
            this.btnprofile.UseVisualStyleBackColor = true;
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 554);
            this.Controls.Add(this.btnprofile);
            this.Controls.Add(this.btnPreviosPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbNewType);
            this.Controls.Add(this.btnSaveType);
            this.Controls.Add(this.lblNewType);
            this.Controls.Add(this.lblmassage);
            this.Controls.Add(this.lblconfirm);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbusername);
            this.Controls.Add(this.lbluserlist);
            this.Controls.Add(this.txtList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label lbluserlist;
        private System.Windows.Forms.ComboBox cmbusername;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.Label lblmassage;
        private System.Windows.Forms.Label lblNewType;
        private System.Windows.Forms.Button btnSaveType;
        private System.Windows.Forms.ComboBox cmbNewType;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPreviosPage;
        private System.Windows.Forms.Button btnprofile;
    }
}