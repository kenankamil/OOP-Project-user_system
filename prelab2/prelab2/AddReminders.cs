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
    public partial class AddReminders : Form
    {
        string reminderType = "Meeting";
        
        
        public AddReminders()
        {
            InitializeComponent();
        }

        private void btnReminderSave_Click(object sender, EventArgs e)
        {
            string time = maskedTextBox1.Text + " " + cmbTimeAmPm.Text;
            var csv = new StringBuilder();
            var newLine = string.Format("{0};{1};{2};{3};{4};{5}",
               dateTimePicker1.Text, time,
               txtboxSummary.Text, txtboxDescription.Text,reminderType,prelab2.Form1.Loaduser.Username);
            csv.AppendLine(newLine);            
            File.AppendAllText(@"Data\reminders.csv", csv.ToString());
            lblReminderMessage.Text = "Success";
        }

        private void rdoMeeting_CheckedChanged(object sender, EventArgs e)
        {
            reminderType = "Meeting";
        }

        private void rdoTask_CheckedChanged(object sender, EventArgs e)
        {
            reminderType = "Task";
        }        
    }
}
