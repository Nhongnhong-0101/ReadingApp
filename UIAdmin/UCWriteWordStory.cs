using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingApp.UIAdmin
{
    public partial class UCWriteWordStory : UserControl
    {
        int maxLength = 500;
        public UCWriteWordStory()
        {
            InitializeComponent();
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(rtbContent.Text.Length > maxLength)
            {
                MessageBox.Show("Giới hạn của chương này là 500 từ.", "Thông báo", MessageBoxButtons.OK);
                rtbContent.SelectionStart = maxLength;
            }
        }
    }
}
