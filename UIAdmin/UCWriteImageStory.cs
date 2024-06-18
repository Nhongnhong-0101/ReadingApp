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
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace ReadingApp.UIAdmin
{
    public partial class UCWriteImageStory : UserControl
    {
        int maxImage = 40;

        private Dictionary<int, string> imagePaths = new Dictionary<int, string>();

        private ContextMenuStrip contextMenu;

        public Story story;
        public User user;

        public Chapter chapter;

        public bool IsNew;

        public delegate void BackEventHandler(object sender, Story story);
        public event BackEventHandler BackClick;
        public UCWriteImageStory(Story story, User user, bool IsNew)

        {
            this.story = story;
            this.user = user;
            this.IsNew = IsNew;

            chapter = new Chapter();

            InitializeComponent();
            InitializeContextMenu();

            if (user.FullName == "Admin")
            {
                btnNew.Visible = true;
                btnSave.Visible = true;
                tbStt.Enabled = true;


                if (IsNew)
                {
                    btnSave.Text = "Đăng truyện";
                    btnNew.Visible = false;

                }
                else
                {
                    btnSave.Text = "Chỉnh sửa";
                    btnNew.Visible = false;

                }
            }
        }
        public UCWriteImageStory(Chapter chapter, Story story, User user, bool IsNew)

        {
            this.chapter = chapter; 
            this.story = story;
            this.user = user;
            this.IsNew = IsNew;


            InitializeComponent();
            InitializeContextMenu();

            if (user.FullName == "Admin")
            {
                btnSave.Visible =  true;

                if (IsNew)
                {                    
                    btnSave.Text = "Đăng truyện";
                    btnNew.Visible = false;
                    btnAddImage.Visible = false;
                    tbStt.Enabled = true;
                    tbTitle.Enabled = true;

                }
                else
                {
                    btnSave.Text = "Chỉnh sửa";
                    btnNew.Visible = false;
                    btnAddImage.Visible = false;
                    tbStt.Enabled = false;
                    tbTitle.Enabled = false;

                }
            }
            //truy xuat hinh cua chapter

            imagePaths = ChapterService.GetImagesOfChapter(chapter.ChapterID);
            tbStt.Text = chapter.ChapterNumber.ToString();
            tbTitle.Text = chapter.Title;

            LoadImages();


        }
        private void InitializeContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            var deleteItem = new ToolStripMenuItem("Xóa hình", null, DeleteImage);
            var changeItem = new ToolStripMenuItem("Thay đổi hình", null, ChangeImage);
            contextMenu.Items.AddRange(new ToolStripMenuItem[] { deleteItem, changeItem });
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string selectedImagePath in openFileDialog.FileNames)
                    {
                        int newSTT = imagePaths.Count + 1;
                        imagePaths[newSTT] = selectedImagePath;
                    }

                    LoadImages();
                }
            }

        }
        private void LoadImages()
        {
            // Xóa hết các PictureBox cũ trong Panel
            pnImages.Controls.Clear();

            Point locationImage = new Point(0, 0);

            foreach (var row in imagePaths)
            {
                int stt = row.Key;
                string imagePath = row.Value;

                System.Drawing.Image originalImage = System.Drawing.Image.FromFile(imagePath);


                PictureBox image = new PictureBox();
                image.Width = 800;
                image.Height = originalImage.Height;


                image.SizeMode = PictureBoxSizeMode.Zoom;
                image.Image = originalImage;
                image.Tag = stt;

                if (originalImage.Width > 800)
                {
                    int newWidth = 800;
                    int newHeight = (int)(originalImage.Height * (800.0 / originalImage.Width));

                    image.Height = newHeight;

                    Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                    // Set the PictureBox to the resized image
                    image.Image = resizedImage;
                }
                else
                {
                    // Set the PictureBox to the original image
                    image.Image = originalImage;

                }

                image.MouseClick += Image_MouseClick; // Gắn sự kiện MouseClick


                locationImage.X = pnImages.Width / 2 - image.Width / 2;
                image.Location = locationImage;

                pnImages.Controls.Add(image);

                locationImage.Y += image.Height + 40;

                Point locationStt = new Point();
                locationStt.Y = image.Location.Y + image.Height + 10;
                locationStt.X = image.Location.X + image.Width / 2;
                locationStt.X = 300;

                Label lbStt = new Label();
                lbStt.Text = stt.ToString();

                lbStt.Location = locationStt;

                pnImages.Controls.Add(lbStt);

            }

            lbCountWord.Text = imagePaths.Count.ToString() + "/" + maxImage.ToString() + " hình";
        }
        private void DeleteImage(object sender, EventArgs e)
        {
            if (contextMenu.Tag is PictureBox image)
            {
                int stt = (int)image.Tag;
                imagePaths.Remove(stt);
                //cập nhập lại stt 
                // nếu kv có value >= stt thì mới thay đổi
                var updatedImagePaths = new Dictionary<int, string>();

                foreach (var row in imagePaths)
                {
                    int key = row.Key;
                    string value = row.Value;
                    if (key > stt)
                    {
                        key = key - 1;
                    }
                    updatedImagePaths[key] = value;
                }

                imagePaths = updatedImagePaths;

                LoadImages();
            }
        }
        private void ChangeImage(object sender, EventArgs e)
        {
            if (contextMenu.Tag is PictureBox image)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string newImagePath = openFileDialog.FileName;
                        int stt = (int)image.Tag;
                        imagePaths[stt] = newImagePath;

                        // Cập nhật hình ảnh cho PictureBox
                        image.Image = System.Drawing.Image.FromFile(newImagePath);
                    }
                }
            }
        }

        private void Image_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox clickedImage = sender as PictureBox;
                contextMenu.Tag = clickedImage;
                contextMenu.Show(Cursor.Position);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Chỉnh sửa")
            {
                btnSave.Text = "Đăng tải";
                btnAddImage.Visible = true;
                btnNew.Visible = false;
                tbStt.Enabled = true;
                tbTitle.Enabled = true;

            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (SaveData())
                    {

                        btnSave.Text = "Chỉnh sửa";
                        btnAddImage.Visible = false;
                        btnNew.Visible = false;
                        tbStt.Enabled = false;
                        tbTitle.Enabled = false;
                    }
                }

            }
        }

        private bool SaveData()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbTitle.Text)
                    && tbTitle.Text != "Tiêu đề của chương"
                    && imagePaths.Count <= maxImage
                    && imagePaths.Count > 0
                    && Convert.ToInt32(tbStt.Text) >-1)
                {
                    chapter.Title = tbTitle.Text.Trim();
                    chapter.ChapterNumber = Convert.ToInt32(tbStt.Text);
                    
                    if(chapter.ChapterID > 0)
                    {
                        //sửa
                       
                        if (ChapterService.UpdateImageChapter(chapter, imagePaths))
                        {
                            MessageBox.Show("Bạn đã lưu chương mới thành công", "Thông báo");

                            btnSave.Text = "Chỉnh sửa";
                            btnAddImage.Visible = false;
                            tbTitle.Enabled = false;
                            btnNew.Visible = true;
                            tbStt.Enabled = false;

                            return true;

                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lõi. Hãy kiểm tra lại các thông tin", "Thông báo");
                            return false;
                        }
                    }   
                    else
                    {
                        //lưu mới
                        chapter.CreatedAt = DateTime.Now;

                        if (ChapterService.SaveNewImageChapter(story.StoryID, chapter, imagePaths))
                        {
                            MessageBox.Show("Bạn đã lưu chương mới thành công", "Thông báo");

                            btnSave.Text = "Chỉnh sửa";
                            btnAddImage.Visible = false;
                            tbTitle.Enabled = false;
                            btnNew.Visible = true;
                            tbStt.Enabled = false;

                            NotificationService.CreateNotification(story.Title + " vừa cập nhập chương mới!");

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lõi. Hãy kiểm tra lại các thông tin", "Thông báo");
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lõi. Hãy kiểm tra lại các thông tin", "Thông báo");
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lõi. " + ex.Message, "Thông báo");
            }
            return false;
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
            BackClick?.Invoke(this, story);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbStt.Clear();
            tbTitle.Clear();
            pnImages.Controls.Clear();

            imagePaths.Clear();
            chapter = null;

            tbStt.Enabled = true;
            tbTitle.Enabled = true;
            btnNew.Visible = false;
            btnAddImage.Visible = true;
            btnSave.Visible = true;
            btnSave.Text = "Đăng tải";


        }
    }
}
