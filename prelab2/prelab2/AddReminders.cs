using System;
using prelab2;
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
        public static DateTime Now { get; }
        string reminderType = "Meeting";
        public AddReminders()
        {
            InitializeComponent();
        }
        private void btnReminderSave_Click(object sender, EventArgs e)
        {
            string time = maskedTextBox1.Text;
            string meridiem = cmbTimeAmPm.Text;
            var csv = new StringBuilder();
            var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6}",
               dateTimePicker1.Text, time, meridiem,
               txtboxSummary.Text, txtboxDescription.Text, reminderType, prelab2.Form1.Loaduser.Username);

            if (maskedTextBox1.MaskCompleted)
            {
                TimeSpan enteredtime = TimeSpan.Parse(maskedTextBox1.Text);
                TimeSpan midnight = new TimeSpan(12, 0, 0);
                string combotext = DateTime.Now.ToString("hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                TimeSpan nowtime = TimeSpan.Parse(combotext);
                string ampm_chooser=DateTime.Now.ToString("tt", System.Globalization.CultureInfo.InvariantCulture);

                
                DateTime oDate = Convert.ToDateTime(dateTimePicker1.Text);
                if (enteredtime > midnight)
                {
                    MessageBox.Show("This is 12 hours system!\nEnter below 12:00:00 and Choose AM/PM !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((oDate.Day > DateTime.Now.Day && oDate.Month == DateTime.Now.Month && oDate.Year == DateTime.Now.Year) | (oDate.Month > DateTime.Now.Month && oDate.Year == DateTime.Now.Year) | (oDate.Year > DateTime.Now.Year))
                    {
                        csv.AppendLine(newLine);
                        File.AppendAllText(@"Data\reminders.csv", csv.ToString());
                        lblReminderMessage.Text = "Success";

                    }
                    if (oDate.Date == DateTime.Now.Date)
                    {
                        if (enteredtime > nowtime)
                        {
                            if (ampm_chooser == "PM" && cmbTimeAmPm.Text == "AM")
                            {
                                MessageBox.Show("Check Reminder Date/Time!\nDid you find time machine !?\n\t:)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                csv.AppendLine(newLine);
                                File.AppendAllText(@"Data\reminders.csv", csv.ToString());
                                lblReminderMessage.Text = "Success";
                            }
                        }
                        else if (enteredtime < nowtime)
                        {
                            if (ampm_chooser == "AM" && cmbTimeAmPm.Text == "PM")
                            {
                                csv.AppendLine(newLine);
                                File.AppendAllText(@"Data\reminders.csv", csv.ToString());
                                lblReminderMessage.Text = "Success";
                            }
                            else
                                MessageBox.Show("Check Reminder Date/Time!\nDid you find time machine !?\n\t:)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (oDate.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Check Reminder Date/Time!\nDid you find time machine !?\n\t:)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Check Reminder Date/Time!?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void rdoMeeting_CheckedChanged(object sender, EventArgs e)
        {
            reminderType = "Meeting";
        }
        private void rdoTask_CheckedChanged(object sender, EventArgs e)
        {
            reminderType = "Task";
        }
        private void btnPreviosPage_Click(object sender, EventArgs e)
        {
            Reminder goback = new Reminder();
            this.Close();
            goback.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really want to exit ?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        private void lblminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
