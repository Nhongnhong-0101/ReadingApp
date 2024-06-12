using ReadingApp.UIAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingApp
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            UCAddNewStory uC = new UCAddNewStory();

            this.Controls.Add(uC);  

        }
    }
}
