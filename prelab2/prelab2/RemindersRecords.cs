using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab
{
    class RemindersRecords
    {
        private string date;
        private string time;
        private string summary;
        private string description;
        private string type;
        private string loadUserReminder;
        private static List<RemindersRecords> remindersRecords = new List<RemindersRecords>();

        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Summary { get => summary; set => summary = value; }
        public string Description { get => description; set => description = value; }
        internal static List<RemindersRecords> RemindersRecords_ { get => remindersRecords; set => remindersRecords = value; }
        public string Type { get => type; set => type = value; }
        public string LoadUserReminder { get => loadUserReminder; set => loadUserReminder = value; }
        
    }
}
