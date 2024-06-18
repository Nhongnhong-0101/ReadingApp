using ReadingApp.Model;
using ReadingApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

using System.Net.Http;
using System.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReadingApp.UserControls
{
    public partial class UCChapterImage : UserControl
    {
        public Chapter chapter;
        private List<Chapter> chapters = new List<Chapter>();
        public EventHandler<Story> loadStoryDetails;
        public EventHandler<Chapter> loadChapter;
        public EventHandler<int> SaveIndexStart;
        private int index = 0;
        private int indexStart = 0;
        private int userID;
        public UCChapterImage(Chapter chapter, int indexStart, int userID)

        private List<String> voices = new List<string> { "Giọng nữ miền Nam", "Giọng nữ miền Bắc", "Giọng nam miền Nam", "Giọng nam miền Bắc" };
        public UCChapterImage(Chapter chapter)
        {
            InitializeComponent();

            this.chapter = chapter;
            this.indexStart = indexStart;
            this.userID = userID;
        }
        public void saveIndexStart()
        {
            if (!PayServices.isProgress(userID,chapter.Story.StoryID)) {
                //PayServices.newIndexStart(userID, chapter.Story.StoryID, chapter.ChapterID, txtContent.VerticalScroll.Value);
            }
            else 
            {
                PayServices.saveIndexStart(userID, chapter.Story.StoryID, chapter.ChapterID, txtContent.SelectionStart);
            }
        }
            cmbVoice.DataSource = voices;
            cmbVoice.SelectedIndex = -1;


        }

        private void UCChapterImage_Load(object sender, EventArgs e)
        {
            if (chapter.Story.Category == "truyện chữ")
            {
                chapters = ChapterService.getChapters(chapter.Story.StoryID);
                txtContent.Text = chapter.Content;
                txtContent.SelectionStart = indexStart;
                txtContent.ScrollToCaret();
                txtContent.Visible = true;
            }
            else
            {
                btnSpeaker.Visible = false;
                cmbVoice.Visible = false;
                chapters = ChapterService.getImageChapters(chapter.Story.StoryID);
                foreach (ChapterImages chapterImages in chapter.Images)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(chapterImages.ImageURL);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Width = flowImage.Width - 70;
                    pictureBox.Height = flowImage.Height * 2 - 100;
                    pictureBox.Margin = new Padding(5);

                    flowImage.Controls.Add(pictureBox);
                }
                flowImage.VerticalScroll.Value = indexStart;
                flowImage.Visible = true;
            }
            lbStoryName.Text = chapter.Story.Title;

            cbSelectChapter.Items.Clear();
            for (int i = 0; i < chapters.Count; i++)
            {
                cbSelectChapter.Items.Add("Chương " + (i + 1).ToString());
                if (chapters[i].Title == chapter.Title)
                {
                    cbSelectChapter.SelectedIndex = i;
                    lbChapterName.Text = ("Chương " + chapter.ChapterNumber + ": " + chapter.Title);
                    index = i;
                    btnNextChapter.Enabled = (chapters.Count == i + 1) ? false : true;
                    cbSelectChapter.SelectedIndexChanged += cbSelectChapter_SelectedIndexChanged;
                }
            }
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            loadStoryDetails?.Invoke(sender, chapter.Story);
        }

        private void btnNextChapter_Click(object sender, EventArgs e)
        {
            loadChapter?.Invoke(sender, chapters[index + 1]);
        }

        private void cbSelectChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChapter?.Invoke(sender, chapters[cbSelectChapter.SelectedIndex]);
        }

        private async void  btnSpeaker_Click(object sender, EventArgs e)
        {
            int idSpeaker = cmbVoice.SelectedIndex + 1;
            string content = chapter.Content;
            if(content.Length > 2000)
            {
                content = content.Substring(0, 1999);
            }

            await ReadContent(content, idSpeaker);
        }

        private async Task ReadContent(String inputText, int speakerId)
        {
            string apiKey = "0LiDyWNSptHD4HXYzqo1n0Igx24rWh3l";

            string apiUrl = $"https://api.zalo.ai/v1/tts/synthesize";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("apikey", apiKey);

                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("input", inputText),
                new KeyValuePair<string, string>("speaker_id", speakerId.ToString())
                 });

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<JObject>(responseContent);

                    if (responseData["error_code"].ToString() == "0")
                    {
                        string audioUrl = responseData["data"]["url"].ToString();

                        //tải vè
                        byte[] audioData;
                        using (var audioResponse = await client.GetAsync(audioUrl))
                        {
                            audioData = await audioResponse.Content.ReadAsByteArrayAsync();
                        }

                        // phát
                        using (MemoryStream memoryStream = new MemoryStream(audioData))
                        {
                            using (SoundPlayer player = new SoundPlayer(memoryStream))
                            {
                                player.PlaySync(); 
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"API Request failed: {response.StatusCode}");
                }
            }
        }
    }
}
