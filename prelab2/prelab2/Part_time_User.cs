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
using System.IO;

namespace ooplab
{
    public partial class Part_time_User : Form
    {
        private string check_reminder = @"Data\reminders.csv";
        public static DateTime Now { get; }
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
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            this.Close();
            logout.ShowDialog();
        }

        private void btnPartReminder_Click(object sender, EventArgs e)
        {
            Reminder reminder = new Reminder();
            this.Close();
            reminder.Show();
        }

        private void Part_time_User_Load(object sender, EventArgs e)
        {
            if (!File.Exists(check_reminder))
            {
                File.Create(check_reminder).Close();
            }
            if (Form1.remainder_notification == "check")
            {
                using (var reader = new StreamReader(check_reminder))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        TimeSpan enteredtime = TimeSpan.Parse(values[1]);
                        string combotext = DateTime.Now.ToString("hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                        TimeSpan nowtime = TimeSpan.Parse(combotext);
                        string ampm_chooser = DateTime.Now.ToString("tt", System.Globalization.CultureInfo.InvariantCulture);
                        DateTime oDate = Convert.ToDateTime(values[0]);

                        if (oDate.Date == DateTime.Now.Date)
                        {
                            if (enteredtime > nowtime)
                            {
                                if (ampm_chooser == "PM" && values[2] == "AM")
                                {
                                    ReminderBox popup = new ReminderBox();
                                    popup.ShowDialog();
                                }
                            }
                            else if (enteredtime < nowtime)
                            {
                                if (ampm_chooser == "AM" && values[2] == "PM")
                                {
                                }
                                else
                                {
                                    ReminderBox popup = new ReminderBox();
                                    popup.ShowDialog();
                                }
                            }
                        }
                        else if (oDate.Date < DateTime.Now.Date)
                        {
                            ReminderBox popup = new ReminderBox();
                            popup.ShowDialog();
                        }
                    }
                }
                Form1.remainder_notification = "checked";
                using (var reader = new StreamReader(check_reminder))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        RemindersRecords temp = new RemindersRecords();
                        temp.Date = values[0];
                        temp.Time = values[1];
                        temp.Meridiem = values[2];
                        temp.Summary = values[3];
                        temp.Description = values[4];
                        temp.Type = values[5];
                        temp.LoadUserReminder = values[6];
                        RemindersRecords.RemindersRecords_.Add(temp);
                    }
                }

                if (ReminderBox.read_notification == "read")
                {
                    var reminderCSV = new StringBuilder();
                    File.Delete(check_reminder);
                    File.Create(check_reminder).Close();
                    var newLine_ = "";
                    for (int k = 0; k < RemindersRecords.RemindersRecords_.Count; k++)
                    {
                        newLine_ = string.Format("{0};{1};{2};{3};{4};{5};{6}", RemindersRecords.RemindersRecords_[k].Date,
                        RemindersRecords.RemindersRecords_[k].Time, RemindersRecords.RemindersRecords_[k].Meridiem, RemindersRecords.RemindersRecords_[k].Summary,
                        RemindersRecords.RemindersRecords_[k].Description, RemindersRecords.RemindersRecords_[k].Type,
                        RemindersRecords.RemindersRecords_[k].LoadUserReminder);
                        reminderCSV.AppendLine(newLine_);
                        File.AppendAllText(@"Data\reminders.csv", reminderCSV.ToString());
                        reminderCSV.Clear();
                    }
                }
            }
        }
    }
}
