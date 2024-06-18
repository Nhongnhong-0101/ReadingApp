using ReadingApp.UserControls;
using System.Security.Principal;
using ReadingApp.Model;
using ReadingApp.UIAdmin;
using System.Windows.Forms;

namespace ReadingApp
{
    public partial class Form1 : Form
    {
        private UCHome ucHome;
        private UCLibrary ucLibrary;
        private UCHistory ucHistory;
        private UCAccount ucAccount;
        public User cruUser;
        private UCChapterImage ucChapterImage;
        public Form1()
        {
            InitializeComponent();
            this.cruUser = new User();
        }
        private void unBackground()
        {
            pnHomeTab.BackColor = Color.Transparent;
            pnAccountTab.BackColor = Color.Transparent;
            pnLibraryTab.BackColor = Color.Transparent;
            pnHistoryTab.BackColor = Color.Transparent;

            lbHomeTab.ForeColor = Color.ForestGreen;
            lbAccountTab.ForeColor = Color.ForestGreen;
            lbLibraryTab.ForeColor = Color.ForestGreen;
            lbHistoryTab.ForeColor = Color.ForestGreen;

            picHomeTab.Image = Properties.Resources.home;
            picAccountTab.Image = Properties.Resources.user;
            picLibraryTab.Image = Properties.Resources.library;
            picHistoryTab.Image = Properties.Resources.history;
        }

        private void loadUCAccount(object? sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            ucAccount = new UCAccount(cruUser);
            ucAccount.loadUCPasswordChange += loadUCPasswordChange;
            pnMain.Controls.Add(ucAccount);
        }

        private void pnHomeTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnHomeTab.BackColor = Color.ForestGreen;
            lbHomeTab.ForeColor = Color.White;
            picHomeTab.Image = Properties.Resources.home_white;

            pnMain.Controls.Clear();
            ucHome = new UCHome(cruUser);
            ucHome.loadUCAccount += pnAccountTab_Click;
            ucHome.loadUCStoryDetails += loadUCStoryDetails;
            ucHome.ShowAddNewStr += UcHome_ShowAddNewStr;
            pnMain.Controls.Add(ucHome);
        }

        private void UcHome_ShowAddNewStr(object sender, EventArgs e)
        {
            try
            {
                UCAddNewStory uCAddNewStory = new UCAddNewStory();
                this.Controls.Clear();
                this.Controls.Add(uCAddNewStory);

                uCAddNewStory.StorySaved += UCAddNewStory_StorySaved;
            }
            catch { }
        }

        private void UCAddNewStory_StorySaved(object sender, Story story)
        {
            try
            {
                if (story.Category == "truyện tranh")
                {
                    UCWriteImageStory uCWriteImageStory = new UCWriteImageStory();
                    uCWriteImageStory.story = story;

                    this.Controls.Clear();
                    this.Controls.Add(uCWriteImageStory);

                }
                else
                {
                    UCWriteWordStory uCWriteWordStory = new UCWriteWordStory();
                    uCWriteWordStory.story = story;
                    this.Controls.Clear();
                    this.Controls.Add(uCWriteWordStory);
                }

            }
            catch (Exception ex){ }
        }

        private void pnAccountTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnAccountTab.BackColor = Color.ForestGreen;
            lbAccountTab.ForeColor = Color.White;
            picAccountTab.Image = Properties.Resources.user_white;

            loadUCAccount(sender,e);
        }

        private void pnLibraryTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnLibraryTab.BackColor = Color.ForestGreen;
            lbLibraryTab.ForeColor = Color.White;
            picLibraryTab.Image = Properties.Resources.library_white;

            pnMain.Controls.Clear();
            ucLibrary = new UCLibrary(cruUser);
            ucLibrary.loadUCAccount += pnAccountTab_Click;
            pnMain.Controls.Add(ucLibrary);
        }

        private void pnHistoryTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnHistoryTab.BackColor = Color.ForestGreen;
            lbHistoryTab.ForeColor = Color.White;
            picHistoryTab.Image = Properties.Resources.history_white;

            pnMain.Controls.Clear();
            ucHistory = new UCHistory(cruUser);
            ucHistory.loadUCStoryDetails += loadUCStoryDetails;
            ucHistory.loadUCAccount += pnAccountTab_Click;
            pnMain.Controls.Add(ucHistory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCLogIn uCLogIn = new UCLogIn();            
            uCLogIn.loadUCHome += loadUCHome;
            uCLogIn.loadUCForgotPassword += loadUCForgotPassword;
            uCLogIn.loadUCSignUp += loadUCSignUp;
            pnLogIn.Visible = true;
            pnLogIn.Controls.Clear();
            pnLogIn.Controls.Add(uCLogIn);
            pnHomeTab_Click(sender, e);

            pnAccountTab.Visible = (cruUser.FullName == "Admin") ? false : true;
        }

        private void loadUCSignUp(object? sender, EventArgs e)
        {
            UCSignUp uCSignUp = new UCSignUp();
            uCSignUp.loadUCLogIn += Form1_Load;
            uCSignUp.loadUCHome += loadUCHome;
            pnLogIn.Controls.Clear();
            pnLogIn.Controls.Add(uCSignUp);
        }

        private void loadUCPasswordChange(object? sender, EventArgs e)
        {
            UCPasswordChange uCPasswordChange = new UCPasswordChange(cruUser);
            uCPasswordChange.loadUCAccount = loadUCAccount;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(uCPasswordChange);
        }

        private void loadUCStoryDetails(object? sender, Story e)
        {
            UCStoryDetails ucStoryDetails = new UCStoryDetails(e, cruUser);
            ucStoryDetails.loadChapter += loadChapter;
            SaveIndexStart();
            pnMain.Controls.Clear();
            pnMain.Controls.Add(ucStoryDetails);
        }

        private void SaveIndexStart()
        {
            if (pnMain.Controls.OfType<UCChapterImage>().Any())
            {
                ucChapterImage.saveIndexStart();
            }
        }

        private void loadChapter(object? sender, Chapter e)
        {
            ucChapterImage = new UCChapterImage(e,0,cruUser.UserID);
            ucChapterImage.loadStoryDetails += loadUCStoryDetails;
            ucChapterImage.loadChapter += loadChapter;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(ucChapterImage);
        }

        private void loadUCForgotPassword(object? sender, EventArgs e)
        {
            UCForgotPassword uCForgotPassword = new UCForgotPassword();
            uCForgotPassword.loadUCLogIn += Form1_Load;
            pnLogIn.Controls.Clear();
            pnLogIn.Controls.Add(uCForgotPassword);
        }

        private void loadUCHome(object? sender, User e)
        {
            pnLogIn.Visible = false;
            cruUser = e;
            pnHomeTab_Click(sender, EventArgs.Empty);
        }

        private void pnLogout_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
