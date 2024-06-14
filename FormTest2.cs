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

namespace ReadingApp
{
    public partial class FormTest2 : Form
    {
        public FormTest2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                String selectedImagePath;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    System.Drawing.Image originalImage = System.Drawing.Image.FromFile(selectedImagePath);
                    if (originalImage.Width > 500)
                    {
                        int newWidth = 500;
                        int newHeight = (int)(originalImage.Height * (500.0 / originalImage.Width));

                        // Create a new bitmap with the new dimensions
                        Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                        // Set the PictureBox to the resized image
                        pictureBox1.Image = resizedImage;
                    }
                    else
                    {
                        // Set the PictureBox to the original image
                        pictureBox1.Image = originalImage;
                    }
                }
            }
        }
    }
}
