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
    public partial class Phonebook : Form
    {
        private string name;
        private string surname;
        private string address;
        private string description;
        private string e_mail;
        string fileNamephonebook = @"Data\phonebook.csv";
        public Phonebook()
        {
            InitializeComponent();
        }

        public string Name1 { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Address { get => address; set => address = value; }
        public string Description { get => description; set => description = value; }
        public string E_mail { get => e_mail; set => e_mail = value; }

        private void Phonebook_Load(object sender, EventArgs e)
        {
            // Can change something in data grid view(UPDATE)
            lblInfo.Text = "Don't forget to save after DELETE and UPTADE";
            if (!File.Exists(fileNamephonebook))
            {
                File.Create(fileNamephonebook).Close();
            }
            dgwRecords.ColumnCount = 6;
            dgwRecords.Columns[0].Name = "Name";
            dgwRecords.Columns[1].Name = "Surname";
            dgwRecords.Columns[2].Name = "Phone number";
            dgwRecords.Columns[3].Name = "Address";
            dgwRecords.Columns[4].Name = "Description";
            dgwRecords.Columns[5].Name = "E-mail";
            dgwRecords.AllowUserToDeleteRows = true;
            dgwRecords.AllowUserToAddRows = false;
            //Save to List Phonebook from phonebook.csv
            using (var reader = new StreamReader(@"Data\phonebook.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    PhonebookRecords temp = new PhonebookRecords();
                    temp.Name1 = values[0];
                    temp.Surname1 = values[1];
                    temp.Phone_number1 = values[2];
                    temp.Address1 = values[3];
                    temp.Description1 = values[4];
                    temp.Email1 = values[5];
                    temp.LoadUser1 = values[6];
                    PhonebookRecords.PhoneBook.Add(temp);
                }
            }
        }
        private void BtnCreateRecords_Click(object sender, EventArgs e)
        {
            CreateRecords createRecords = new CreateRecords();
            this.Close();
            createRecords.Show();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            dgwRecords.Rows.Clear();
            //List the Phonebook of own user
            using (var reader = new StreamReader(@"Data\phonebook.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] temp = { };
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[6] == Form1.Loaduser.Username)
                    {
                        temp = new string[] { values[0], values[1], values[2], values[3], values[4], values[5] };
                        dgwRecords.Rows.Add(temp);
                    }
                }
            }
        }
    }
}

