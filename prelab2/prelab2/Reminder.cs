using prelab2;
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
                    temp.Summary = values[2];
                    temp.Description = values[3];
                    temp.Type = values[4];
                    temp.LoadUserReminder = values[5];
                    RemindersRecords.RemindersRecords_.Add(temp);
                }
            }
        }

        private void btnReminderAdd_Click(object sender, EventArgs e)
        {
            AddReminders addReminders = new AddReminders();
            this.Close();
            addReminders.Show();
        }

        private void btnReminderList_Click(object sender, EventArgs e)
        {
            dgwReminders.ColumnCount = 5;
            dgwReminders.Columns[0].Name = "Date";
            dgwReminders.Columns[1].Name = "Time";
            dgwReminders.Columns[2].Name = "Summary";
            dgwReminders.Columns[3].Name = "Description";
            dgwReminders.Columns[4].Name = "Type";           
            dgwReminders.AllowUserToDeleteRows = true;
            dgwReminders.AllowUserToAddRows = false;            

            dgwReminders.Rows.Clear();
            //List the Phonebook of own user
            using (var reader = new StreamReader(fileReminders))
            {
                while (!reader.EndOfStream)
                {
                    string[] temp = { };
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[5] == prelab2.Form1.Loaduser.Username )
                    {
                        temp = new string[] { values[0], values[1], values[2], values[3], values[4] };
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
                    RemindersRecords.RemindersRecords_[k].Date = dgwReminders.Rows[j].Cells[0].Value.ToString(); //Date
                    RemindersRecords.RemindersRecords_[k].Time = dgwReminders.Rows[j].Cells[1].Value.ToString(); //Time
                    RemindersRecords.RemindersRecords_[k].Summary = dgwReminders.Rows[j].Cells[2].Value.ToString(); //Summary
                    RemindersRecords.RemindersRecords_[k].Description = dgwReminders.Rows[j].Cells[3].Value.ToString(); //Description
                    RemindersRecords.RemindersRecords_[k].Type = dgwReminders.Rows[j].Cells[4].Value.ToString(); //Type
                    j++;
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
                newLine_ = string.Format("{0};{1};{2};{3};{4};{5}", RemindersRecords.RemindersRecords_[k].Date,
                RemindersRecords.RemindersRecords_[k].Time, RemindersRecords.RemindersRecords_[k].Summary,
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
                    if (RemindersRecords.RemindersRecords_[i].Description== dgwReminders.Rows[selectedRowCount].Cells[3].Value.ToString())
                    {
                        RemindersRecords.RemindersRecords_.RemoveAt(i);                       
                    }
                }
                else
                {
                    MessageBox.Show("You must choose a record!", "ERROR");
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
                newLine_ = string.Format("{0};{1};{2};{3};{4};{5}", RemindersRecords.RemindersRecords_[k].Date,
                RemindersRecords.RemindersRecords_[k].Time, RemindersRecords.RemindersRecords_[k].Summary,
                RemindersRecords.RemindersRecords_[k].Description, RemindersRecords.RemindersRecords_[k].Type,
                RemindersRecords.RemindersRecords_[k].LoadUserReminder);
                reminderCSV.AppendLine(newLine_);
                File.AppendAllText(@"Data\reminders.csv", reminderCSV.ToString());
                reminderCSV.Clear();
            }
        }        
    }
}
