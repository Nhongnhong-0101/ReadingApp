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
    public partial class UCHome : UserControl
    {
        private bool isComic = false;
        private bool isStory = false;
        private bool isFull = false;
        private bool isUpdating = false;
        private bool isFree = false;
        private bool isFee = false;
        public EventHandler loadUCAccount;
        public EventHandler loadUCStoryDetails;
        public UCHome()
        {
            InitializeComponent();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            flowMain.Controls.Clear();
            for (int i = 0; i <= 12; i++)
            {
                UCStoryItem ucStoryItem = new UCStoryItem();
                ucStoryItem.loadUCStoryDetails += _loadUCStoryDetails;
                flowMain.Controls.Add(ucStoryItem);
            }
        }

        private void _loadUCStoryDetails(object? sender, EventArgs e)
        {
            loadUCStoryDetails?.Invoke(this, e);
        }

        private void pnType_Click(object sender, EventArgs e)
        {
            if (panelType.Visible)
            {
                panelType.Visible = false;
            }
            else
            {
                panelType.Visible = true;
            }
        }

        private void hoverType(Label label)
        {
            label.ForeColor = Color.DarkGreen;
            label.Font = new Font(label.Font, FontStyle.Underline);
        }

        private void leaveType(Label label)
        {
            label.ForeColor = Color.Black;
            label.Font = new Font(label.Font, FontStyle.Regular);
        }

        private void lbBachHop_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbBachHop);
        }

        private void lbBachHop_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbBachHop);
        }

        private void lbNgonTinh_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbNgonTinh);
        }

        private void lbNgonTinh_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbNgonTinh);
        }

        private void lbCoTrang_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbCoTrang);
        }

        private void lbCoTrang_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbCoTrang);
        }

        private void lbCungDau_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbCungDau);
        }

        private void lbCungDau_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbCungDau);
        }

        private void lbTheLoai5_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbTheLoai5);
        }

        private void lbTheLoai5_MouseLeave(object sender, EventArgs e)
        {
            leaveType((lbTheLoai5));
        }

        private void lbTheLoai6_MouseHover(object sender, EventArgs e)
        {
            hoverType((lbTheLoai6));
        }

        private void lbTheLoai6_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbTheLoai6);
        }

        private void visiblePanelSearch(Label label)
        {
            hoverType(label);
            cbType.Text = label.Text;
            pnSearch.Visible = true;
            flowMain.Height = 1205;
            flowMain.Location = new System.Drawing.Point(0, 270);
            panelState.Location = new System.Drawing.Point(1790, 270);
            panelType.Visible = false;
        }

        private void lbNgonTinh_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbNgonTinh);
        }

        private void lbCoTrang_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbCoTrang);
        }

        private void lbCungDau_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbCungDau);
        }

        private void lbBachHop_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbBachHop);
        }

        private void lbTheLoai5_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbTheLoai5);
        }

        private void lbTheLoai6_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbTheLoai6);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadUCAccount?.Invoke(this, EventArgs.Empty);
        }
    }
}
