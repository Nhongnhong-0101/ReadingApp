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
using static System.Net.Mime.MediaTypeNames;

namespace ReadingApp.UIAdmin
{
    public partial class UCWriteImageStory : UserControl
    {
        int maxImage = 30;

        private Dictionary<int, string> imagePaths = new Dictionary<int, string>();

        private ContextMenuStrip contextMenu;

        public Story story { get; set; }
        public UCWriteImageStory()
        {
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

                PictureBox image = new PictureBox();
                image.SizeMode = PictureBoxSizeMode.AutoSize;
                image.Image = System.Drawing.Image.FromFile(imagePath);
                image.Tag = stt;

                image.MouseClick += Image_MouseClick; // Gắn sự kiện MouseClick

                pnImages.Controls.Add(image);

                locationImage.X = pnImages.Width / 2 - image.Width / 2;
                image.Location = locationImage;

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

            lbCountWord.Text = imagePaths.Count.ToString() + " hình";
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
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu không?", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            //mỗi một string trong dictionry thì lưu 1 lần 

        }
    }
}
