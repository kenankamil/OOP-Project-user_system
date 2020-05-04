using System;
using prelab2;
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
        private void btnPartProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Close();
            profile.Show();
        }
        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            this.Close();
            logout.ShowDialog();
        }
    }
}
