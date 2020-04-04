using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
namespace prelab2
{
    public partial class Form1 : Form
    {
        user user = null;
        Form2 form2;
        List<user> users = new List<user>();
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

                using (var reader = new StreamReader(@"Data\user.csv"))
                {               
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                    int size = users.Count();
                    user temp = new user();
                    temp.Username = values[0];
                    temp.Password = values[1];
                    users.Add(temp);
                  //  Console.WriteLine(temp.Username + " " + temp.Password);
                }
              
            }
             
        }
        
        
        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
        private void LOGİN_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text.ToString();
            string password =ComputeSha256Hash(passwordtxt.Text);

            foreach (user item in users)
            {
                if (item.Username ==username  && item.Password == password)                                                                  
                {
                    user = item;
                    lblSonuc.Text = "success";
                    lblSonuc.ForeColor = Color.Green;
                    form2 = new Form2(item);
                    timer1.Interval = 3000;
                    timer1.Start();             
                    
                }
            }
            if (user == null)
            {
                lblSonuc.Text = "Failure";
                lblSonuc.ForeColor = Color.Red;
            }
            if(checkremember.Checked)
            {               

            }                
                 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            form2.ShowDialog();

            this.Close();

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

        private void hashbtn_Click(object sender, EventArgs e)
        {
            sifre.Text = ComputeSha256Hash(passwordtxt.Text);                       
        }

        private void btnewaccount_Click(object sender, EventArgs e)
        {
            Newaccount Newaccount = new Newaccount();
            Newaccount.ShowDialog();      
            
        }

        private void checkremember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
