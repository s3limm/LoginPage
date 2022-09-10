using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Page
{
    internal class Signİn
    {
        public Signİn(string _username, string _passWord)
        {
            userName = _username;
            passWord = _passWord;
        }

        public string userName { get; set; }
        public string passWord { get; set; }

    }
}
