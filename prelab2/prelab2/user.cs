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
    }
}
