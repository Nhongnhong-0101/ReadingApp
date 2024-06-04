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
        public EventHandler loadUCHome;
        public EventHandler loadUCForgotPassword;
        public EventHandler loadUCSignUp;
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
            loadUCHome?.Invoke(this, EventArgs.Empty);
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            loadUCForgotPassword?.Invoke(this, EventArgs.Empty);
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            loadUCSignUp?.Invoke(this, EventArgs.Empty);
        }
    }
}
