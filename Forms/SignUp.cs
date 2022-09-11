using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class SignUp : Form
    {
        Signup
            signup = new Signup();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Lütfen bir şifre belirlyiniz.");

            }
            else if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(txtMail.Text))
            {
                MessageBox.Show("Lütfen mail adresinizi giriniz.");

            }
            else if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtMail.Text))
            {
                signup.userName = txtUserName.Text;
                signup.passWord = txtPassword.Text;
                signup.mail = txtMail.Text;

                MessageBox.Show($"Hoşgeldin sevgili {signup.userName}, \n Kayıdınız oluşturulmuştur isterseniz kullanıcı adı veya {signup.mail} adresiniz ile giriş yapabilirsiniz.");
            }
            else
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz.");
            }
        }


    }
}
