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
using Timer = System.Windows.Forms.Timer;

namespace ReadingApp.UIAdmin
{
    public partial class UCWriteWordStory : UserControl
    {
        int maxLength = 500;
        Timer updateTimer;
        public Story story { get; set; }
        public UCWriteWordStory()
        {

            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            updateTimer = new Timer();
            updateTimer.Interval = 5000; // 10 giay
            updateTimer.Tick += new EventHandler(UpdateCountWord);
            updateTimer.Start();
        }
        private void UpdateCountWord(object sender, EventArgs e)
        {
            int word = rtbContent.TextLength;
            lbCountWord.Text = word.ToString() + "/" + maxLength.ToString() + " từ";
        }
        private void rtbContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rtbContent.Text.Length > maxLength)
            {
                MessageBox.Show("Giới hạn của chương này là 500 từ.", "Thông báo", MessageBoxButtons.OK);
                rtbContent.SelectionStart = maxLength;
            }
        }

        private void UCWriteWordStory_Load(object sender, EventArgs e)
        {

        }
    }
}
