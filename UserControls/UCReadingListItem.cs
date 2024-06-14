using ReadingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ReadingApp.Model;

namespace ReadingApp.UserControls
{
    public partial class UCReadingListItem : UserControl
    {
        private ReadingList readingList;
        public EventHandler<ReadingList> loadStories;
        public EventHandler loadRL;
        public UCReadingListItem(ReadingList readingList)
        {
            InitializeComponent();
            this.readingList = readingList;
        }

        private void UCReadingListItem_Load(object sender, EventArgs e)
        {
            txtName.Text = readingList.ListName;
            lbCount.Text = ReadingListServices.count(readingList.ListID);
        }

        private void picMore_Click(object sender, EventArgs e)
        {
            pnMore.Visible = true;
            picMore.Visible = false;
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            pnMore.Visible = false;
            picTick.Visible = true;
        }

        private void picTick_Click(object sender, EventArgs e)
        {
            if (ReadingListServices.renameRL(readingList.ListID, txtName.Text))
            {
                picTick.Visible = false;
                picMore.Visible = true;
                txtName.Enabled = false;
                txtName.BorderStyle = BorderStyle.None;
            }
        }

        private void picCancle_Click(object sender, EventArgs e)
        {
            pnMore.Visible = false;
            picMore.Visible = true;
        }

        public void UCReadingListItem_Click(object sender, EventArgs e)
        {
            loadStories?.Invoke(this, readingList);
            //panel1.BackColor = Color.FromArgb(128, 255, 128); 
            //txtName.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa danh sách đọc không?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                if (ReadingListServices.deleteAll(readingList.ListID) && ReadingListServices.deleteRL(readingList.ListID))
                {
                    loadRL?.Invoke(sender, EventArgs.Empty);
                }
            }            
        }
    }
}
