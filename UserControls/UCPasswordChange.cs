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
using static System.Net.Mime.MediaTypeNames;
using ReadingApp.Model;

namespace ReadingApp.UserControls
{
    public partial class UCPasswordChange : UserControl
    {
        public EventHandler loadUCAccount;
        private User user = new User();
        public UCPasswordChange(User user)
        {
            InitializeComponent();
            this.user = user;
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
            passwordChar(txtOldPassword, picPasswordEye);
        }

        private void picNewPasswordEye_Click(object sender, EventArgs e)
        {
            passwordChar(txtNewPassword, picNewPasswordEye);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                lbInfor.Text = "Vui lòng nhập đầy đủ thông tin mật khẩu!";
                lbInfor.Visible = true;
                return;
            }

            if (txtOldPassword.TextLength != 8 || txtConfirmPassword.TextLength != 8 || txtNewPassword.TextLength != 8)
            {
                lbInfor.Text = "Vui lòng nhập mật khẩu có 8 ký tự!";
                lbInfor.Visible = true;
                return;
            }

            if (!UserServices.correctPassword(user.UserID, txtOldPassword.Text))
            {
                lbInfor.Text = "Mật khẩu hiện tại không đúng!";
                lbInfor.Visible = true;
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                lbInfor.Text = "Xác nhận mật khẩu thất bại!";
                lbInfor.Visible = true;
                return;
            }
            lbInfor.Visible = false;

            if (UserServices.updatePasword(user.UserID, txtConfirmPassword.Text))
            {
                lbInfor.Text = "Thay đổi mật khẩu thành công!";
                lbInfor.Visible = true;
                timer1.Start();
            }
            else
            {
                lbInfor.Text = "Thay đổi mật khẩu không thành công!";
                lbInfor.Visible = true;
            }
        }

        private void lbCancle_Click(object sender, EventArgs e)
        {
            loadUCAccount?.Invoke(this, EventArgs.Empty);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadUCAccount.Invoke(this, new EventArgs());
            timer1.Stop();
        }
    }
}
