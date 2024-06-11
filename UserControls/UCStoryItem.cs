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
    public partial class UCStoryItem : UserControl
    {
        public EventHandler loadUCStoryDetails;
        public UCStoryItem()
        {
            InitializeComponent();
        }

        private void UCStoryItem_Click(object sender, EventArgs e)
        {
            loadUCStoryDetails?.Invoke(this, EventArgs.Empty);
        }
    }
}
