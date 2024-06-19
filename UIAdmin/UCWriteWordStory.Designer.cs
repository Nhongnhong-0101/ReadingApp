namespace ReadingApp.UIAdmin
{
    partial class UCWriteWordStory
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
            tbTitle = new TextBox();
            rtbContent = new RichTextBox();
            lbCountWord = new Label();
            btnSave = new Button();
            lbNumChapter = new Label();
            pcBack = new PictureBox();
            tbStt = new TextBox();
            btnDel = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pcBack).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(28, 17);
            tbTitle.Margin = new Padding(4, 4, 4, 4);
            tbTitle.Multiline = true;
            tbTitle.Name = "tbTitle";
            tbTitle.PlaceholderText = "Tiêu đề của chương";
            tbTitle.Size = new Size(904, 51);
            tbTitle.TabIndex = 0;
            tbTitle.Text = "Tiêu đề của chương";
            tbTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // rtbContent
            // 
            rtbContent.BorderStyle = BorderStyle.FixedSingle;
            rtbContent.Location = new Point(32, 177);
            rtbContent.Margin = new Padding(4, 4, 4, 4);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(2120, 1159);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            rtbContent.TextChanged += rtbContent_TextChanged;
            // 
            // lbCountWord
            // 
            lbCountWord.AutoSize = true;
            lbCountWord.ForeColor = SystemColors.Highlight;
            lbCountWord.Location = new Point(36, 120);
            lbCountWord.Margin = new Padding(4, 0, 4, 0);
            lbCountWord.Name = "lbCountWord";
            lbCountWord.Size = new Size(111, 30);
            lbCountWord.TabIndex = 2;
            lbCountWord.Text = "0/ 3000 Từ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1059, 1371);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 68);
            btnSave.TabIndex = 3;
            btnSave.Text = "Đăng tải";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbNumChapter
            // 
            lbNumChapter.AutoSize = true;
            lbNumChapter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumChapter.Location = new Point(142, 24);
            lbNumChapter.Margin = new Padding(4, 0, 4, 0);
            lbNumChapter.Name = "lbNumChapter";
            lbNumChapter.Size = new Size(174, 38);
            lbNumChapter.TabIndex = 4;
            lbNumChapter.Text = "Chương số* ";
            // 
            // pcBack
            // 
            pcBack.BackgroundImage = Properties.Resources.back2;
            pcBack.BackgroundImageLayout = ImageLayout.Stretch;
            pcBack.Location = new Point(36, 18);
            pcBack.Margin = new Padding(4, 4, 4, 4);
            pcBack.Name = "pcBack";
            pcBack.Size = new Size(52, 52);
            pcBack.TabIndex = 12;
            pcBack.TabStop = false;
            pcBack.Click += pictureBox1_Click;
            // 
            // tbStt
            // 
            tbStt.BorderStyle = BorderStyle.FixedSingle;
            tbStt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbStt.Location = new Point(310, 24);
            tbStt.Margin = new Padding(4, 4, 4, 4);
            tbStt.Name = "tbStt";
            tbStt.Size = new Size(45, 41);
            tbStt.TabIndex = 13;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.ForestGreen;
            btnDel.BackgroundImageLayout = ImageLayout.Stretch;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(2013, 98);
            btnDel.Margin = new Padding(4, 4, 4, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(141, 60);
            btnDel.TabIndex = 14;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_search;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tbTitle);
            panel1.Location = new Point(633, 18);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 80);
            panel1.TabIndex = 15;
            // 
            // UCWriteWordStory
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(btnDel);
            Controls.Add(tbStt);
            Controls.Add(pcBack);
            Controls.Add(lbNumChapter);
            Controls.Add(btnSave);
            Controls.Add(lbCountWord);
            Controls.Add(rtbContent);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UCWriteWordStory";
            Size = new Size(2190, 1474);
            Load += UCWriteWordStory_Load;
            ((System.ComponentModel.ISupportInitialize)pcBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitle;
        private RichTextBox rtbContent;
        private Label label1;
        private Button btnSave;
        private Label lbNumChapter;
        private Label lbCountWord;
        private PictureBox pcBack;
        private TextBox tbStt;
        private Button btnDel;
        private Panel panel1;
    }
}
