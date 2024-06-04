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
    public partial class UCPasswordChange : UserControl
    {
        public EventHandler loadUCAccount;
        public UCPasswordChange()
        {
            InitializeComponent();
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
            loadUCAccount.Invoke(this, new EventArgs());
        }

        private void lbCancle_Click(object sender, EventArgs e)
        {
            loadUCAccount?.Invoke(this, EventArgs.Empty);
        }
    }
}
