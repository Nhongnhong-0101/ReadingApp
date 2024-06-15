using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadingApp.Model;
using ReadingApp.UIAdmin;
using ReadingApp.Services;

namespace ReadingApp.UserControls
{
    public partial class UCHome : UserControl
    {
        private bool isComic = false;
        private bool isStory = false;
        private bool isFull = false;
        private bool isUpdating = false;
        private bool isFree = false;
        private bool isFee = false;
        public EventHandler loadUCAccount;
        public EventHandler<Story> loadUCStoryDetails;
        private User user;
        public delegate void ShowAddNewStoryEventHander(object sender, EventArgs e);
        public event ShowAddNewStoryEventHander ShowAddNewStr;
        private List<Story> stories = new List<Story>();
        private List<Story> outs = new List<Story>();
        private List<Story> star = new List<Story>();
        private List<Story> lasted = new List<Story>();
        List<Story> searchStories = new List<Story>();

        public UCHome(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            //picAvat.Image = Image.FromFile(@user.Avatar);

            stories.Clear();
            stories = StoriesServices.get24Stories();
            loadFlowPanel(stories);

            lasted.Clear();
            flowLasted.Controls.Clear();
            lasted = StoriesServices.getLastedStories();
            for (int i = 0; i < 4; i++)
            {
                int index = i;
                Label lbName = labelName(lasted[index].Title);
                Label lbAuthor = labelAuthor(lasted[index].Author);
                lbName.Click += (sender, e) => _loadUCStoryDetails(sender, lasted[index]);
                lbAuthor.Click += (sender, e) => _loadUCStoryDetails(sender, lasted[index]);

                flowLasted.Controls.Add(lbName);
                flowLasted.Controls.Add(lbAuthor);
            }

            outs.Clear();
            flowOuts.Controls.Clear();
            outs = StoriesServices.getOutsStories();
            for (int i = 0; i < 4; i++)
            {
                int index = i;
                Label lbName = labelName(outs[index].Title);
                Label lbAuthor = labelAuthor(outs[index].Author);
                lbName.Click += (sender, e) => _loadUCStoryDetails(sender, lasted[index]);
                lbAuthor.Click += (sender, e) => _loadUCStoryDetails(sender, lasted[index]);

                flowOuts.Controls.Add(lbName);
                flowOuts.Controls.Add(lbAuthor);
            }

            star.Clear();
            flowStar.Controls.Clear();
            star = StoriesServices.getStarStories();
            for (int i = 0; i < 4; i++)
            {
                int index = i;
                Label lbName = labelName(star[index].Title);
                Label lbAuthor = labelAuthor(star[index].Author);
                lbName.Click += (sender, e) => _loadUCStoryDetails(sender, lasted[index]);
                lbAuthor.Click += (sender, e) => _loadUCStoryDetails(sender, lasted[index]);

                flowStar.Controls.Add(lbName);
                flowStar.Controls.Add(lbAuthor);
            }
        }

        private Label labelName(string name)
        {
            Label lbName = new Label();
            lbName.Text = name;
            lbName.AutoSize = false;
            lbName.Size = new System.Drawing.Size(330, 40);
            lbName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            return lbName;
        }

        private Label labelAuthor(string author)
        {
            Label lbName = new Label();
            lbName.Text = author;
            lbName.AutoSize = false;
            lbName.Size = new System.Drawing.Size(330, 40);
            lbName.Padding = new Padding(2, 0, 0, 0);
            lbName.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lbName.ForeColor = System.Drawing.Color.Gray;

            return lbName;
        }

        private void loadFlowPanel(List<Story> stories)
        {
            flowMain.Controls.Clear();
            for (int i = 0; i < stories.Count; i++)
            {
                UCStoryItem ucStoryItem = new UCStoryItem(stories[i]);
                ucStoryItem.loadUCStoryDetails += _loadUCStoryDetails;
                flowMain.Controls.Add(ucStoryItem);
            }

            //Admin thì hiện nút viết truyện 
            btnWrite.Visible = (user.FullName == "Admin") ? true : false;
            btnWrite.Click += BtnWrite_Click;

        }

