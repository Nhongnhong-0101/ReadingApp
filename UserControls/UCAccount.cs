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
using ReadingApp.Model;
using Image = System.Drawing.Image;
using ReadingApp.Services;

namespace ReadingApp.UserControls
{
    public partial class UCAccount : UserControl
    {
        private bool isMale = true;
        public EventHandler loadUCPasswordChange;
        private User user = new User();
        public UCAccount(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void sexChange()
        {
            if (!isMale)
            {
                picMale.Image = Properties.Resources._checked;
                picFemale.Image = Properties.Resources.check;
                isMale = true;
            }
            else
            {
                picMale.Image = Properties.Resources.check;
                picFemale.Image = Properties.Resources._checked;
                isMale = false;
            }
        }

        private void picMale_Click(object sender, EventArgs e)
        {
            if (!isMale) { sexChange(); }

        }

        private void picFemale_Click(object sender, EventArgs e)
        {
            if (isMale) { sexChange(); }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            loadUCPasswordChange?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            user.Email = txtEmail.Text;
            user.FullName = txtFullName.Text;
            user.UserName = txtUsername.Text;
            user.Dob = DateTime.Parse(dateDob.Text);
            user.IsMale = isMale;
            if (UserServices.updateUser(user.UserID, user))
            {
                lbInfor.Text = "Cập nhật thông tin thành công!";
                lbInfor.Visible = true;
                timer1.Start();
            }
            else
            {
                lbInfor.Text = "Cập nhật thông tin không thành công!";
                lbInfor.Visible = true;
                timer1.Start();
            }
        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
            picAvat.Image = Image.FromFile(@user.Avatar);
            isMale = (bool)user.IsMale;
            sexChange();
            txtEmail.Text = user.Email;
            txtFullName.Text = user.FullName;
            txtUsername.Text = user.UserName;
            dateDob.Text = user.Dob.ToString();
        }

        public string SelectImage()
        {
            string imagePath = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\DELL\Desktop\C#\Avatars";
            openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
            }
            return imagePath;
        }

        private void picEditAvat_Click(object sender, EventArgs e)
        {
            user.Avatar = SelectImage();
            picAvat.Image = Image.FromFile(@user.Avatar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbInfor.Visible = false;
            timer1.Stop();
        }
    }
}
