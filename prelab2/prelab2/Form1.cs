﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ooplab.Properties;
using System.Security.Cryptography;
using System.IO;
using ooplab;

namespace prelab2
{
    public partial class Form1 : Form
    {
        User user = null;
        private static User loaduser = new User();
        int login_flag = 0;
        public static string remainder_notification = "check";

        int Move;
        int Mouse_X;
        int Mouse_Y;

        public static User Loaduser { get => loaduser; set => loaduser = value; }
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            string root = @"Data";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string fileName = @"Data\user.csv";
            // Check if file already exists. If yes, delete it.     
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
            using (var reader = new StreamReader(@"Data\user.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    User temp = new User();
                    temp.Username = values[0];
                    temp.Password = values[1];
                    temp.Type = values[2];
                    temp.Name = values[3];
                    temp.Surname = values[4];
                    temp.Phone_number = values[5];
                    temp.Address = values[6];
                    temp.E_mail = values[7];
                    temp.Photo = values[8];
                    temp.Minimum_salary = Convert.ToDouble(values[9]);
                    users.Userlist.Add(temp);
                }
            }
            if (ooplab.Properties.Settings.Default.Username != string.Empty)
            {
                if (ooplab.Properties.Settings.Default.RememberMe == "yes")
                {
                    usernametxt.Text = ooplab.Properties.Settings.Default.Username;
                    passwordtxt.Text = ooplab.Properties.Settings.Default.Password;
                    checkremember.Checked = true;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            /* timer1.Stop();
             form2.ShowDialog();

             this.Close();
             */
        }
        private void LOGİN_Click_1(object sender, EventArgs e)
        {
            string username = usernametxt.Text.ToString();
            string password = Hash256.ComputeSha256Hash(passwordtxt.Text);

            foreach (User item in users.Userlist)
            {
                if (item.Username == username && item.Password == password)
                {
                    user = item;
                    lblSonuc.Text = "Success";
                    lblSonuc.ForeColor = Color.Green;
                    // form2 = new Form2(item);
                    //  timer1.Interval = 3000;
                    //timer1.Start();     
                    Loaduser.Username = item.Username;
                    Loaduser.Type = item.Type;
                    users.SelectedUser.Username = item.Username;
                    users.SelectedUser.Type = item.Type;
                    if (login_flag == 0)
                    {
                        if (item.Type == "Admin")
                        {
                            Admin admin = new Admin();
                            this.Hide();
                            admin.Show();
                            login_flag = 99;
                        }
                        if (item.Type == "User")
                        {
                            UserForm userform = new UserForm();
                            this.Hide();
                            userform.Show();
                            login_flag = 99;
                        }
                        if (item.Type == "Part-time User")
                        {
                            Part_time_User parttimeuserform = new Part_time_User();
                            this.Hide();
                            parttimeuserform.Show();
                            login_flag = 99;
                        }
                    }
                }
            }
            if (user == null)
            {
                lblSonuc.Text = "Failure";
                lblSonuc.ForeColor = Color.Red;
            }
            if (checkremember.Checked)
            {
                ooplab.Properties.Settings.Default.Username = usernametxt.Text;
                ooplab.Properties.Settings.Default.Password = passwordtxt.Text;
                ooplab.Properties.Settings.Default.RememberMe = "yes";
                ooplab.Properties.Settings.Default.Save();
            }
            else
            {
                ooplab.Properties.Settings.Default.Username = "";
                ooplab.Properties.Settings.Default.Password = "";
                ooplab.Properties.Settings.Default.RememberMe = "";
                ooplab.Properties.Settings.Default.Save();
            }
        }
        private void btnnewaccount_Click(object sender, EventArgs e)
        {
            Newaccount newaccount = new Newaccount();
            newaccount.ShowDialog();
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to exit ?", "Exit!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Move==1)
            { this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y); }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
    }
}