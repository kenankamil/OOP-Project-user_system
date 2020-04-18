using prelab2;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            User user = new User();
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement usermanagement = new UserManagement();
            this.Close();
            usermanagement.Show();         
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPhoneBookEdit_Click(object sender, EventArgs e)
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
    }
}
