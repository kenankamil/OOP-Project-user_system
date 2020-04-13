using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab
{
    class PhonebookRecords
    {
        private string Name;
        private string Surname;
        private string Email;
        private string Description;
        private string Phone_number;
        private string Address;
        private string LoadUser;
        private static List<PhonebookRecords> phoneBook = new List<PhonebookRecords>();

        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Phone_number1 { get => Phone_number; set => Phone_number = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string LoadUser1 { get => LoadUser; set => LoadUser = value; }
        public static List<PhonebookRecords> PhoneBook { get => phoneBook; set => phoneBook = value; }
    }
}
