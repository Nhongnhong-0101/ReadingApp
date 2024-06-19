namespace ReadingApp.UIAdmin
{
    partial class UCWriteImageStory
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
            lbNumChapter = new Label();
            tbTitle = new TextBox();
            lbCountWord = new Label();
            pnImages = new Panel();
            btnAddImage = new Button();
            btnSave = new Button();
            btnNew = new Button();
            pictureBox1 = new PictureBox();
            tbStt = new TextBox();
            btnDel = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbNumChapter
            // 
            lbNumChapter.AutoSize = true;
            lbNumChapter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumChapter.Location = new Point(120, 32);
            lbNumChapter.Margin = new Padding(4, 0, 4, 0);
            lbNumChapter.Name = "lbNumChapter";
            lbNumChapter.Size = new Size(166, 38);
            lbNumChapter.TabIndex = 5;
            lbNumChapter.Text = "Chương số*";
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(63, 12);
            tbTitle.Margin = new Padding(4, 4, 4, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(694, 34);
            tbTitle.TabIndex = 6;
            tbTitle.Text = "Tiêu đề của chương";
            tbTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // lbCountWord
            // 
            lbCountWord.AutoSize = true;
            lbCountWord.ForeColor = SystemColors.Highlight;
            lbCountWord.Location = new Point(462, 148);
            lbCountWord.Margin = new Padding(4, 0, 4, 0);
            lbCountWord.Name = "lbCountWord";
            lbCountWord.Size = new Size(101, 30);
            lbCountWord.TabIndex = 7;
            lbCountWord.Text = "0/40 hình";
            // 
            // pnImages
            // 
            pnImages.AutoScroll = true;
            pnImages.BackColor = Color.White;
            pnImages.BackgroundImage = Properties.Resources.bg_RL;
            pnImages.BackgroundImageLayout = ImageLayout.Stretch;
            pnImages.Location = new Point(462, 210);
            pnImages.Margin = new Padding(4, 4, 4, 4);
            pnImages.Name = "pnImages";
            pnImages.Padding = new Padding(0, 30, 0, 30);
            pnImages.Size = new Size(1210, 1143);
            pnImages.TabIndex = 8;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = Color.ForestGreen;
            btnAddImage.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddImage.ForeColor = SystemColors.ButtonHighlight;
            btnAddImage.Location = new Point(1038, 1378);
            btnAddImage.Margin = new Padding(4, 4, 4, 4);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(189, 68);
            btnAddImage.TabIndex = 2;
            btnAddImage.Text = "Thêm hình";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(1469, 131);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 60);
            btnSave.TabIndex = 9;
            btnSave.Text = "Chỉnh sửa";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGreen;
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 11F);
            btnNew.Location = new Point(1235, 131);
            btnNew.Margin = new Padding(4, 4, 4, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(202, 60);
            btnNew.TabIndex = 10;
            btnNew.Text = "Chương mới";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Visible = false;
            btnNew.Click += btnNew_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.back2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(34, 26);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbStt
            // 
            tbStt.BorderStyle = BorderStyle.FixedSingle;
            tbStt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbStt.Location = new Point(294, 33);
            tbStt.Margin = new Padding(4, 4, 4, 4);
            tbStt.Name = "tbStt";
            tbStt.Size = new Size(49, 41);
            tbStt.TabIndex = 14;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.White;
            btnDel.BackgroundImageLayout = ImageLayout.Stretch;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(1492, 33);
            btnDel.Margin = new Padding(4, 4, 4, 4);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(180, 60);
            btnDel.TabIndex = 15;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Visible = false;
            btnDel.Click += btnDel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.bg_search;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tbTitle);
            panel1.Location = new Point(621, 32);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 63);
            panel1.TabIndex = 16;
            // 
            // UCWriteImageStory
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(btnDel);
            Controls.Add(tbStt);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(btnNew);
            Controls.Add(btnAddImage);
            Controls.Add(pnImages);
            Controls.Add(lbCountWord);
            Controls.Add(lbNumChapter);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UCWriteImageStory";
            Size = new Size(2190, 1474);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumChapter;
        private TextBox tbTitle;
        private Label lbCountWord;
        private Panel pnImages;
        private Button btnAddImage;
        private Button btnSave;
        private Button btnNew;
        private PictureBox pictureBox1;
        private TextBox tbStt;
        private Button btnDel;
        private Panel panel1;
    }
}
