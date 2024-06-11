﻿using System;
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
        public UCStoryDetails()
        {
            InitializeComponent();
        }               

        private void UCStoryDetails_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                addLabelChapter("Chương " + (i + 1).ToString() + ":", flowChapter1);
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
            labelChapter.AutoSize = true;
            labelChapter.Padding = new Padding(0, 5, 0, 5);
            labelChapter.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            flowpanel.Controls.Add(labelChapter);
        }

        private void addStar()
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
            addStar();
        }

        private void picStar2_Click(object sender, EventArgs e)
        {
            star = 2;
            addStar();
        }

        private void picStar3_Click(object sender, EventArgs e)
        {
            star = 3;
            addStar();
        }

        private void picStar4_Click(object sender, EventArgs e)
        {
            star = 4;
            addStar();
        }

        private void picStar5_Click(object sender, EventArgs e)
        {
            star = 5;
            addStar();
        }
    }
}