        private void BtnWrite_Click(object? sender, EventArgs e)
        {
            try
            {
                OnShowAddNewStr(EventArgs.Empty);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        protected virtual void OnShowAddNewStr(EventArgs e)
        {
            ShowAddNewStr?.Invoke(this, e);
        }

        private void _loadUCStoryDetails(object? sender, Story e)
        {
            loadUCStoryDetails?.Invoke(this, e);
        }

        private void pnType_Click(object sender, EventArgs e)
        {
            if (panelType.Visible)
            {
                panelType.Visible = false;
            }
            else
            {
                panelType.Visible = true;
            }

        }

        private void hoverType(Label label)
        {
            label.ForeColor = Color.DarkGreen;
            label.Font = new Font(label.Font, FontStyle.Underline);
        }

        private void leaveType(Label label)
        {
            label.ForeColor = Color.Black;
            label.Font = new Font(label.Font, FontStyle.Regular);
        }

        private void lbBachHop_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbBachHop);
        }

        private void lbBachHop_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbBachHop);
        }

        private void lbNgonTinh_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbNgonTinh);
        }

        private void lbNgonTinh_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbNgonTinh);
        }

        private void lbCoTrang_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbCoTrang);
        }

        private void lbCoTrang_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbCoTrang);
        }

        private void lbCungDau_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbCungDau);
        }

        private void lbCungDau_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbCungDau);
        }

        private void lbTheLoai5_MouseHover(object sender, EventArgs e)
        {
            hoverType(lbTheLoai5);
        }

        private void lbTheLoai5_MouseLeave(object sender, EventArgs e)
        {
            leaveType((lbTheLoai5));
        }

        private void lbTheLoai6_MouseHover(object sender, EventArgs e)
        {
            hoverType((lbTheLoai6));
        }

        private void lbTheLoai6_MouseLeave(object sender, EventArgs e)
        {
            leaveType(lbTheLoai6);
        }

        private void visiblePanelSearch(Label label)
        {
            hoverType(label);
            cbType.Text = label.Text;
            pnSearch.Visible = true;
            flowMain.Height = 1205;
            flowMain.Location = new System.Drawing.Point(0, 270);
            panelState.Location = new System.Drawing.Point(1790, 270);
            panelType.Visible = false;

            btnSearch_Click(this, EventArgs.Empty);
        }

        private void lbNgonTinh_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbNgonTinh);
        }

        private void lbCoTrang_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbCoTrang);
        }

        private void lbCungDau_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbCungDau);
        }

        private void lbBachHop_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbBachHop);
        }

        private void lbTheLoai5_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbTheLoai5);
        }

        private void lbTheLoai6_Click(object sender, EventArgs e)
        {
            visiblePanelSearch(lbTheLoai6);
        }

        private void filterSearch(ref bool filter, PictureBox pictureBox)
        {
            if (!filter)
            {
                pictureBox.Image = Properties.Resources._checked;
                filter = true;
            }
            else
            {
                pictureBox.Image = Properties.Resources.check;
                filter = false;
            }
        }

        private void pnComic_Click(object sender, EventArgs e)
        {
            filterSearch(ref isComic, picComic);
        }

        private void pnStory_Click(object sender, EventArgs e)
        {
            filterSearch(ref isStory, picStory);
        }

        private void pnFull_Click(object sender, EventArgs e)
        {
            filterSearch(ref isFull, picFull);
        }

        private void pnUpdating_Click(object sender, EventArgs e)
        {
            filterSearch(ref isUpdating, picUpdating);
        }

        private void pnFree_Click(object sender, EventArgs e)
        {
            filterSearch(ref isFree, picFree);
        }

        private void pnFee_Click(object sender, EventArgs e)
        {
            filterSearch(ref isFee, picFee);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadUCAccount?.Invoke(this, EventArgs.Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            stories.Clear();
            stories = StoriesServices.getSearchStories(cbType.Text, cbArrange.Text, isStory, isComic, isFull, isUpdating, isFree, isFee);
            loadFlowPanel(stories);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<Story> allstories = StoriesServices.getAllStories();
                searchStories.Clear();
                string searchText = txtSearch.Text.ToLower();
                foreach (Story story in allstories)
                {
                    if (story.Title.ToLower().Contains(searchText) || story.Author.ToLower().Contains(searchText))
                    {
                        searchStories.Add(story);
                    }
                }
                loadFlowPanel(searchStories);
            }
        }
    }
}
