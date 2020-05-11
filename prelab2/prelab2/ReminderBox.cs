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
    public partial class ReminderBox : Form
    {
        private string check_reminder = @"Data\reminders.csv";
        public static string read_notification = "notread";
        public ReminderBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            read_notification = "read";
            Shake(this);
            this.Close();
        }
        public static void Shake(ReminderBox shaker)
        {
            var original = shaker.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 5;
            for (int i=0;i<70; i++)
            {
                shaker.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(15);
                shaker.Location = original;
            }
        }
        private void ReminderBox_Shown(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Form.Shown event.");
            Shake(this);
        }

        private void ReminderBox_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(check_reminder))
            {
                while (!reader.EndOfStream )
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
                                lblSummary.Text = values[3];
                            }
                        }
                        else if (enteredtime < nowtime)
                        {
                            if (ampm_chooser == "AM" && values[2] == "PM")
                            {
                            }
                            else
                            {
                                lblSummary.Text = values[3];
                            }
                        }
                    }
                    else if (oDate.Date < DateTime.Now.Date)
                    {
                        lblSummary.Text = values[3];
                    }

                }
            }
        }
    }
}
