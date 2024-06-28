using ReadingApp.Model;
using ReadingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingApp.UserControls
{
    public partial class UCLogIn : UserControl
    {
        public EventHandler<User> loadUCHome;
        public EventHandler loadUCForgotPassword;
        public EventHandler loadUCSignUp;
        public User user = new User();
        public UCLogIn()
        {
            InitializeComponent();
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                picEye.Image = Properties.Resources.eye;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                picEye.Image = Properties.Resources.eye_slash;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                lbEmptyEmailPass.Text = "Vui lòng nhập email và mật khẩu!";
                lbEmptyEmailPass.Visible = true;
                return;
            }

            if (txtPassword.TextLength != 8)
            {
                lbEmptyEmailPass.Text = "Vui lòng nhập mật khẩu có 8 ký tự!";
                lbEmptyEmailPass.Visible = true;
                return;
            }

            lbEmptyEmailPass.Visible = false;

            //if(txtEmail.Text =="Admin" && txtPassword.Text == "12345678")
            //{
            //    lbUnsuccess.Text = "Đăng nhập thành công!";
            //    lbUnsuccess.Visible = true;
            //    user.FullName = "Admin";

            //    loadUCHome?.Invoke(this, user);
            //}
            //else
            //{
                if (UserServices.loginSuccess(txtEmail.Text, txtPassword.Text))
                {
                    lbUnsuccess.Text = "Đăng nhập thành công!";
                    lbUnsuccess.Visible = true;
                    timer1.Start();
                }
                else
                {
                    lbUnsuccess.Text = "Đăng nhập không thành công!";
                    lbUnsuccess.Visible = true;
                }
            //}
            
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            loadUCForgotPassword?.Invoke(this, EventArgs.Empty);
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            loadUCSignUp?.Invoke(this, EventArgs.Empty);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            user = UserServices.getUser(txtEmail.Text, txtPassword.Text);
            loadUCHome?.Invoke(this, user);
            timer1.Stop();
        }
    }
}
