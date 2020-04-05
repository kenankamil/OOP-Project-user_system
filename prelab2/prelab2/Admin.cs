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
            lblName1.Text = user.Username;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement usermanagement = new UserManagement();
            this.Close();
            usermanagement.Show();         
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
         
        }
    }
}
