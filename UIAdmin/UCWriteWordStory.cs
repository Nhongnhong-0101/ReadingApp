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
        int maxLength = 1500;
        Timer updateTimer;
        bool isAdmin { get; set; }
        public Story story { get; set; }
        public Chapter chapter { get; set; }

        public ChapterService  chapterService { get; set; }

        public UCWriteWordStory()
        {

            InitializeComponent();
            InitializeTimer();
            chapterService = new ChapterService();
            chapter = new Chapter();

            isAdmin = true;
            btnNew.Visible = isAdmin;
            btnSave.Visible = isAdmin;

            if (isAdmin)
            {
                btnSave.Text = "Chỉnh sửa";
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
                if(btnSave.Text == "Chỉnh sửa")
                {
                    btnSave.Text = "Đăng tải";
                    tbTitle.Enabled = true;
                    rtbContent.Enabled = true;
                    btnNew.Visible = false;
                }
                else
                {
                    if (rtbContent.Text.Length > maxLength)
                    {
                        MessageBox.Show("Giới hạn của chương này là 1500 từ.", "Thông báo", MessageBoxButtons.OK);
                        rtbContent.SelectionStart = maxLength;
                    }
                    else
                    {
                        if (!String.IsNullOrWhiteSpace(tbTitle.Text)
                            && tbTitle.Text != "Tiêu đề của chương"
                            && rtbContent.Text.Length <= maxLength)
                        {
                            chapter.Title = tbTitle.Text.Trim();
                            chapter.ChapterNumber = ExtractNumberFromString(lbNumChapter.Text);
                            chapter.Content = rtbContent.Text.Trim();
                            chapter.CreatedAt = DateTime.Now;

                            if (chapterService.SaveNewWordChapter(story.StoryID, chapter))
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
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại các thông tin", "Thông báo", MessageBoxButtons.OK);

                        }
                    }
                }
                
            } catch (Exception ex)
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

    }
}
