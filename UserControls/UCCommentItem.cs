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

namespace ReadingApp.UserControls
{
    public partial class UCCommentItem : UserControl
    {
        private Rating rating = new Rating();
        private string userName = "";
        public UCCommentItem(Rating rating, string userName)
        {
            InitializeComponent();
            this.rating = rating;
            this.userName = userName;
        }
        private void addStar()
        {
            switch (rating.Star)
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
            }
        }
        private void UCCommentItem_Load(object sender, EventArgs e)
        {
            addStar();
            lbUserName.Text = userName;
            txtComment.Text = rating.Comment;
            lbTime.Text = rating.CreatedAt.ToString();
        }
    }
}
