using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page
{
    internal class Signup
    {

        public Signup(string _username, string _password, string _mail)
        {
            userName = _username;
            password = _password;
            mail = _mail;
        }

        public string userName { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
    }
}
