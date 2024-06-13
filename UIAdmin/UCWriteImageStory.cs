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
        //TODO: chưa xóa và thay đổi hình được
        int maxImage = 30;

        private List<String> imagePaths = new List<string>();
        private ContextMenuStrip contextMenu;

        public Story story {  get; set; }
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
                        imagePaths.Add(selectedImagePath);
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
            int stt = 1;

            foreach (string imagePath in imagePaths)
            {
                PictureBox image = new PictureBox();
                image.SizeMode = PictureBoxSizeMode.AutoSize;
                image.Image = System.Drawing.Image.FromFile(imagePath);
                image.MouseClick += Image_MouseClick; // Gắn sự kiện MouseClick

                pnImages.Controls.Add(image);

                locationImage.X = pnImages.Width / 2 - image.Width / 2;
                image.Location = locationImage;

                locationImage.Y += image.Height + 40;

                Point locationStt = new Point();
                locationStt.Y = image.Location.Y + image.Height + 10;
                locationStt.X = image.Location.X + image.Width/2;
                locationStt.X = 300;

                Label lbStt = new Label();
                lbStt.Text = stt.ToString();

                lbStt.Location = locationStt;

                pnImages.Controls.Add(lbStt);

                stt++;
            }

            lbNumChapter.Text = (stt - 1).ToString() + " hình";
        }
        private void DeleteImage(object sender, EventArgs e)
        {
            if (contextMenu.Tag is PictureBox image)
            {

                string imagePathToRemove = imagePaths[pnImages.Controls.IndexOf(image)];

                MessageBox.Show(pnImages.Controls.IndexOf(image).ToString());
                imagePaths.Remove(imagePathToRemove);

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

                        int index = pnImages.Controls.IndexOf(image);
                        imagePaths[index] = newImagePath;

                        // Cập nhật hình ảnh cho PictureBox
                        image.Image = System.Drawing.Image.FromFile(newImagePath);
                    }
                }
            }
        }

        private void Image_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PictureBox clickedImage = sender as PictureBox;
                contextMenu.Tag = clickedImage; 
                contextMenu.Show(Cursor.Position);
            }
        }
    }
}
