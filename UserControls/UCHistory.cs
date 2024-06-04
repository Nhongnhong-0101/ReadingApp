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
    public partial class UCHistory : UserControl
    {
        public UCHistory()
        {
            InitializeComponent();
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            flowMain.Controls.Clear();
            for (int i = 0; i <= 12; i++)
            {
                UCStoryItem ucStoryItem = new UCStoryItem();
                flowMain.Controls.Add(ucStoryItem);
            }
        }
    }
}
