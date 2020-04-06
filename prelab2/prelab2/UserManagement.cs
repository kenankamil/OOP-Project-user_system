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
            for(int i=0;i<users.Userlist.Count;i++)
            {
                cmbusername.Items.Add(users.Userlist[i].Username);
            }
            cmbNewType.Items.Add("Admin");
            cmbNewType.Items.Add("User");
            cmbNewType.Items.Add("Part-time User");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                }  
            }            
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            if (txtnewpassword.Text == txtconfirm.Text)
            {
                File.Delete(@"Data\user.csv");
                string fileName = @"Data\user.csv";
                File.Create(fileName).Close();
                    users.Userlist[i].Password =Hash256.ComputeSha256Hash(txtnewpassword.Text);
                    for (int j = 0; j < users.Userlist.Count; j++)
                    {
                        {
                        var newLine = string.Format("{0};{1};{2}", users.Userlist[j].Username,users.Userlist[j].Password, users.Userlist[j].Type, Environment.NewLine);
                            csv.AppendLine(newLine);
                            lblmassage.Text = "Success";
                        txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                           users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type;
                    }
                    }
                File.AppendAllText(@"Data\user.csv", csv.ToString());
            }
            else
                lblmassage.Text = "Not Confirm"; 
        }

        private void btnSaveType_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            File.Delete(@"Data\user.csv");
            string fileName = @"Data\user.csv";
            File.Create(fileName).Close();
            users.Userlist[i].Type = cmbNewType.SelectedItem.ToString();
            for (int j = 0; j < users.Userlist.Count; j++)
            {
                {
                    var newLine = string.Format("{0};{1};{2}", users.Userlist[j].Username, users.Userlist[j].Password, users.Userlist[j].Type, Environment.NewLine);
                    csv.AppendLine(newLine);
                    lblmassage.Text = "Success";
                    txtList.Text = "Username: " + users.Userlist[i].Username + Environment.NewLine + "Password: " +
                           users.Userlist[i].Password + Environment.NewLine + "Type: " + users.Userlist[i].Type;
                }
            }
            File.AppendAllText(@"Data\user.csv", csv.ToString());
        }

    }
}
