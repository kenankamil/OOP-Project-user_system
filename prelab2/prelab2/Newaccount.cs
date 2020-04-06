﻿using ooplab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void btnnewaccount_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();    
            var csv = new StringBuilder();
            if (txtpassword.Text == txtconfirm.Text)
            {
                var username = txtusername.Text;
                var password = ComputeSha256Hash(txtpassword.Text);
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
                            lblhata.Text = "Is already taken";
                            break;
                        }
                        type = "User";
                    }
                }
                if (flag == 99)
                {
                    var newLine = string.Format("{0};{1};{2}", username, password, type, Environment.NewLine);
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

   
    }
}