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
    public partial class CreateRecords : Form
    {
        public CreateRecords()
        {
            InitializeComponent();
        }

        private void CreateRecords_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Phonebook phonebook = new Phonebook();
            var csv = new StringBuilder();
            var newLine = string.Format("{0};{1};{2};{3};{4};{5}", txtName.Text, txtSurname.Text,Form1.Loaduser.Phone_number,txtAddress.Text,
               txtDescription.Text,txtEmail.Text,Environment.NewLine);
            csv.AppendLine(newLine);
            File.AppendAllText(@"Data\phonebook.csv", csv.ToString());
            lblhata.Text = "Success";
            this.Close();
            phonebook.Show();
        }
    }

}
