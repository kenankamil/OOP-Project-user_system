using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab
{
    public partial class Part_time_User : Form
    {
        public Part_time_User()
        {
            InitializeComponent();
        }
        private void btnPhonebook_Click(object sender, EventArgs e)
        {
            Phonebook phonebook = new Phonebook();
            this.Close();
            phonebook.Show();
        }
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            Notes enternotes = new Notes();
            this.Close();
            enternotes.Show();
        }

        private void Part_time_User_Load(object sender, EventArgs e)
        {

        }
    }
}
