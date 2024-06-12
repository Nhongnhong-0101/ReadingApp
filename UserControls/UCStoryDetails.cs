using ReadingApp.Model;
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
        int star = 0;
        private Story story = new Story();
        public UCStoryDetails(Story story)
        {
            InitializeComponent();
            this.story = story;
        }               

        private void UCStoryDetails_Load(object sender, EventArgs e)
        {
            lbName.Text = story.Title;
            lbAuthor.Text = story.Author;
            lbStar.Text = story.Star.ToString();
            if (story.Price > 0) { lbIsFree.Visible = false; pnPrice.Visible = true; lbPrice.Text = story.Price.ToString(); } 
            else { lbIsFree.Visible = true; pnPrice.Visible = false; }
            lbType.Text = story.Type;
            lbStatus.Text = story.Status;
            lbNumberChapter.Text = story.NumberChapters.ToString();
            lbLastUpdate.Text = story.LastUpdatedAt.ToString();
            lbCreatedAt.Text = story.CreatedAt.ToString();
            lbDescription.Text = story.Description;

            if (story.NumberChapters > 10)
            for (int i = 0; i < story.NumberChapters/2; i++)
            {
                addLabelChapter("Chương " + (i + 1).ToString() + ":", flowChapter1);
            }

            for (int i = story.NumberChapters/2; i < story.NumberChapters; i++)
            {
                addLabelChapter("Chương " + (i + 1).ToString() + ":", flowChapter2);
            }

            flowComment.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                UCCommentItem ucCommentItem = new UCCommentItem(5, "text comment");
                flowComment.Controls.Add(ucCommentItem);
            }
        }

        private void addLabelChapter(string chapterName, FlowLayoutPanel flowpanel)
        {
            Label labelChapter = new Label();
            labelChapter.Text = chapterName;
            labelChapter.AutoSize = false;
            labelChapter.Size = new Size(630, 36);
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
    }
}
