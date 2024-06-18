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
        public UCChapterImage(Chapter chapter, int userID)
        {
            InitializeComponent();
            this.chapter = chapter;
            this.userID = userID;
        }
        public void saveIndexStart()
        {
            int index = 0;
            if (chapter.Story.Category == "truyện tranh") { index = flowImage.AutoScrollPosition.Y; }
            else { index = txtContent.GetCharIndexFromPosition(new Point(0, 0)); }
            if (!PayServices.isProgress(userID, chapter.Story.StoryID))
            {
                PayServices.newIndexStart(userID, chapter.Story.StoryID, chapter.ChapterID, index);
            }
            else
            {
                PayServices.saveIndexStart(userID, chapter.Story.StoryID, chapter.ChapterID, index);
            }
        }


        private void UCChapterImage_Load(object sender, EventArgs e)
        {            
            if (chapter.Story.Category == "truyện chữ")
            {
                chapters = ChapterService.getChapters(chapter.Story.StoryID);
                txtContent.Text = chapter.Content;
                txtContent.Select(indexStart, 0);
                txtContent.ScrollToCaret();
                txtContent.Visible = true;
            }
            else
            {
                chapters = ChapterService.getImageChapters(chapter.Story.StoryID); foreach (ChapterImages chapterImages in chapter.Images)
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

            if (PayServices.isProgress(userID, chapter.Story.StoryID))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục ở vị trí đã đọc trước đây không?", "Thông báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    indexStart = PayServices.getIndex(userID, chapter.Story.StoryID);
                    int chapterID = PayServices.getChapterID(userID, chapter.Story.StoryID);
                    foreach(Chapter _chapter in chapters)
                    {
                        if (_chapter.ChapterID == chapterID) { chapter = _chapter; break; }
                    }

                    if (chapter.Story.Category == "truyện chữ")
                    {
                        txtContent.Clear();
                        txtContent.Text = chapter.Content;
                        txtContent.Select(indexStart, 0);
                        txtContent.ScrollToCaret();
                        txtContent.Visible = true;
                    }
                    else
                    {
                        flowImage.Controls.Clear();
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
                        flowImage.AutoScrollPosition = new Point(0, -indexStart);
                        flowImage.Visible = true;
                    }
                    lbStoryName.Text = chapter.Story.Title;
                }
            }            

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
