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
                if(users.Userlist[i].Username!=users.SelectedUser.Username)
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
                //for(int i=0;i<users.Userlist.Count;i++)
                //{
                //     if (temp == users.Userlist[i].Username)
                //    {
                //        txtList.Text = users.Userlist[count].ToString();
                //        break;
                //    }
                //}
                for (i = 0; i < users.Userlist.Count; i++)
                {
                    if (temp == users.Userlist[i].Username)
                    {
                        txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                            users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type;
                        break;
                    }
                    users.SelectedUser.Type = users.Userlist[i].Type;
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
                            users.Userlist[j].Address, users.Userlist[j].E_mail, users.Userlist[j].Photo,users.Userlist[j].Minimum_salary);              
                            csv.AppendLine(newLine);
                            lblmassage.Text = "Success";
                            txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                               users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type;
                        }
                    }
                    File.AppendAllText(@"Data\user.csv", csv.ToString());
                    lblmassage.Text = "Accsess";
                }
                else
                    lblmassage.Text = "Not Confirm";
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
                        users.Userlist[j].Address, users.Userlist[j].E_mail, users.Userlist[j].Photo,users.Userlist[j].Minimum_salary);
                        csv.AppendLine(newLine);
                        lblmassage.Text = "Success";
                        txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                               users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type;
                    }
                }
                File.AppendAllText(@"Data\user.csv", csv.ToString());
                lblmassage.Text = "Accsess";
            }
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
