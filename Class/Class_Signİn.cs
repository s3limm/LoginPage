using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page
{
    public class Class_Signİn
    {

        public Class_Signİn(string _username, string _password)
        {
            userName = _username;
            password = _password;
           
        }

        public string userName { get; set; }
        public string password { get; set; }
    }
}
