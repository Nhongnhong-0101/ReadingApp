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
    public partial class UCLibrary : UserControl
    {
        private bool isComic = false;
        private bool isStory = false;
        private bool isFull = false;
        private bool isUpdating = false;
        private bool isFree = false;
        private bool isFee = false;
        public UCLibrary()
        {
            InitializeComponent();
        }

        private void UCLibrary_Load(object sender, EventArgs e)
        {
            flowMain.Controls.Clear();
            for (int i = 0; i <= 12; i++)
            {
                UCStoryItem ucStoryItem = new UCStoryItem();
                flowMain.Controls.Add(ucStoryItem);
            }
        }
        private void filterSearch(ref bool filter, PictureBox pictureBox)
        {
            if (!filter)
            {
                pictureBox.Image = Properties.Resources._checked;
                filter = true;
            }
            else
            {
                pictureBox.Image = Properties.Resources.check;
                filter = false;
            }
        }

        private void pnComic_Click(object sender, EventArgs e)
        {
            filterSearch(ref isComic, picComic);
        }
        private void pnStory_Click(object sender, EventArgs e)
        {
            filterSearch(ref isStory, picStory);
        }

        private void pnFull_Click(object sender, EventArgs e)
        {
            filterSearch(ref isFull, picFull);
        }

        private void pnUpdating_Click(object sender, EventArgs e)
        {
            filterSearch(ref isUpdating, picUpdating);
        }

        private void pnFree_Click(object sender, EventArgs e)
        {
            filterSearch(ref isFree, picFree);
        }

        private void pnFee_Click(object sender, EventArgs e)
        {
            filterSearch(ref isFee, picFee);
        }
    }
}
