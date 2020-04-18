using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prelab2
{
    public partial class Form2 : Form
    {
        User user;
        public Form2(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user.Username;
        }
    }
}
