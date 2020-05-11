using prelab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab
{
    public partial class Reminder : Form
    {
        string fileReminders = @"Data\reminders.csv";

        public Reminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            if (!File.Exists(fileReminders))
            {
                File.Create(fileReminders).Close();
            }

            //Save to List RemindersRecords_ from reminders.csv
            using (var reader = new StreamReader(fileReminders))
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
            dgwReminders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnReminderAdd_Click(object sender, EventArgs e)
        {
            AddReminders addReminders = new AddReminders();
            this.Close();
            addReminders.Show();
        }

        private void btnReminderList_Click(object sender, EventArgs e)
        {
            dgwReminders.ColumnCount = 6;
            dgwReminders.Columns[0].Name = "Date";
            dgwReminders.Columns[1].Name = "Time";
            dgwReminders.Columns[2].Name = "Meridiem";
            dgwReminders.Columns[3].Name = "Summary";
            dgwReminders.Columns[4].Name = "Description";
            dgwReminders.Columns[5].Name = "Type";
            dgwReminders.AllowUserToDeleteRows = true;
            dgwReminders.AllowUserToAddRows = false;

            dgwReminders.Rows.Clear();

            using (var reader = new StreamReader(fileReminders))
            {
                while (!reader.EndOfStream)
                {
                    string[] temp = { };
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[6] == prelab2.Form1.Loaduser.Username)
                    {
                        temp = new string[] { values[0], values[1], values[2], values[3], values[4], values[5] };
                        dgwReminders.Rows.Add(temp);
                    }
                }
            }
        }
        private void btnReminderUpdate_Click(object sender, EventArgs e)
        {
            int j = 0;
            //Save to RemindersRecords_ List from data grid view for update items
            for (int k = 0; k < RemindersRecords.RemindersRecords_.Count; k++)
            {
                if (Form1.Loaduser.Username == RemindersRecords.RemindersRecords_[k].LoadUserReminder)
                {
                    if (RemindersRecords.RemindersRecords_[k].Date == "")
                    {
                        MessageBox.Show("Nothing updated!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        RemindersRecords.RemindersRecords_[k].Date = dgwReminders.Rows[j].Cells[0].Value.ToString(); //Date
                        RemindersRecords.RemindersRecords_[k].Time = dgwReminders.Rows[j].Cells[1].Value.ToString(); //Time
                        RemindersRecords.RemindersRecords_[k].Meridiem = dgwReminders.Rows[j].Cells[2].Value.ToString(); //meridiem
                        RemindersRecords.RemindersRecords_[k].Summary = dgwReminders.Rows[j].Cells[3].Value.ToString(); //Summary
                        RemindersRecords.RemindersRecords_[k].Description = dgwReminders.Rows[j].Cells[4].Value.ToString(); //Description
                        RemindersRecords.RemindersRecords_[k].Type = dgwReminders.Rows[j].Cells[5].Value.ToString(); //Type
                        j++;
                    }

                }
            }
            //Rewrite to reminder.csv
            var reminderCSV = new StringBuilder();
            File.Delete(fileReminders);
            File.Create(fileReminders).Close();
            var newLine_ = "";
            for (int k = 0; k < RemindersRecords.RemindersRecords_.Count; k++)
            {
                newLine_ = "";
                newLine_ = string.Format("{0};{1};{2};{3};{4};{5};{6}", RemindersRecords.RemindersRecords_[k].Date,
                RemindersRecords.RemindersRecords_[k].Time, RemindersRecords.RemindersRecords_[k].Meridiem, RemindersRecords.RemindersRecords_[k].Summary,
                RemindersRecords.RemindersRecords_[k].Description, RemindersRecords.RemindersRecords_[k].Type,
                RemindersRecords.RemindersRecords_[k].LoadUserReminder);
                reminderCSV.AppendLine(newLine_);
                File.AppendAllText(@"Data\reminders.csv", reminderCSV.ToString());
                reminderCSV.Clear();
            }
        }
        private void btnReminderDelete_Click(object sender, EventArgs e)
        {
            // Delete the slected row
            Int32 selectedRowCount = 0;
            selectedRowCount = dgwReminders.Rows.GetRowCount(DataGridViewElementStates.Selected) - 1;
            for (int i = 0; i < RemindersRecords.RemindersRecords_.Count; i++)
            {
                if (dgwReminders.Rows.Count != 0 && selectedRowCount != -1)
                {
                    if (RemindersRecords.RemindersRecords_[i].Description == dgwReminders.Rows[selectedRowCount].Cells[4].Value.ToString())
                    {
                        RemindersRecords.RemindersRecords_.RemoveAt(i);
                    }
                }
                else
                {
                    MessageBox.Show("You must choose a record!", "ERROR",MessageBoxButtons.OK , MessageBoxIcon.Error);
                    break;
                }
            }
            //Rewrite to reminder.csv
            var reminderCSV = new StringBuilder();
            File.Delete(fileReminders);
            File.Create(fileReminders).Close();
            var newLine_ = "";
            for (int k = 0; k < RemindersRecords.RemindersRecords_.Count; k++)
            {
                newLine_ = "";
                newLine_ = string.Format("{0};{1};{2};{3};{4};{5};{6}", RemindersRecords.RemindersRecords_[k].Date,
                RemindersRecords.RemindersRecords_[k].Time, RemindersRecords.RemindersRecords_[k].Meridiem, RemindersRecords.RemindersRecords_[k].Summary,
                RemindersRecords.RemindersRecords_[k].Description, RemindersRecords.RemindersRecords_[k].Type,
                RemindersRecords.RemindersRecords_[k].LoadUserReminder);
                reminderCSV.AppendLine(newLine_);
                File.AppendAllText(@"Data\reminders.csv", reminderCSV.ToString());
                reminderCSV.Clear();
            }
        }
        private void btnPreviosPage_Click(object sender, EventArgs e)
        {
            if (Form1.Loaduser.Type == "Admin")
            {
                Admin goback = new Admin();
                this.Close();
                goback.Show();
            }
            else if (Form1.Loaduser.Type == "User")
            {
                UserForm goback = new UserForm();
                this.Close();
                goback.Show();
            }
            else
            {
                Part_time_User goback = new Part_time_User();
                this.Close();
                goback.Show();
            }
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
    }
}
