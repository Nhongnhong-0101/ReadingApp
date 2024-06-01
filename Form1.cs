using ReadingApp.UserControls;
using System.Security.Principal;

namespace ReadingApp
{
    public partial class Form1 : Form
    {
        private UCHome ucHome;
        public Form1()
        {
            InitializeComponent();
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

        private void pnHomeTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnHomeTab.BackColor = Color.ForestGreen;
            lbHomeTab.ForeColor = Color.White;
            picHomeTab.Image = Properties.Resources.home_white;

            pnMain.Controls.Clear();
            ucHome = new UCHome();
            pnMain.Controls.Add(ucHome);
        }

        private void pnAccountTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnAccountTab.BackColor = Color.ForestGreen;
            lbAccountTab.ForeColor = Color.White;
            picAccountTab.Image = Properties.Resources.user_white;

            pnMain.Controls.Clear();
        }

        private void pnLibraryTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnLibraryTab.BackColor = Color.ForestGreen;
            lbLibraryTab.ForeColor = Color.White;
            picLibraryTab.Image = Properties.Resources.library_white;

            pnMain.Controls.Clear();
        }

        private void pnHistoryTab_Click(object sender, EventArgs e)
        {
            unBackground();
            pnHistoryTab.BackColor = Color.ForestGreen;
            lbHistoryTab.ForeColor = Color.White;
            picHistoryTab.Image = Properties.Resources.history_white;

            pnMain.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCLogIn uCLogIn = new UCLogIn();
            uCLogIn.loadUCHome += loadUCHome;
            uCLogIn.loadUCForgotPassword += loadUCForgotPassword;
            pnLogIn.Visible = true;
            pnLogIn.Controls.Clear();
            pnLogIn.Controls.Add(uCLogIn);
            pnHomeTab_Click(sender, e);
        }

        private void loadUCForgotPassword(object? sender, EventArgs e)
        {
            UCForgotPassword uCForgotPassword = new UCForgotPassword();
            uCForgotPassword.loadUCLogIn += Form1_Load;
            pnLogIn.Controls.Clear();
            pnLogIn.Controls.Add(uCForgotPassword);
        }

        private void loadUCHome(object? sender, EventArgs e)
        {
            pnLogIn.Visible = false;
            pnHomeTab_Click(sender, e);
        }

        private void pnLogout_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
