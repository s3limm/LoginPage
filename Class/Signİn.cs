﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page
{
    internal class Signİn
    {

        public Signİn(string _username, string _password)
        {
            userName = _username;
            password = _password;
           
        }

        public string userName { get; set; }
        public string password { get; set; }
    }
}
