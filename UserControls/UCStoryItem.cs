using Microsoft.VisualBasic.ApplicationServices;
using ReadingApp.Model;
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

namespace ReadingApp.UserControls
{
    public partial class UCStoryItem : UserControl
    {
        public EventHandler<Story> loadUCStoryDetails;
        private Story story = new Story();
        public EventHandler<int> deleteStoryOutRL;
        public EventHandler<int> addStoryIntoRL;
        public UCStoryItem(Story story)
        {
            InitializeComponent();
            this.story = story;
        }

        private void UCStoryItem_Click(object sender, EventArgs e)
        {
            loadUCStoryDetails?.Invoke(this, story);
        }

        private void UCStoryItem_Load(object sender, EventArgs e)
        {
            picImage.Image = Image.FromFile(@story.Image);
            if (story.Price > 0) { picIsFee.Visible = true; } else { picIsFee.Visible = false; }
            lbAuthor.Text = story.Author;
            lbName.Text = story.Title;
            if (story.Status == "Full") { lbIsFull.Visible = true; } else { lbIsFull.Visible = false; }
            lbStar.Text = story.Star.ToString();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            deleteStoryOutRL?.Invoke(this, story.StoryID);
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            addStoryIntoRL?.Invoke(this, story.StoryID);
        }
    }
}
