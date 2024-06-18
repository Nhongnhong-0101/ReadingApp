using ReadingApp.Model;
using ReadingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        private List<Chapter> chapters = new List<Chapter>();
        public EventHandler<Chapter> loadChapter;
        private string code = "";
        private bool isPaid = true;
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
            lbType.Text = story.Type;
            lbStatus.Text = story.Status;
            lbNumberChapter.Text = story.NumberChapters.ToString();
            lbLastUpdate.Text = story.LastUpdatedAt.ToString();
            lbCreatedAt.Text = story.CreatedAt.ToString();
            lbDescription.Text = story.Description;
            picImage.Image = Image.FromFile(story.Image);

            if (story.Price > 0)
            {
                lbIsFree.Visible = false;
                pnPrice.Visible = true;
                lbPrice.Text = story.Price.ToString();
                btnPay.Visible = (PayServices.isPaid(user.UserID, story.StoryID) || user.FullName == "Admin") ? false : true;
                isPaid = PayServices.isPaid(user.UserID, story.StoryID);
            }
            else
            {
                lbIsFree.Visible = true;
                pnPrice.Visible = false;
            }

            listRL = ReadingListServices.getRLNotContainStory(story.StoryID);
            if (listRL.Count == 0) { btnAddStoryIntoRL.Visible = false; }

            if (story.Category == "truyện chữ") { chapters = ChapterService.getChapters(story.StoryID); }
            else { chapters = ChapterService.getImageChapters(story.StoryID); }

            reloadChapters();
            reloadListCmt(user.UserID, story.StoryID);
        }

        private void reloadChapters()
        {
            flowChapter1.Controls.Clear();
            flowChapter2.Controls.Clear();
            int i = 0;
            while (i < chapters.Count)
            {
                int index = i;
                int middle = chapters.Count % 2 == 0 ? chapters.Count / 2 : chapters.Count / 2 + 1;
                if (index < middle)
                {
                    Label labelChapter = addLabelChapter("Chương " + chapters[i].ChapterNumber + ": " + chapters[i].Title);
                    flowChapter1.Controls.Add(labelChapter);                    
                    if (user.FullName != "Admin" && !isPaid && index >= story.FreeChapters) { labelChapter.Click += labelChapterNonPaid_Click; }
                    else { labelChapter.Click += (sender, e) => labelChapter_Click(sender, chapters[index]); }
                }
                else
                {
                    Label labelChapter = addLabelChapter("Chương " + chapters[i].ChapterNumber + ": " + chapters[i].Title);
                    flowChapter2.Controls.Add(labelChapter);
                    if (user.FullName != "Admin" && !isPaid && index >= story.FreeChapters) { labelChapter.Click += labelChapterNonPaid_Click; }
                    else { labelChapter.Click += (sender, e) => labelChapter_Click(sender, chapters[index]); }                    
                }
                i++; 
            }
        }

        private void labelChapterNonPaid_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng mua truyện để tiếp tục đọc!", "Thông báo");
        }

        private Label addLabelChapter(string chapterName)
        {
            Label labelChapter = new Label();
            labelChapter.Text = chapterName;
            labelChapter.AutoSize = false;
            labelChapter.Size = new Size(630, 45);
            labelChapter.Padding = new Padding(0, 5, 0, 5);
            labelChapter.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            return labelChapter;
                
        }

        private void labelChapter_Click(object? sender, Chapter chapter)
        {
            StoriesServices.viewStory(story.StoryID);
            loadChapter?.Invoke(this, chapter);
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
            if (star != 0)
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
            if (user.FullName == "Admin")
            {
                pnNewComment.Visible = false;
                flowComment.Size = new Size(673, 638);
                flowComment.Location = new Point(1475, 810);
            }
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn mua truyện không?", "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new System.Net.Mail.MailAddress("21520003@gm.uit.edu.vn");
                    SmtpClient smtp = new SmtpClient();
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(mail.From.Address, "22.03.2018");
                    smtp.Host = "smtp.gmail.com";

                    mail.To.Add(new MailAddress(user.Email));
                    mail.IsBodyHtml = true;
                    mail.Subject = "MUA TRUYỆN THÀNH CÔNG READINGAPP";
                    string numbers = "0123456789";
                    Random random = new Random();
                    code = random.Next(100000, 1000000).ToString();
                    mail.Body = "Bạn đã thanh toán thành công cho việc mua truyện " +
                                story.Title + "\nMã đọc truyện là: " + code;
                    smtp.Send(mail);

                    MessageBox.Show("Mã code dùng để đọc truyện đã được gửi đến email của bạn. Vui lòng nhập mã để đọc tiếp!", "Thông báo");
                    txtCode.Visible = true;
                }
                catch (Exception ex) { }
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCode.Text == code )
                {
                    if (PayServices.pay(story.StoryID, user.UserID))
                    {
                        txtCode.Visible = false;
                        btnPay.Visible = false;
                        lbInfor2.Visible = true;
                        isPaid = true;
                        reloadChapters();
                    }
                }
            }
        }
    }
}
