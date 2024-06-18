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
            lbNumChapter.Location = new Point(80, 21);
            lbNumChapter.Name = "lbNumChapter";
            lbNumChapter.Size = new Size(120, 28);
            lbNumChapter.TabIndex = 5;
            lbNumChapter.Text = "Chương số*";
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(42, 8);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(463, 24);
            tbTitle.TabIndex = 6;
            tbTitle.Text = "Tiêu đề của chương";
            tbTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // lbCountWord
            // 
            lbCountWord.AutoSize = true;
            lbCountWord.ForeColor = SystemColors.Highlight;
            lbCountWord.Location = new Point(308, 99);
            lbCountWord.Name = "lbCountWord";
            lbCountWord.Size = new Size(71, 20);
            lbCountWord.TabIndex = 7;
            lbCountWord.Text = "0/40 hình";
            // 
            // pnImages
            // 
            pnImages.AutoScroll = true;
            pnImages.BackColor = SystemColors.AppWorkspace;
            pnImages.BackgroundImage = Properties.Resources.bg_RL;
            pnImages.BackgroundImageLayout = ImageLayout.Stretch;
            pnImages.Location = new Point(308, 140);
            pnImages.Name = "pnImages";
            pnImages.Padding = new Padding(0, 20, 0, 20);
            pnImages.Size = new Size(807, 762);
            pnImages.TabIndex = 8;
            // 
            // btnAddImage
            // 
            btnAddImage.BackgroundImage = Properties.Resources.bg_btnlogin;
            btnAddImage.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddImage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddImage.ForeColor = SystemColors.ButtonHighlight;
            btnAddImage.Location = new Point(692, 919);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(126, 45);
            btnAddImage.TabIndex = 2;
            btnAddImage.Text = "Thêm hình";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.bg_updateAccount;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(995, 79);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 9;
            btnSave.Text = "Chỉnh sửa";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.Location = new Point(873, 81);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(101, 40);
            btnNew.TabIndex = 10;
            btnNew.Text = "Chương mới";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Visible = false;
            btnNew.Click += btnNew_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_back_64;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(24, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbStt
            // 
            tbStt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbStt.Location = new Point(206, 25);
            tbStt.Name = "tbStt";
            tbStt.Size = new Size(34, 31);
            tbStt.TabIndex = 14;
            // 
            // btnDel
            // 
            btnDel.BackgroundImage = Properties.Resources.bg_search;
            btnDel.BackgroundImageLayout = ImageLayout.Stretch;
            btnDel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(1029, 22);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(86, 45);
            btnDel.TabIndex = 15;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Visible = false;
            btnDel.Click += btnDel_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_search;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tbTitle);
            panel1.Location = new Point(414, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 42);
            panel1.TabIndex = 16;
            // 
            // UCWriteImageStory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "UCWriteImageStory";
            Size = new Size(1460, 983);
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
