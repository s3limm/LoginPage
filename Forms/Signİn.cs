using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page.Forms
{
    public partial class Signİn : Form
    {
        Signup classSignUp = new Signup();
        public Signİn()
        {
            InitializeComponent();
        }

        private void btnSignİn_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)     
        {
            string User = txtSignİn.Text;
            string password = txtPassword.Text;

            if((User == classSignUp.userName || User == classSignUp.mail) && password == classSignUp.passWord)
            {
                MessageBox.Show($"Hoşgeldiniz sevgili {classSignUp.userName}");
            }
            else 
            {
                MessageBox.Show("Hatalı giriş yaptınız lütfen bir daha deneyiniz");
                txtSignİn.Text = "";
                txtPassword.Text = "";
                txtSignİn.Focus();

            }
        }
    }
}
