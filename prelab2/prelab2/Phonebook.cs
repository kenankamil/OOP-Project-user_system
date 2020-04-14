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
        // Can change something in data grid view(UPDATE)
        private void Phonebook_Load(object sender, EventArgs e)
        {

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            int j = 0;
            //Save to Phonebook List from data grid view for update items
            for (int k = 0; k < PhonebookRecords.PhoneBook.Count; k++)
            {
                if (Form1.Loaduser.Username == PhonebookRecords.PhoneBook[k].LoadUser1)
                {
                    //if (dgwRecords.Rows[k].Cells[j].Value == null || dgwRecords.Rows[k].Cells[j].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgwRecords.Rows[k].Cells[j].Value.ToString()))
                    //{
                    //    Console.WriteLine("Fail");
                    //}
                    PhonebookRecords.PhoneBook[k].Name1 = dgwRecords.Rows[j].Cells[0].Value.ToString();
                    PhonebookRecords.PhoneBook[k].Surname1 = dgwRecords.Rows[j].Cells[1].Value.ToString();
                    PhonebookRecords.PhoneBook[k].Phone_number1 = dgwRecords.Rows[j].Cells[2].Value.ToString();
                    PhonebookRecords.PhoneBook[k].Address1 = dgwRecords.Rows[j].Cells[3].Value.ToString();
                    PhonebookRecords.PhoneBook[k].Description1 = dgwRecords.Rows[j].Cells[4].Value.ToString();
                    PhonebookRecords.PhoneBook[k].Email1 = dgwRecords.Rows[j].Cells[5].Value.ToString();
                    j++;
                }
            }
            //Rewrite to phonebook.csv
            var phonebookCsv = new StringBuilder();
            File.Delete(fileNamephonebook);
            File.Create(fileNamephonebook).Close();
            var newLine_ = "";
            for (int k = 0; k < PhonebookRecords.PhoneBook.Count; k++)
            {
                newLine_ = "";
                newLine_ = string.Format("{0};{1};{2};{3};{4};{5};{6}", PhonebookRecords.PhoneBook[k].Name1, PhonebookRecords.PhoneBook[k].Surname1,
                PhonebookRecords.PhoneBook[k].Phone_number1, PhonebookRecords.PhoneBook[k].Address1,
                PhonebookRecords.PhoneBook[k].Description1,
                PhonebookRecords.PhoneBook[k].Email1,
                PhonebookRecords.PhoneBook[k].LoadUser1);
                phonebookCsv.AppendLine(newLine_);
                File.AppendAllText(@"Data\phonebook.csv", phonebookCsv.ToString());
                phonebookCsv.Clear();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the slected row
            Int32 selectedRowCount = 0;
            selectedRowCount = dgwRecords.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1;
            for (int i = 0; i < PhonebookRecords.PhoneBook.Count; i++)
            {
                if (dgwRecords.Rows.Count != 0 && selectedRowCount != -1)
                {
                    if (PhonebookRecords.PhoneBook[i].Name1 == dgwRecords.Rows[selectedRowCount].Cells[0].Value.ToString())
                    {
                        PhonebookRecords.PhoneBook.RemoveAt(i);
                    }
                }
                else
                {
                    MessageBox.Show("You must choose a record!", "ERROR");
                    break;
                }
            }
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

        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreviosPage_Click(object sender, EventArgs e)
        {
            Admin goback = new Admin();
            this.Close();
            goback.Show();
        }
    }
}

