using System;
using System.Collections.Generic;
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
        public User(string username, string password, string type)
        {
            this.username = username;
            this.password = password;
            this.type = type;
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
    }
}
