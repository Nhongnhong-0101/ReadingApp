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
    public partial class UCForgotPassword : UserControl
    {
        public EventHandler loadUCLogIn;
        public UCForgotPassword()
        {
            InitializeComponent();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            loadUCLogIn?.Invoke(this, EventArgs.Empty);
        }
    }
}
