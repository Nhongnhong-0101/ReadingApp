using ReadingApp.Model;
using ReadingApp.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ReadingApp.UserControls
{
    public partial class UCLibrary : UserControl
    {
        public EventHandler loadUCAccount;
        private List<Story> searchStories = new List<Story>();
        private User user;
        private ReadingList selectedRL = new ReadingList();
        private List<Story> storiesRL = new List<Story>();
        private List<ReadingList> readingLists = new List<ReadingList>();
        private int selectedItem = 0;
        public UCLibrary(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UCLibrary_Load(object sender, EventArgs e)
        {
            picAvat.Image = Image.FromFile(@user.Avatar);

            readingLists.Clear();

            loadReadingLists();
            if (readingLists.Count > 0)
            {
                selectedRL = readingLists[0];
                loadSelectedRL(selectedRL);
            }
        }

        private void loadReadingLists()
        {
            readingLists = ReadingListServices.getRL(user.UserID);

            if (readingLists.Count > 0)
            {
                flowRLs.Controls.Clear();
                for (int i = 0; i < readingLists.Count; i++)
                {
                    UCReadingListItem ucListItem = new UCReadingListItem(readingLists[i]);                    
                    ucListItem.loadStories += loadStories;
                    ucListItem.loadRL += reloadReadingLists;
                    flowRLs.Controls.Add(ucListItem);
                }
            }
            else
            {
                btnAddStoryIntoRL.Enabled = false;
            }

        }

        private void reloadReadingLists(object? sender, EventArgs e)
        {
            loadReadingLists();
        }

        private void changeBG(string nameList)
        {
            foreach (UCReadingListItem control in flowRLs.Controls)
            {
                if (control.txtName.Text == nameList)
                {
                    control.panel1.BackColor = Color.FromArgb(128, 255, 128);
                    control.txtName.BackColor = Color.FromArgb(128, 255, 128);
                    break;
                }
            }
        }

        private void loadStories(object? sender, ReadingList e)
        {
            foreach(UCReadingListItem control in flowRLs.Controls)
            {
                control.panel1.BackColor = Color.FromArgb(226, 239, 226);
                control.txtName.BackColor = Color.FromArgb(226, 239, 226);
            }
            loadSelectedRL(e);
        }

        private void loadSelectedRL(ReadingList list)
        {
            changeBG(list.ListName);
            selectedRL = list;
            btnAddStoryIntoRL.Enabled = true;
            lbReadlingListName.Text = selectedRL.ListName;

            flowMain.Controls.Clear();
            storiesRL = StoriesServices.getStoriesRL(selectedRL.ListID);
            for (int i = 0; i < storiesRL.Count; i++)
            {
                int index = i;
                UCStoryItem ucStoryItem = new UCStoryItem(storiesRL[index]);
                ucStoryItem.picDelete.Visible = true; 
                ucStoryItem.deleteStoryOutRL += deleteStoryOutRL;
                flowMain.Controls.Add(ucStoryItem);
            }
        }

        private void deleteStoryOutRL(object? sender, int e)
        {
            if (ReadingListServices.deleteStoryOutRL(e, selectedRL.ListID))
            {
                loadReadingLists();
                loadSelectedRL(selectedRL);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadUCAccount?.Invoke(this, EventArgs.Empty);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<Story> allstories = StoriesServices.getAllStoriesOutRL(selectedRL.ListID);
                searchStories.Clear();
                string searchText = txtSearch.Text.ToLower();
                foreach (Story story in allstories)
                {
                    if (story.Title.ToLower().Contains(searchText) || story.Author.ToLower().Contains(searchText))
                    {
                        searchStories.Add(story);
                    }
                }

                flowMain.Controls.Clear();
                for (int i = 0; i < allstories.Count; i++)
                {
                    int index = i;
                    UCStoryItem ucStoryItem = new UCStoryItem(allstories[index]);
                    ucStoryItem.picAdd.Visible = true;
                    ucStoryItem.addStoryIntoRL += addStoryIntoRL;
                    flowMain.Controls.Add(ucStoryItem);
                }
            }
        }

        private void addStoryIntoRL(object? sender, int e)
        {
            if (ReadingListServices.addStoryIntoRL(e, selectedRL.ListID))
            {
                txtSearch.Text = "";
                pnSearch.Visible = false;
                loadReadingLists();
                loadSelectedRL(selectedRL);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pnNewList.Visible)
            {
                pnNewList.Visible = false;
            }
            else { pnNewList.Visible = true; }
        }

        private void btnAddStoryIntoRL_Click(object sender, EventArgs e)
        {
            if (!pnSearch.Visible) { pnSearch.Visible = true; }
            else { pnSearch.Visible = false; }
        }

        private void txtNewListName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNewListName.Text != "" && ReadingListServices.addNewReadlingList(user.UserID, txtNewListName.Text))
                {
                    loadReadingLists();
                    pnNewList.Visible = false;
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa tất cả truyện khỏi danh sách đọc không?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                if (ReadingListServices.deleteAll(selectedRL.ListID))
                {
                    loadReadingLists();
                    loadSelectedRL(selectedRL);
                }
            }
        }
    }
}
