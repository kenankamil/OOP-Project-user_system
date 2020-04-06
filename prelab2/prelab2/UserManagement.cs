using prelab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab
{
    public partial class UserManagement : Form
    {
        int count2;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            for(int i=0;i<users.Userlist.Count;i++)
            {
                cmbusername.Items.Add(users.Userlist[i].Username);
            }
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = this.cmbusername.SelectedItem.ToString();
            using (var reader = new StreamReader(@"Data\user.csv"))
            {
                int count = 0;
                //for(int i=0;i<users.Userlist.Count;i++)
                //{
                //     if (temp == users.Userlist[i].Username)
                //    {
                //        txtList.Text = users.Userlist[count].ToString();
                //        break;
                //    }
                //}
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (temp == values[0])
                    {
                        txtList.Text = "Username: " + users.Userlist[count].Username + Environment.NewLine + "Password: " +
                            users.Userlist[count].Password + Environment.NewLine + "Type: " + users.Userlist[count].Type;
                        break;
                    }
                    count++;
                    count2 = count;
                }
            }            
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            Form1 form1 = new Form1();
            if (txtnewpassword.Text == txtconfirm.Text)
            {
                using (var reader = new StreamReader(@"Data\user.csv"))
                {
                    File.Delete(@"Data\user.csv");
                    users.Userlist[count2].Password = txtnewpassword.Text;
                    while (!reader.EndOfStream)
                    {
                        int i = 0;
                        var line = reader.ReadLine();
                        var newLine = string.Format("{0};{1};{2}",users.Userlist[i].Username, users.Userlist[i].Password, users.Userlist[i].Type, Environment.NewLine);
                        csv.AppendLine(newLine);
                        File.AppendAllText(@"Data\user.csv", csv.ToString());
                        lblmassage.Text = "Success";
                    }
                }
            }
            else
                lblmassage.Text = "Not Confirm"; 
        }

     
    }
}
