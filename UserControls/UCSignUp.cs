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
    public partial class UCSignUp : UserControl
    {
        private bool isMale = true;
        public EventHandler loadUCLogIn;
        public EventHandler<User> loadUCHome;
        public UCSignUp()
        {
            InitializeComponent();
            dateTimePicker.CalendarTitleBackColor = Color.Blue;
        }

        private void passwordChar(TextBox txt, PictureBox pic)
        {
            if (txt.PasswordChar == '*')
            {
                txt.PasswordChar = '\0';
                pic.Image = Properties.Resources.eye;
            }
            else
            {
                txt.PasswordChar = '*';
                pic.Image = Properties.Resources.eye_slash;
            }
        }

        private void picConfirmEye_Click(object sender, EventArgs e)
        {
            passwordChar(txtConfirmPassword, picConfirmEye);
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            passwordChar(txtPassword, picEye);
        }

        private void sexChange()
        {
            if (!isMale)
            {
                picMale.Image = Properties.Resources._checked;
                picFemale.Image = Properties.Resources.check;
                isMale = true;
            }
            else
            {
                picMale.Image = Properties.Resources.check;
                picFemale.Image = Properties.Resources._checked;
                isMale = false;
            }
        }

        private void picMale_Click(object sender, EventArgs e)
        {
            if (!isMale) { sexChange(); }
        }

        private void picFemale_Click(object sender, EventArgs e)
        {
            if (isMale) { sexChange(); }
        }

        private void lbCancle_Click(object sender, EventArgs e)
        {
            loadUCLogIn?.Invoke(this, EventArgs.Empty);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtFullName.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtEmail.Text == "")
            {
                lbInfor.Text = "Vui lòng nhập đầy đủ thông tin đăng ký!";
                lbInfor.Visible = true;
                return;
            }

            if (!txtEmail.Text.Contains('@'))
            {
                lbInfor.Text = "Vui lòng nhập đúng định dạng email!";
                lbInfor.Visible = true;
                return;
            }

            if (txtPassword.TextLength != 8 || txtConfirmPassword.TextLength != 8)
            {
                lbInfor.Text = "Vui lòng nhập mật khẩu có 8 ký tự!";
                lbInfor.Visible = true;
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lbInfor.Text = "Xác nhận mật khẩu thất bại!";
                lbInfor.Visible = true;
                return;
            }

            if (UserServices.emailExist(txtEmail.Text))
            {
                lbInfor.Text = "Email đã được đăng ký!";
                lbInfor.Visible = true;
                return;
            }

            if (UserServices.signUpSuccess(txtUsername.Text, txtFullName.Text, txtEmail.Text, DateTime.Parse(dateTimePicker.Text), isMale, txtPassword.Text))
            {
                lbInfor.Text = "Đăng ký thành công!";
                lbInfor.Visible = true;
                timer1.Start();
            }
            else
            {
                lbInfor.Text = "Đăng ký thất bại!";
                lbInfor.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadUCHome?.Invoke(this, UserServices.getUser(txtEmail.Text));
            timer1.Stop();
        }
    }
}
