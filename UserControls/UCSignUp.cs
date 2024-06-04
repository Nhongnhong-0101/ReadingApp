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
        public EventHandler loadUCHome;
        public UCSignUp()
        {
            InitializeComponent();
            dateTimePicker1.CalendarTitleBackColor = Color.Blue;
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

        private void picCalendar_Click(object sender, EventArgs e)
        {

        }

        private void lbCancle_Click(object sender, EventArgs e)
        {
            loadUCLogIn?.Invoke(this, EventArgs.Empty);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            loadUCHome?.Invoke(this, EventArgs.Empty);
        }
    }
}
