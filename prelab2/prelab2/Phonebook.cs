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
            string fileName = @"Data\phonebook.csv";
            // Check if file already exists. If yes, delete it.     
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
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
            using (var reader = new StreamReader(@"Data\phonebook.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    lsbPhoneBook.Items.Add(line + Environment.NewLine);
                }
            }
        }
    }
}
