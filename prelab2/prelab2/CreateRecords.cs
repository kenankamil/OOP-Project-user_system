using prelab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab
{
    public partial class CreateRecords : Form
    {
        public CreateRecords()
        {
            InitializeComponent();
        }
        private void CreateRecords_Load(object sender, EventArgs e)
        {
            PhonebookRecords.PhoneBook.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (txtName.Text == "")
            {
                lblhata.Text = "Please enter name!";
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumber.Text, "[^0-9]"))
                {
                    lblhata.Text = "Please enter only numbers for Phone Number!";
                    txtPhoneNumber.Text = txtPhoneNumber.Text.Remove(txtPhoneNumber.Text.Length - 1);
                }
                if (txtPhoneNumber.Text.Length != 10)
                {
                    lblhata.Text = "Please enter 10 characters!";
                }
                else
                {
                    if (match.Success)
                    {
                        Phonebook phonebook = new Phonebook();
                        var csv = new StringBuilder();
                        var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6}",
                            txtName.Text, txtSurname.Text, String.Format("{0:(###) ### ## ##}", Convert.ToInt64(txtPhoneNumber.Text)),
                            txtAddress.Text, txtDescription.Text, txtEmail.Text,
                            Form1.Loaduser.Username, Environment.NewLine);
                        csv.AppendLine(newLine);
                        File.AppendAllText(@"Data\phonebook.csv", csv.ToString());
                        lblhata.Text = "Success";
                        this.Close();
                        phonebook.Show();
                    }
                    else
                    {
                        lblhata.Text = "E-mail is not correct";
                    }
                }
            }
        }
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void btnPreviosPage_Click(object sender, EventArgs e)
        {
            Phonebook goback= new Phonebook();
            this.Close();
            goback.Show();
        }
    }
}
