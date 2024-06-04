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

namespace ReadingApp.UserControls
{
    public partial class UCAccount : UserControl
    {
        private bool isMale = true;
        public EventHandler loadUCPasswordChange;
        public UCAccount()
        {
            InitializeComponent();
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            loadUCPasswordChange?.Invoke(this, EventArgs.Empty);
        }
    }
}
