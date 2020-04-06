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
            this.button1 = new System.Windows.Forms.Button();
            this.lstUserList = new System.Windows.Forms.ListBox();
            this.cmbusername = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.lblmassage = new System.Windows.Forms.Label();
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
            this.lbluserlist.Location = new System.Drawing.Point(26, 98);
            this.lbluserlist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluserlist.Name = "lbluserlist";
            this.lbluserlist.Size = new System.Drawing.Size(49, 17);
            this.lbluserlist.TabIndex = 1;
            this.lbluserlist.Text = "Users:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstUserList
            // 
            this.lstUserList.FormattingEnabled = true;
            this.lstUserList.ItemHeight = 16;
            this.lstUserList.Location = new System.Drawing.Point(655, 91);
            this.lstUserList.Margin = new System.Windows.Forms.Padding(4);
            this.lstUserList.Name = "lstUserList";
            this.lstUserList.Size = new System.Drawing.Size(308, 84);
            this.lstUserList.TabIndex = 3;
            // 
            // cmbusername
            // 
            this.cmbusername.FormattingEnabled = true;
            this.cmbusername.Location = new System.Drawing.Point(94, 95);
            this.cmbusername.Margin = new System.Windows.Forms.Padding(4);
            this.cmbusername.Name = "cmbusername";
            this.cmbusername.Size = new System.Drawing.Size(160, 24);
            this.cmbusername.TabIndex = 4;
            this.cmbusername.Text = "Choose";
            this.cmbusername.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(124, 380);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(115, 324);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(100, 22);
            this.txtnewpassword.TabIndex = 6;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(115, 352);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(100, 22);
            this.txtconfirm.TabIndex = 7;
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Location = new System.Drawing.Point(10, 327);
            this.lblnewpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(104, 17);
            this.lblnewpassword.TabIndex = 8;
            this.lblnewpassword.Text = "New Password:";
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Location = new System.Drawing.Point(10, 355);
            this.lblconfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(60, 17);
            this.lblconfirm.TabIndex = 9;
            this.lblconfirm.Text = "Confirm:";
            // 
            // lblmassage
            // 
            this.lblmassage.AutoSize = true;
            this.lblmassage.Location = new System.Drawing.Point(137, 417);
            this.lblmassage.Name = "lblmassage";
            this.lblmassage.Size = new System.Drawing.Size(0, 17);
            this.lblmassage.TabIndex = 10;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblmassage);
            this.Controls.Add(this.lblconfirm);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbusername);
            this.Controls.Add(this.lstUserList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbluserlist);
            this.Controls.Add(this.txtList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label lbluserlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstUserList;
        private System.Windows.Forms.ComboBox cmbusername;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.Label lblmassage;
    }
}