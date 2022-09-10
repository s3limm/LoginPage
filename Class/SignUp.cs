using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page
{
    internal class Signup
    {
        public Signup(string _username, string _passWord, string _mail)
        {
            userName = _username;
            passWord = _passWord;
            mail = _mail;
        }

        public string userName { get; set; }
        public string passWord { get; set; }
        public string mail { get; set; }
    }
}
