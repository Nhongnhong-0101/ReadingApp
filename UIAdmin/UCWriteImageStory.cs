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
        int maxImage = 30;

        private Dictionary<int, string> imagePaths = new Dictionary<int, string>();

        private ContextMenuStrip contextMenu;

        public Story story { get; set; }

        public Chapter chapter;

        public ChapterService chapterService { get; set; }
        public UCWriteImageStory()
        {
            chapter = new Chapter();
            chapterService = new ChapterService();
            InitializeComponent();
            InitializeContextMenu();
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

            lbCountWord.Text = imagePaths.Count.ToString() +"/"+ maxImage.ToString() + " hình";
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
            if(btnSave.Text == "Chỉnh sửa")
            {
                btnSave.Text = "Đăng tải";
                btnAddImage.Visible = true;
                tbTitle.Enabled = true;
                btnNew.Visible = false;

            }   
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveData();
                }
            }
        }

        private void SaveData()
        {
            try {
                if (!String.IsNullOrWhiteSpace(tbTitle.Text) 
                    && tbTitle.Text != "Tiêu đề của chương"
                    && imagePaths.Count <= 30)
                {
                    chapter.Title = tbTitle.Text.Trim();
                    chapter.ChapterNumber = ExtractNumberFromString(lbNumChapter.Text);
                    chapter.CreatedAt = DateTime.Now;

                    if (chapterService.SaveNewImageChapter(story.StoryID, chapter, imagePaths))
                    {
                        MessageBox.Show("Bạn đã lưu chương mới thành công", "Thông báo");

                        btnSave.Text = "Chỉnh sửa";
                        btnAddImage.Visible = false;
                        tbTitle.Enabled = false;
                        btnNew.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lõi. Hãy kiểm tra lại các thông tin", "Thông báo");
                    }
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lõi. " + ex.Message , "Thông báo");

            }
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
