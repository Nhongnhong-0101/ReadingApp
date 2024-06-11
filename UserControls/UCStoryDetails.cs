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
    public partial class UCStoryDetails : UserControl
    {

        public UCStoryDetails()
        {
            InitializeComponent();
        }

        private void UCStoryDetails_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Label labelChapter = new Label();
                labelChapter.Text = "Chương " + (i+1).ToString() +":" ;
                labelChapter.AutoSize = true;
                labelChapter.Padding = new Padding(0,5,0,5);
                labelChapter.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                flowChapter.Controls.Add(labelChapter);
            }
        }
    }
}
