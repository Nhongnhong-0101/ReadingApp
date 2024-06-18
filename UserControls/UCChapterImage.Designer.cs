namespace ReadingApp.UserControls
{
    partial class UCChapterImage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbStoryName = new Label();
            lbChapterName = new Label();
            cbSelectChapter = new ComboBox();
            btnNextChapter = new Button();
            flowImage = new FlowLayoutPanel();
            txtContent = new RichTextBox();
            lbBack = new Label();
            SuspendLayout();
            // 
            // lbStoryName
            // 
            lbStoryName.BackColor = Color.Transparent;
            lbStoryName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbStoryName.ForeColor = Color.DarkGreen;
            lbStoryName.Location = new Point(0, 30);
            lbStoryName.Name = "lbStoryName";
            lbStoryName.Size = new Size(2190, 73);
            lbStoryName.TabIndex = 1;
            lbStoryName.Text = "Tên truyện";
            lbStoryName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbChapterName
            // 
            lbChapterName.Font = new Font("Segoe UI", 12F);
            lbChapterName.Location = new Point(0, 103);
            lbChapterName.Name = "lbChapterName";
            lbChapterName.Size = new Size(2190, 40);
            lbChapterName.TabIndex = 7;
            lbChapterName.Text = "Chương 1: mở đầu";
            lbChapterName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbSelectChapter
            // 
            cbSelectChapter.Font = new Font("Segoe UI", 12F);
            cbSelectChapter.FormattingEnabled = true;
            cbSelectChapter.Location = new Point(1723, 97);
            cbSelectChapter.Name = "cbSelectChapter";
            cbSelectChapter.Size = new Size(220, 46);
            cbSelectChapter.TabIndex = 8;
            cbSelectChapter.Text = "test";
            // 
            // btnNextChapter
            // 
            btnNextChapter.BackColor = Color.ForestGreen;
            btnNextChapter.FlatStyle = FlatStyle.Flat;
            btnNextChapter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNextChapter.ForeColor = Color.White;
            btnNextChapter.Image = Properties.Resources.style_fill_nextChapter;
            btnNextChapter.Location = new Point(1949, 97);
            btnNextChapter.Name = "btnNextChapter";
            btnNextChapter.Size = new Size(46, 46);
            btnNextChapter.TabIndex = 15;
            btnNextChapter.UseVisualStyleBackColor = false;
            btnNextChapter.Click += btnNextChapter_Click;
            // 
            // flowImage
            // 
            flowImage.AutoScroll = true;
            flowImage.Location = new Point(195, 166);
            flowImage.Name = "flowImage";
            flowImage.Size = new Size(1800, 1240);
            flowImage.TabIndex = 16;
            flowImage.Visible = false;
            // 
            // txtContent
            // 
            txtContent.BorderStyle = BorderStyle.FixedSingle;
            txtContent.Font = new Font("Segoe UI", 12F);
            txtContent.Location = new Point(195, 166);
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(1800, 1240);
            txtContent.TabIndex = 0;
            txtContent.Text = "content";
            txtContent.Visible = false;
            // 
            // lbBack
            // 
            lbBack.Font = new Font("Segoe UI", 12F);
            lbBack.Image = Properties.Resources.back2;
            lbBack.ImageAlign = ContentAlignment.MiddleLeft;
            lbBack.Location = new Point(35, 30);
            lbBack.Name = "lbBack";
            lbBack.Size = new Size(203, 43);
            lbBack.TabIndex = 17;
            lbBack.Text = "Quay lại ";
            lbBack.TextAlign = ContentAlignment.MiddleCenter;
            lbBack.Click += lbBack_Click;
            // 
            // UCChapterImage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbBack);
            Controls.Add(txtContent);
            Controls.Add(flowImage);
            Controls.Add(btnNextChapter);
            Controls.Add(cbSelectChapter);
            Controls.Add(lbChapterName);
            Controls.Add(lbStoryName);
            Name = "UCChapterImage";
            Size = new Size(2190, 1474);
            Load += UCChapterImage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbStoryName;
        private Label lbChapterName;
        private ComboBox cbSelectChapter;
        private Button btnNextChapter;
        private FlowLayoutPanel flowImage;
        private RichTextBox txtContent;
        private Label lbBack;
    }
}
