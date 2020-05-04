namespace ooplab
{
    partial class Profile
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.dgwProfile = new System.Windows.Forms.DataGridView();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnPreviosPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblminimize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMinimumSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Black;
            this.btnEditProfile.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(493, 328);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(136, 37);
            this.btnEditProfile.TabIndex = 32;
            this.btnEditProfile.Text = "Edit";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // dgwProfile
            // 
            this.dgwProfile.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProfile.Location = new System.Drawing.Point(12, 229);
            this.dgwProfile.Name = "dgwProfile";
            this.dgwProfile.RowHeadersWidth = 51;
            this.dgwProfile.RowTemplate.Height = 24;
            this.dgwProfile.Size = new System.Drawing.Size(611, 89);
            this.dgwProfile.TabIndex = 33;
            // 
            // pctPhoto
            // 
            this.pctPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctPhoto.Location = new System.Drawing.Point(12, 82);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(176, 130);
            this.pctPhoto.TabIndex = 34;
            this.pctPhoto.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.Black;
            this.btnAddPhoto.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPhoto.ForeColor = System.Drawing.Color.White;
            this.btnAddPhoto.Location = new System.Drawing.Point(212, 175);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(147, 37);
            this.btnAddPhoto.TabIndex = 35;
            this.btnAddPhoto.Text = "Browse Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(241, 367);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 36;
            // 
            // btnPreviosPage
            // 
            this.btnPreviosPage.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnPreviosPage.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreviosPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviosPage.Location = new System.Drawing.Point(12, 327);
            this.btnPreviosPage.Name = "btnPreviosPage";
            this.btnPreviosPage.Size = new System.Drawing.Size(75, 34);
            this.btnPreviosPage.TabIndex = 37;
            this.btnPreviosPage.Text = "<--";
            this.btnPreviosPage.UseVisualStyleBackColor = false;
            this.btnPreviosPage.Click += new System.EventHandler(this.btnPreviosPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 60);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblminimize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 60);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(607, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblminimize
            // 
            this.lblminimize.AutoSize = true;
            this.lblminimize.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblminimize.ForeColor = System.Drawing.Color.White;
            this.lblminimize.Location = new System.Drawing.Point(586, 0);
            this.lblminimize.Name = "lblminimize";
            this.lblminimize.Size = new System.Drawing.Size(21, 21);
            this.lblminimize.TabIndex = 4;
            this.lblminimize.Text = "_";
            this.lblminimize.Click += new System.EventHandler(this.lblminimize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(282, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "PROFILE";
            // 
            // btnMinimumSalary
            // 
            this.btnMinimumSalary.BackColor = System.Drawing.Color.Black;
            this.btnMinimumSalary.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimumSalary.ForeColor = System.Drawing.Color.White;
            this.btnMinimumSalary.Location = new System.Drawing.Point(212, 129);
            this.btnMinimumSalary.Name = "btnMinimumSalary";
            this.btnMinimumSalary.Size = new System.Drawing.Size(147, 40);
            this.btnMinimumSalary.TabIndex = 41;
            this.btnMinimumSalary.Text = "Calculate Salary";
            this.btnMinimumSalary.UseVisualStyleBackColor = false;
            this.btnMinimumSalary.Click += new System.EventHandler(this.btnMinimumSalary_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 483);
            this.Controls.Add(this.btnMinimumSalary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPreviosPage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.pctPhoto);
            this.Controls.Add(this.dgwProfile);
            this.Controls.Add(this.btnEditProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.DataGridView dgwProfile;
        private System.Windows.Forms.PictureBox pctPhoto;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnPreviosPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblminimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimumSalary;
    }
}