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
using System.Data.SqlClient;
using System.Collections;
using ReadingApp.Services;

namespace ReadingApp.UIAdmin
{
    public partial class UCAddNewStory : UserControl
    {
        String selectedImagePath;
        int maxTitle = 150;
        int maxDes = 500;
        System.Windows.Forms.Timer updateTimer;

        Image ImageDF = ReadingApp.Properties.Resources.image;

        List<string> types = new List<string>
            {
                "Ngôn tình",
                "Bách hợp",
                "Đam mỹ",
                "Cung đấu",
                "Học đường",
                "Trinh thám",
                "Viễn tưởng",
                "Phiêu lưu",

            };

        public Story story { get; set; }

        StoryService storyService;

        //Sự kiện 
        public delegate void StorySavedEventHandler(object sender, Story story);
        public event StorySavedEventHandler StorySaved;

        public delegate void BackEventHandler(object sender);
        public event BackEventHandler BackClick;
        public UCAddNewStory()
        {
            InitializeComponent();
            InitializeTimer();

            storyService = new StoryService();

            this.tbTitle.ForeColor = Color.Gray;
            this.tbAuthor.ForeColor = Color.Gray;
            this.rdTC.Checked = true;
            this.pcImage.BackgroundImage = ImageDF;

            this.cmbType.DataSource = types;
            this.cmbType.SelectedIndex = -1;
        }

        private void InitializeTimer()
        {
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 3000; // 3 giay
            updateTimer.Tick += new EventHandler(UpdateCountWord);
            updateTimer.Start();
        }

        private void UpdateCountWord(object sender, EventArgs e)
        {
            int tille = tbTitle.TextLength;
            int des = tbDes.TextLength;
            lbCountDes.Text = des.ToString() + "/" + maxDes.ToString() + " từ";
            lbCountTitle.Text = tille.ToString() + "/" + maxTitle.ToString() + " từ";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //tao new story 
            try
            {
                story = new Story();
                if (!String.Equals(tbTitle.Text, "Truyện chưa có tiêu đề")
                    && !String.IsNullOrEmpty(tbDes.Text)
                    && !String.Equals(tbAuthor.Text, "Điền tên tác giả")
                    && (rdTC.Checked || rdTT.Checked)
                    && cmbType.SelectedIndex != -1
                    && tbTitle.Text.Length <= maxTitle
                    && tbDes.Text.Length <= maxDes)
                {
                    story.Title = tbTitle.Text;
                    story.Description = tbDes.Text;
                    story.Author = tbAuthor.Text;
                    story.Category = (rdTC.Checked) ? "truyện chữ" : "truyện tranh";
                    story.Type = cmbType.SelectedValue.ToString();


                    if (String.IsNullOrEmpty(tbPrice.Text))
                    {
                        story.Price = 0;
                    }
                    else
                    {
                        story.Price = int.Parse(tbPrice.Text);
                    }


                    if (String.IsNullOrEmpty(tbFreeChap.Text))
                    {
                        story.FreeChapters = 0;

                    }
                    else
                    {
                        story.FreeChapters = int.Parse(tbFreeChap.Text);
                    }

                    story.Status = "Đang cập nhập";

                    if (pcImage.BackgroundImage != null)
                    {
                        if (!ImagesAreEqual(pcImage.BackgroundImage, ImageDF))
                        {
                            story.Image = selectedImagePath;
                        }
                    }

                    DateTime created = DateTime.Now;
                    story.CreatedAt = created;

                    story.LastUpdatedAt = created;
                    story.StoryID = storyService.SaveNewStory(story);

                    if (story.StoryID != -1)
                    {
                        MessageBox.Show("Tạo mới truyện thành công", "Thông báo", MessageBoxButtons.OK);
                        OnStorySaved(story);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Vui lòng kiểm tra lại các thông tin" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }

        }
        protected virtual void OnStorySaved(Story e)
        {
            StorySaved?.Invoke(this, e);
        }

        protected virtual void BackToHome()
        {
            BackClick?.Invoke(this);
        }

        private void pcImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    pcImage.BackgroundImage = Image.FromFile(selectedImagePath);
                }
            }
        }

        private bool ImagesAreEqual(Image img1, Image img2)
        {
            if (img1 == null || img2 == null)
                return false;

            MemoryStream ms1 = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();

            img1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
            img2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);

            byte[] img1Bytes = ms1.ToArray();
            byte[] img2Bytes = ms2.ToArray();

            ms1.Dispose();
            ms2.Dispose();

            return StructuralComparisons.StructuralEqualityComparer.Equals(img1Bytes, img2Bytes);
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Truyên chưa có tiêu đề" && tbTitle.ForeColor == Color.Gray)
            {
                tbTitle.Text = "";
                tbTitle.ForeColor = Color.Black;
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                tbTitle.Text = "Truyên chưa có tiêu đề";
                tbTitle.ForeColor = Color.Gray;
            }
        }

        private void tbAuthor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAuthor.Text))
            {
                tbAuthor.Text = "Điền tên tác giả";
                tbAuthor.ForeColor = Color.Gray;
            }
        }

        private void tbAuthor_Enter(object sender, EventArgs e)
        {
            if (tbAuthor.Text == "Điền tên tác giả" && tbAuthor.ForeColor == Color.Gray)
            {
                tbAuthor.Text = "";
                tbAuthor.ForeColor = Color.Black;
            }
        }

        private void tbTitle_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Truyên chưa có tiêu đề" && tbTitle.ForeColor == Color.Gray)
            {
                tbTitle.Clear();
                tbTitle.ForeColor = Color.Black;
            }
        }

        private void pcBack_Click(object sender, EventArgs e)
        {
            BackClick?.Invoke(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
