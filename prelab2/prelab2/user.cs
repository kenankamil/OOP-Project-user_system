using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prelab2
{
    public class User
    {
        private string username;
        private string password;
        private string type;
        private string name;
        private string surname;
        private string phone_number;
        private string address;
        private string e_mail;
        private string photo;
        private int experience;
        private string city;
        private string education;
        private string foreign_language;
        private string management_task;
        private string about_family;
        private double minimum_salary;

        public User(string username, string password, string type, string e_mail)
        {
            this.username = username;
            this.password = password;
            this.type = type;
            this.e_mail = e_mail;
        }
        public User() { }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Address { get => address; set => address = value; }
        public string E_mail { get => e_mail; set => e_mail = value; }
        public string Photo { get => photo; set => photo = value; }
        public int Experience { get => experience; set => experience = value; }
        public string City { get => city; set => city = value; }
        public string Education { get => education; set => education = value; }
        public string Foreign_language { get => foreign_language; set => foreign_language = value; }
        public string Management_task { get => management_task; set => management_task = value; }
        public string About_family { get => about_family; set => about_family = value; }
        public double Minimum_salary { get => minimum_salary; set => minimum_salary = value; }
    }
}
