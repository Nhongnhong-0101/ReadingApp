using ReadingApp.Model;
using ReadingApp.UIAdmin;
using ReadingApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingApp
{
    public partial class FormTest : Form
    {
        UCHome ucHome;

        User Admin;
        public FormTest()
        {
            InitializeComponent();

            Admin = new User();
            Admin.FullName = "Admin";
            ucHome = new UCHome(Admin);

            this.Controls.Add(ucHome);

            ucHome.ShowAddNewStr += UcHome_ShowAddNewStr;


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
            catch { 

            }
        }

        private void UCAddNewStory_StorySaved(object sender, Story story)
        {
            try
            {
                if(story.Category == "truyện tranh")
                {
                    UCWriteImageStory uCWriteImageStory = new UCWriteImageStory(story, Admin, true);

                    this.Controls.Clear();
                    this.Controls.Add(uCWriteImageStory);

                }
                else
                {
                    UCWriteWordStory uCWriteWordStory = new UCWriteWordStory(story, Admin, true);
                    this.Controls.Clear();
                    this.Controls.Add(uCWriteWordStory);
                }
                
            }
            catch (Exception ex) { 
            }
        }
    }
}
