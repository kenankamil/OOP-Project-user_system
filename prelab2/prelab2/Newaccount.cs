using ooplab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prelab2
{
    public partial class Newaccount : Form
    {
        User user = new User();  

        public Newaccount()
        {
            InitializeComponent();
        }
        private void btnnewaccount_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();    
            var csv = new StringBuilder();
            if (txtpassword.Text == txtconfirm.Text)
            {
                var username = txtusername.Text;
                var password = Hash256.ComputeSha256Hash(txtpassword.Text);
                var type = "Admin";
                int flag = 99;
                using (var reader = new StreamReader(@"Data\user.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        if (username == values[0])
                        {
                            flag = 0;
                            lblhata.Text = "Username is already taken";
                            break;
                        }
                        type = "User";
                    }
                }
                if (flag == 99)
                {
                    var newLine = string.Format("{0};{1};{2}", username,password, type,Environment.NewLine);
                    csv.AppendLine(newLine);
                    File.AppendAllText(@"Data\user.csv", csv.ToString());
                    lblhata.Text = "Success";
                    users.Userlist.Clear();
                    this.Close();
                    form1.Show();
                }
            }
            else
                lbmassage.Text = "Not Confirm!!";
        }

        private void Newaccount_Load(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
