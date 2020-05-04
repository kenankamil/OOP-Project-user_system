using prelab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplab
{
    class users
    {
        private static List<User> userlist = new List<User>();
        private static User selectedUser = new User();
        public static List<User> Userlist { get => userlist; set => userlist = value; }
        public static User SelectedUser { get => selectedUser; set => selectedUser = value; }
    }
}
