using ReadingApp.Model;
using ReadingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ReadingApp.UIAdmin
{
    public partial class UCWriteWordStory : UserControl
    {
        int maxLength = 3000;
        Timer updateTimer;

        public User user;
        public Story story { get; set; }
        public Chapter chapter { get; set; }

        public bool IsNew { get; set; }

        public delegate void BackToDetailStoryEventHandler(object sender, Story story);
        public event BackToDetailStoryEventHandler BackToDetailStrClick;
        public UCWriteWordStory(Story story, User user, bool IsNew)
        {
            this.story = story;
            this.user = user;
            this.IsNew = IsNew;

            InitializeComponent();
            InitializeTimer();

            chapter = new Chapter();

            if (user.FullName == "Admin")
            {
                btnNew.Visible = true;
                btnSave.Visible = true;

                btnSave.Text = "Chỉnh sửa";

                if (IsNew)
                {
                    btnSave.Text = "Đăng truyện";
                    btnNew.Visible = false;

                }
                else
                {
                    btnSave.Text = "Chỉnh sửa";
                    btnNew.Visible = true;
                }

            }
        }

        public UCWriteWordStory (Chapter chapter,Story story, User user, bool IsNew)
        {
            this.chapter = chapter;
            this.story = story; 
            this.user = user;
            this.IsNew = IsNew;

            InitializeComponent();
            InitializeTimer();

            tbStt.Text = chapter.ChapterNumber.ToString();
            tbTitle.Text = chapter.Title;
            rtbContent.Text = chapter.Content;

            if (user.FullName == "Admin")
            {
                btnNew.Visible = true;
                btnSave.Visible = true;

                btnSave.Text = "Chỉnh sửa";

                if (IsNew)
                {
                    btnSave.Text = "Đăng tải";
                    btnNew.Visible = false;

                }
                else
                {
                    btnSave.Text = "Chỉnh sửa";
                    btnNew.Visible = true;
                    tbTitle.Enabled = false;
                    rtbContent.Enabled = false;
                }

            }


        }
        private void InitializeTimer()
        {

            updateTimer = new Timer();
            updateTimer.Interval = 5000; // 10 giay
            updateTimer.Tick += new EventHandler(UpdateCountWord);
            updateTimer.Start();
        }
        private void UpdateCountWord(object sender, EventArgs e)
        {
            int word = rtbContent.TextLength;
            lbCountWord.Text = word.ToString() + "/" + maxLength.ToString() + " từ";
        }
        private void rtbContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "Chỉnh sửa")
                {
                    //lưu sua chuong
                    btnSave.Text = "Đăng tải";
                    tbTitle.Enabled = true;
                    rtbContent.Enabled = true;
                    btnNew.Visible = false;                  
                }
                else
                {
                    if (rtbContent.Text.Length > maxLength)
                    {
                        MessageBox.Show("Giới hạn của chương này là " + maxLength.ToString() + " từ.", "Thông báo", MessageBoxButtons.OK);
                        rtbContent.SelectionStart = maxLength;
                    }
                    else
                    {
                        if (!String.IsNullOrWhiteSpace(tbTitle.Text)
                            && tbTitle.Text != "Tiêu đề của chương"
                            && rtbContent.Text.Length <= maxLength
                            && Convert.ToInt32(tbStt.Text) > 0)
                        {
                            chapter.ChapterNumber = Convert.ToInt32(tbStt.Text);
                            chapter.Title = tbTitle.Text.Trim();
                            chapter.Content = rtbContent.Text.Trim();

                            if(chapter.ChapterID != 0)
                            {
                                if (ChapterService.UpdateWordChapter(chapter))
                                {
                                    MessageBox.Show("Đã chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK);

                                    tbTitle.Enabled = false;
                                    rtbContent.Enabled = false;
                                    btnSave.Text = "Chỉnh sửa";
                                    btnNew.Visible = true;

                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng kiểm tra lại các thông tin", "Thông báo", MessageBoxButtons.OK);

                                }
                            }
                            else
                            {
                                chapter.CreatedAt = DateTime.Now;

                                if (ChapterService.SaveNewWordChapter(story.StoryID, chapter))
                                {
                                    MessageBox.Show("Đã lưu chương thành công", "Thông báo", MessageBoxButtons.OK);

                                    tbTitle.Enabled = false;
                                    rtbContent.Enabled = false;
                                    btnSave.Text = "Chỉnh sửa";
                                    btnNew.Visible = true;

                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng kiểm tra lại các thông tin", "Thông báo", MessageBoxButtons.OK);

                                }
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại các thông tin", "Thông báo", MessageBoxButtons.OK);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin" + ex.Message, "Thông báo", MessageBoxButtons.OK);

            }
        }

        private void UCWriteWordStory_Load(object sender, EventArgs e)
        {

        }
        public static int ExtractNumberFromString(string input)
        {
            // Regular expression to match a sequence of digits
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(input);

            if (match.Success)
            {
                return int.Parse(match.Value);
            }
            else
            {
                throw new FormatException("No digits found in the input string.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackToDetailStrClick?.Invoke(this, story);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa chương này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK) { 
                //Xóa chương
                try
                {
                    if (ChapterService.DeleteWordChapter(chapter.ChapterID))
                    {
                        MessageBox.Show("Xóa chương thành công");

                        BackToDetailStrClick?.Invoke(this, story);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa chương không thành công.\nVui lòng thử lại sau.");

                }
            }
        }
    }
}
