﻿using System;
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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void btnPhoneBook_Click(object sender, EventArgs e)
        {
            Phonebook phonebook = new Phonebook();
            this.Close();
            phonebook.Show();
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNotes_Click(object sender, EventArgs e)
        {
            Notes enternotes = new Notes();
            this.Close();
            enternotes.Show();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            this.Close();
            profile.Show();
        }
    }
}
