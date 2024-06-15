using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadingApp.Model;
using ReadingApp.Services;

namespace ReadingApp.UserControls
{
    public partial class UCHistory : UserControl
    {
        public EventHandler loadUCAccount;
        private User user;
        private List<Story> stories = new List<Story>();
        public EventHandler<Story> loadUCStoryDetails;
        private List<Story> searchStories = new List<Story>();
        public UCHistory(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            picAvat.Image = Image.FromFile(@user.Avatar);

            stories.Clear();
            stories = StoriesServices.getAllStories();
            loadFlowPanel(stories);
        }

        private void loadFlowPanel(List<Story> stories)
        {
            flowMain.Controls.Clear();
            for (int i = 0; i < stories.Count; i++)
            {
                UCStoryItem ucStoryItem = new UCStoryItem(stories[i]);
                ucStoryItem.loadUCStoryDetails += _loadUCStoryDetails;
                flowMain.Controls.Add(ucStoryItem);
            }
        }

        private void _loadUCStoryDetails(object? sender, Story e)
        {
            loadUCStoryDetails?.Invoke(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadUCAccount?.Invoke(this, EventArgs.Empty);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                searchStories.Clear();
                string searchText = txtSearch.Text.ToLower();
                foreach (Story story in stories)
                {
                    if (story.Title.ToLower().Contains(searchText) || story.Author.ToLower().Contains(searchText))
                    {
                        searchStories.Add(story);
                    }
                }
                loadFlowPanel(searchStories);
            }
        }
    }
}
