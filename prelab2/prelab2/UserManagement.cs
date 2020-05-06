using prelab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ooplab
{
    public partial class UserManagement : Form
    {
        int i;
        public UserManagement()
        {
            InitializeComponent();
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Userlist.Count; i++)
            {
                if (users.Userlist[i].Username != users.SelectedUser.Username)
                    cmbusername.Items.Add(users.Userlist[i].Username);
            }
            cmbNewType.Items.Add("Admin");
            cmbNewType.Items.Add("User");
            cmbNewType.Items.Add("Part-time User");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            users.SelectedUser.Username = this.cmbusername.SelectedItem.ToString();
            string temp = this.cmbusername.SelectedItem.ToString();
            {
                for (i = 0; i < users.Userlist.Count; i++)
                {
                    if (temp == users.Userlist[i].Username)
                    {
                        txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                            users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type+ Environment.NewLine + "E-mail: " + users.Userlist[i].E_mail;
                        users.SelectedUser.Type = users.Userlist[i].Type;
                        users.SelectedUser.E_mail = users.Userlist[i].E_mail;
                        break;
                    }
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (Form1.Loaduser.Type == "Admin")
            {
                var csv = new StringBuilder();
                File.Delete(@"Data\user.csv");
                string fileName = @"Data\user.csv";
                File.Create(fileName).Close();
                if (txtnewpassword.Text == txtconfirm.Text)
                {
                    users.Userlist[i].Password = Hash256.ComputeSha256Hash(txtnewpassword.Text);
                    for (int j = 0; j < users.Userlist.Count; j++)
                    {
                        {
                            var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",
                            users.Userlist[j].Username, users.Userlist[j].Password,
                            users.Userlist[j].Type, users.Userlist[j].Name, users.Userlist[j].Surname,
                            users.Userlist[j].Phone_number,
                            users.Userlist[j].Address, users.Userlist[j].E_mail, users.Userlist[j].Photo, users.Userlist[j].Minimum_salary);
                            csv.AppendLine(newLine);
                            txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                               users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type + Environment.NewLine + "E-mail: " + users.Userlist[i].E_mail;
                        }
                    }
                    File.AppendAllText(@"Data\user.csv", csv.ToString());
                    SmtpClient sc = new SmtpClient();

                    sc.Port = 587;
                    sc.Host = "smtp.gmail.com";
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential("smtpicinmail@gmail.com", Hash256.ComputeSha256Hash("a"));

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("smtpicinmail@gmail.com", "OOP Project");
                    mail.Subject = "Password Update";
                    mail.To.Add(users.SelectedUser.E_mail);
                    mail.IsBodyHtml = true;
                    mail.Body = ("<p>New password: ")+ txtnewpassword.Text +Environment.NewLine + ("<p><p>We suggests to perform the reset periodically for your safety!<p>") + Environment.NewLine;
                    sc.Send(mail);

                    lblmassage.Text = "Succeed and sent mail.";
                }
                else
                    lblmassage.Text = "Not Confirmed";
            }
            else
                lblmassage.Text = "You can't do this, you are not an Admin";
        }
        private void btnSaveType_Click(object sender, EventArgs e)
        {
            if (Form1.Loaduser.Type == "Admin")
            {
                var csv = new StringBuilder();
                File.Delete(@"Data\user.csv");
                string fileName = @"Data\user.csv";
                File.Create(fileName).Close();
                users.Userlist[i].Type = cmbNewType.SelectedItem.ToString();
                for (int j = 0; j < users.Userlist.Count; j++)
                {
                    {
                        var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}",
                        users.Userlist[j].Username, users.Userlist[j].Password,
                        users.Userlist[j].Type, users.Userlist[j].Name, users.Userlist[j].Surname,
                        users.Userlist[j].Phone_number,
                        users.Userlist[j].Address, users.Userlist[j].E_mail, users.Userlist[j].Photo, users.Userlist[j].Minimum_salary);
                        csv.AppendLine(newLine);
                        lblmessage.Text = "Success";
                        txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                               users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type + Environment.NewLine + "E-mail: " + users.Userlist[i].E_mail;
                    }
                }
                File.AppendAllText(@"Data\user.csv", csv.ToString());
                lblmessage.Text = "Succeed";
            }
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lblclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to exit ?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        private void btnPreviosPage_Click(object sender, EventArgs e)
        {
            if (Form1.Loaduser.Type == "Admin")
            {
                Admin goback = new Admin();
                this.Close();
                goback.Show();
            }
            else if (Form1.Loaduser.Type == "User")
            {
                UserForm goback = new UserForm();
                this.Close();
                goback.Show();
            }
            else
            {
                Part_time_User goback = new Part_time_User();
                this.Close();
                goback.Show();
            }
        }
        private void btnprofile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Close();
            profile.Show();
        }
    }
}
