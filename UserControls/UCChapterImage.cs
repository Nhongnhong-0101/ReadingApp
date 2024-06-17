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
    public partial class UCChapterImage : UserControl
    {
        private Chapter chapter;
        private List<Chapter> chapters = new List<Chapter>();
        public EventHandler<Story> loadStoryDetails;
        public EventHandler<Chapter> loadChapter;
        private int index = 0;
        public UCChapterImage(Chapter chapter)
        {
            InitializeComponent();
            this.chapter = chapter;
        }

        private void UCChapterImage_Load(object sender, EventArgs e)
        {
            if (chapter.Story.Category == "truyện chữ")
            {
                chapters = ChapterService.getChapters(chapter.Story.StoryID);
                txtContent.Text = chapter.Content;
                txtContent.Visible = true;
            }
            else
            {
                chapters = ChapterService.getImageChapters(chapter.Story.StoryID);
                foreach (ChapterImages chapterImages in chapter.Images)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(chapterImages.ImageURL);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = flowImage.Width - 70;
                    pictureBox.Height = flowImage.Height * 2 - 100; 
                    pictureBox.Margin = new Padding(5); 

                    flowImage.Controls.Add(pictureBox);
                }
                flowImage.Visible = true;
            }
            lbStoryName.Text = chapter.Story.Title;

            cbSelectChapter.Items.Clear();
            for (int i = 0; i < chapters.Count; i++)
            {
                cbSelectChapter.Items.Add("Chương " + (i + 1).ToString());
                if (chapters[i].Title == chapter.Title)
                {
                    cbSelectChapter.SelectedIndex = i;
                    lbChapterName.Text = ("Chương " + (i + 1).ToString() + ": " + chapter.Title);
                    index = i;
                    btnNextChapter.Enabled = (chapters.Count == i + 1) ? false : true;
                    cbSelectChapter.SelectedIndexChanged += cbSelectChapter_SelectedIndexChanged;
                }
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            loadStoryDetails?.Invoke(sender, chapter.Story);
        }

        private void btnNextChapter_Click(object sender, EventArgs e)
        {
            loadChapter?.Invoke(sender, chapters[index + 1]);
        }

        private void cbSelectChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChapter?.Invoke(sender, chapters[cbSelectChapter.SelectedIndex]);
        }
    }
}
