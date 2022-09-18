using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page 
{

    public class Signup 
    {
        string _userName;
        string _email;
        

        public string passWord { get; set; }
        public string userName

        {
            get { return _userName; }

            set
            {
                if (value.Length > 4)
                {
                    _userName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show($"Lütfen kullanıcı adınızı 4 harften fazla yapınız.");
                    Application.Restart();
                }
            }
        }

        public string mail
        {
            get { return _email; }

            set
            {
                if (value.Contains("@gmail.com"))
                {
                    _email = value;
                }
                else
                {
                    MessageBox.Show("Lütfen uygun formatda bir mail giriniz.");
                    Application.Restart();   
                }
            }
        }
    }
}
