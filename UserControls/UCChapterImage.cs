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
        public Chapter chapter;
        private List<Chapter> chapters = new List<Chapter>();
        public EventHandler<Story> loadStoryDetails;
        public EventHandler<Chapter> loadChapter;
        public EventHandler<int> SaveIndexStart;
        private int index = 0;
        private int indexStart = 0;
        private int userID;
        public UCChapterImage(Chapter chapter, int indexStart, int userID)
        {
            InitializeComponent();
            this.chapter = chapter;
            this.indexStart = indexStart;
            this.userID = userID;
        }
        public void saveIndexStart()
        {
            if (!PayServices.isProgress(userID,chapter.Story.StoryID)) {
                //PayServices.newIndexStart(userID, chapter.Story.StoryID, chapter.ChapterID, txtContent.VerticalScroll.Value);
            }
            else 
            {
                PayServices.saveIndexStart(userID, chapter.Story.StoryID, chapter.ChapterID, txtContent.SelectionStart);
            }
        }

        private void UCChapterImage_Load(object sender, EventArgs e)
        {
            if (chapter.Story.Category == "truyện chữ")
            {
                chapters = ChapterService.getChapters(chapter.Story.StoryID);
                txtContent.Text = chapter.Content;
                txtContent.SelectionStart = indexStart;
                txtContent.ScrollToCaret();
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
                flowImage.VerticalScroll.Value = indexStart;
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
                    lbChapterName.Text = ("Chương " + chapter.ChapterNumber + ": " + chapter.Title);
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
