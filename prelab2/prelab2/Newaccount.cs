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
        string base64photo;
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
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(txte_mail.Text);
                 if (!match.Success)
                {
                    flag = 0;
                    lblhata.Text = "E-mail is not correct";
                    if (txtphonenumber.Text.Length != 10)
                    {
                        flag = 0;
                        lblhata.Text = "Please enter 10 characters for Phone Number!";
                        if (username == "" || txtpassword.Text == "" || txtname.Text == "" || txtsurname.Text == "" || txtphonenumber.Text == "" || txtaddress.Text == "" || txte_mail.Text == "")
                        {
                            flag = 0;
                            lblhata.Text = "Please fill in the blanks";
                        }
                    }
                }
                if (flag == 99)
                {
                    var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9}", username, password, type, txtname.Text, txtsurname.Text,
                    String.Format("{0:(###) ### ## ##}", Convert.ToInt64(txtphonenumber.Text)),
                    txtaddress.Text, txte_mail.Text,base64photo,"0");          //default value of minimum salary is 0        
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
        private void Newaccount_Load(object sender, EventArgs e) => Form1.ActiveForm.Hide();
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void btnPreviosPage_Click(object sender, EventArgs e)
        {
            Form1 goback = new Form1();
            this.Close();
            goback.Show();
        }
        private void btnAddFromFile_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbPhoto.Image = new Bitmap(open.FileName);
                if (pbPhoto.Width < pbPhoto.Image.Width && pbPhoto.Height < pbPhoto.Image.Height)
                {
                    pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pbPhoto.SizeMode = PictureBoxSizeMode.Normal;
                }         
            }
            // image file path    
            string path = open.FileName;
            //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(path);
            //string base64 = System.Convert.ToBase64String(plainTextBytes);          
            //base64photo = base64;
            //I did not decide corrrect one or one of them is correct
            if (path != "")
            {  
                byte[] imageArray = System.IO.File.ReadAllBytes(path);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                base64photo = base64ImageRepresentation;
            }
        }
    }
}
