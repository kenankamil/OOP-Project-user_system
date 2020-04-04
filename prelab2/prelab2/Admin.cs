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
        UserManagement UserManagement;
        public Admin()
        {
            InitializeComponent();
            user user = new user();
            lblName1.Text = user.Username;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
         
        }
    }
}
