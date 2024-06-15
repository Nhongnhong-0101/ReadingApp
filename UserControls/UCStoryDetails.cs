using ReadingApp.Model;
using ReadingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingApp.UserControls
{
    public partial class UCStoryDetails : UserControl
    {
        int star = 0;
        private Story story = new Story();
        private List<ReadingList> listRL = new List<ReadingList>();
        private int ListID = 0;
        private User user;
        private List<Rating> ratings = new List<Rating>();
        public UCStoryDetails(Story story, User user)
        {
            InitializeComponent();
            this.story = story;
            this.user = user;
        }

        private void UCStoryDetails_Load(object sender, EventArgs e)
        {
            lbName.Text = story.Title;
            lbAuthor.Text = story.Author;
            if (story.Price > 0) { lbIsFree.Visible = false; pnPrice.Visible = true; lbPrice.Text = story.Price.ToString(); }
            else { lbIsFree.Visible = true; pnPrice.Visible = false; }
            lbType.Text = story.Type;
            lbStatus.Text = story.Status;
            lbNumberChapter.Text = story.NumberChapters.ToString();
            lbLastUpdate.Text = story.LastUpdatedAt.ToString();
            lbCreatedAt.Text = story.CreatedAt.ToString();
            lbDescription.Text = story.Description;

            listRL = ReadingListServices.getRLNotContainStory(story.StoryID);
            if (listRL.Count == 0) { btnAddStoryIntoRL.Visible = false; }

            if (story.NumberChapters > 10)
                for (int i = 0; i < story.NumberChapters / 2; i++)
                {
                    addLabelChapter("Chương " + (i + 1).ToString() + ":", flowChapter1);
                }

            for (int i = story.NumberChapters / 2; i < story.NumberChapters; i++)
            {
                addLabelChapter("Chương " + (i + 1).ToString() + ":", flowChapter2);
            }

            reloadListCmt(user.UserID, story.StoryID);            
        }

        private void addLabelChapter(string chapterName, FlowLayoutPanel flowpanel)
        {
            Label labelChapter = new Label();
            labelChapter.Text = chapterName;
            labelChapter.AutoSize = false;
            labelChapter.Size = new Size(630, 45);
            labelChapter.Padding = new Padding(0, 5, 0, 5);
            labelChapter.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            flowpanel.Controls.Add(labelChapter);
        }

        private void addStarComment()
        {
            switch (star)
            {
                case 5:
                    {
                        picStar1.Image = Properties.Resources.star;
                        picStar2.Image = Properties.Resources.star;
                        picStar3.Image = Properties.Resources.star;
                        picStar4.Image = Properties.Resources.star;
                        picStar5.Image = Properties.Resources.star;
                        break;
                    }
                case 4:
                    {
                        picStar1.Image = Properties.Resources.star;
                        picStar2.Image = Properties.Resources.star;
                        picStar3.Image = Properties.Resources.star;
                        picStar4.Image = Properties.Resources.star;
                        picStar5.Image = Properties.Resources.star_gray;
                        break;
                    }
                case 3:
                    {
                        picStar1.Image = Properties.Resources.star;
                        picStar2.Image = Properties.Resources.star;
                        picStar3.Image = Properties.Resources.star;
                        picStar4.Image = Properties.Resources.star_gray;
                        picStar5.Image = Properties.Resources.star_gray;
                        break;
                    }
                case 2:
                    {
                        picStar1.Image = Properties.Resources.star;
                        picStar2.Image = Properties.Resources.star;
                        picStar3.Image = Properties.Resources.star_gray;
                        picStar4.Image = Properties.Resources.star_gray;
                        picStar5.Image = Properties.Resources.star_gray;
                        break;
                    }
                case 1:
                    {
                        picStar1.Image = Properties.Resources.star;
                        picStar2.Image = Properties.Resources.star_gray;
                        picStar3.Image = Properties.Resources.star_gray;
                        picStar4.Image = Properties.Resources.star_gray;
                        picStar5.Image = Properties.Resources.star_gray;
                        break;
                    }
                case 0:
                    {
                        picStar1.Image = Properties.Resources.star_gray;
                        picStar2.Image = Properties.Resources.star_gray;
                        picStar3.Image = Properties.Resources.star_gray;
                        picStar4.Image = Properties.Resources.star_gray;
                        picStar5.Image = Properties.Resources.star_gray;
                        break;
                    }
            }
        }

        private void picStar1_Click(object sender, EventArgs e)
        {
            star = 1;
            addStarComment();
        }

        private void picStar2_Click(object sender, EventArgs e)
        {
            star = 2;
            addStarComment();
        }

        private void picStar3_Click(object sender, EventArgs e)
        {
            star = 3;
            addStarComment();
        }

        private void picStar4_Click(object sender, EventArgs e)
        {
            star = 4;
            addStarComment();
        }

        private void picStar5_Click(object sender, EventArgs e)
        {
            star = 5;
            addStarComment();
        }

        private void btnAddStoryIntoRL_Click(object sender, EventArgs e)
        {
            if (cbReadingList.Visible)
            {
                if (ReadingListServices.addStoryIntoRL(story.StoryID, ListID))
                {
                    lbInfor.Visible = true;
                    timer1.Start();
                }
            }
            else
            {
                cbReadingList.Items.Clear();
                foreach (ReadingList s in listRL)
                {
                    cbReadingList.Items.Add(s.ListName);
                }

                cbReadingList.SelectedIndex = 0;
                cbReadingList.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
                cbReadingList.Visible = true;
            }
        }

        private void cbReadingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ReadingList s in listRL)
            {
                if (s.ListName == cbReadingList.Text) { ListID = s.ListID; break; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInfor.Visible = false;
            cbReadingList.Visible = false;
            timer1.Stop();
        }

        private void btnPostCmt_Click(object sender, EventArgs e)
        {
            if (star!=0)
            {
                lbInforCmt.Visible = false;
                if (CommentServices.addCmt(user.UserID, story.StoryID, star, txtNewComment.Text))
                {
                    reloadListCmt(user.UserID, story.StoryID);
                }
            }
            else { lbInforCmt.Visible = true; }
        }

        private void reloadListCmt(int userID, int storyID)
        {
            flowComment.Controls.Clear();
            ratings = CommentServices.getCmt(userID, storyID);
            for (int i = 0; i < ratings.Count; i++)
            {
                UCCommentItem ucCommentItem = new UCCommentItem(ratings[i]);
                flowComment.Controls.Add(ucCommentItem);
            }

            star = 0;
            addStarComment();
            txtNewComment.Clear();
            lbStar.Text = StoriesServices.getStarsStory(story.StoryID);
        }
    }
}
