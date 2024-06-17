namespace ReadingApp.UserControls
{
    partial class UCStoryDetails
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStoryDetails));
            lbStatus = new Label();
            picImage = new PictureBox();
            lbName = new Label();
            pnTitle = new Panel();
            lbInfor = new Label();
            cbReadingList = new ComboBox();
            btnAddStoryIntoRL = new Button();
            pnPrice = new Panel();
            lbPrice = new Label();
            pictureBox1 = new PictureBox();
            lbIsFree = new Label();
            pnStar = new Panel();
            lbStar = new Label();
            picStar = new PictureBox();
            panel2 = new Panel();
            lbType = new Label();
            lbDescription = new Label();
            lbLastUpdate = new Label();
            lbCreatedAt = new Label();
            lbNumberChapter = new Label();
            lbAuthor = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowChapter1 = new FlowLayoutPanel();
            label7 = new Label();
            flowChapter2 = new FlowLayoutPanel();
            flowComment = new FlowLayoutPanel();
            label8 = new Label();
            pnNewComment = new Panel();
            btnSearch = new Button();
            txtNewComment = new RichTextBox();
            panel1 = new Panel();
            picStar5 = new PictureBox();
            picStar4 = new PictureBox();
            picStar3 = new PictureBox();
            picStar2 = new PictureBox();
            picStar1 = new PictureBox();
            picAvat = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pcAddChapter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnTitle.SuspendLayout();
            pnPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).BeginInit();
            panel2.SuspendLayout();
            pnNewComment.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcAddChapter).BeginInit();
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.BackColor = Color.Green;
            lbStatus.Font = new Font("Segoe UI", 10F);
            lbStatus.ForeColor = Color.White;
            lbStatus.Location = new Point(91, 54);
            lbStatus.Margin = new Padding(2, 0, 2, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Padding = new Padding(7, 1, 7, 1);
            lbStatus.Size = new Size(137, 25);
            lbStatus.TabIndex = 15;
            lbStatus.Text = "Đang cập nhật";
            lbStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            picImage.Image = Properties.Resources.temp_image_story;
            picImage.Location = new Point(33, 40);
            picImage.Margin = new Padding(2);
            picImage.Name = "picImage";
            picImage.Size = new Size(300, 420);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 14;
            picImage.TabStop = false;
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbName.Location = new Point(2, 0);
            lbName.Margin = new Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(651, 33);
            lbName.TabIndex = 12;
            lbName.Text = "Nhớ mãi không quên";
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(lbInfor);
            pnTitle.Controls.Add(cbReadingList);
            pnTitle.Controls.Add(btnAddStoryIntoRL);
            pnTitle.Controls.Add(pnPrice);
            pnTitle.Controls.Add(lbIsFree);
            pnTitle.Controls.Add(pnStar);
            pnTitle.Controls.Add(lbName);
            pnTitle.Location = new Point(353, 40);
            pnTitle.Margin = new Padding(2);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(1079, 63);
            pnTitle.TabIndex = 14;
            // 
            // lbInfor
            // 
            lbInfor.BackColor = Color.Transparent;
            lbInfor.Font = new Font("Segoe UI", 8F);
            lbInfor.ForeColor = Color.Red;
            lbInfor.Location = new Point(657, 41);
            lbInfor.Margin = new Padding(2, 0, 2, 0);
            lbInfor.Name = "lbInfor";
            lbInfor.Size = new Size(420, 17);
            lbInfor.TabIndex = 24;
            lbInfor.Text = "Thêm vào danh sách đọc thành công!";
            lbInfor.TextAlign = ContentAlignment.MiddleLeft;
            lbInfor.Visible = false;
            // 
            // cbReadingList
            // 
            cbReadingList.FormattingEnabled = true;
            cbReadingList.Location = new Point(657, 6);
            cbReadingList.Margin = new Padding(2);
            cbReadingList.Name = "cbReadingList";
            cbReadingList.Size = new Size(235, 28);
            cbReadingList.TabIndex = 23;
            cbReadingList.Visible = false;
            cbReadingList.SelectedIndexChanged += cbReadingList_SelectedIndexChanged;
            // 
            // btnAddStoryIntoRL
            // 
            btnAddStoryIntoRL.BackColor = Color.ForestGreen;
            btnAddStoryIntoRL.FlatStyle = FlatStyle.Flat;
            btnAddStoryIntoRL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddStoryIntoRL.ForeColor = Color.White;
            btnAddStoryIntoRL.Location = new Point(894, 0);
            btnAddStoryIntoRL.Margin = new Padding(2);
            btnAddStoryIntoRL.Name = "btnAddStoryIntoRL";
            btnAddStoryIntoRL.Size = new Size(185, 41);
            btnAddStoryIntoRL.TabIndex = 22;
            btnAddStoryIntoRL.Text = "Thêm vào danh sách đọc ";
            btnAddStoryIntoRL.UseVisualStyleBackColor = false;
            btnAddStoryIntoRL.Click += btnAddStoryIntoRL_Click;
            // 
            // pnPrice
            // 
            pnPrice.Controls.Add(lbPrice);
            pnPrice.Controls.Add(pictureBox1);
            pnPrice.Location = new Point(86, 35);
            pnPrice.Margin = new Padding(2);
            pnPrice.Name = "pnPrice";
            pnPrice.Size = new Size(100, 27);
            pnPrice.TabIndex = 14;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 11F);
            lbPrice.Location = new Point(28, 0);
            lbPrice.Margin = new Padding(2, 0, 2, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(36, 25);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "3.5";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cost;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbIsFree
            // 
            lbIsFree.AutoSize = true;
            lbIsFree.BackColor = Color.Green;
            lbIsFree.Font = new Font("Segoe UI", 10F);
            lbIsFree.ForeColor = Color.White;
            lbIsFree.Location = new Point(86, 35);
            lbIsFree.Margin = new Padding(2, 0, 2, 0);
            lbIsFree.Name = "lbIsFree";
            lbIsFree.Padding = new Padding(7, 1, 7, 1);
            lbIsFree.Size = new Size(91, 25);
            lbIsFree.TabIndex = 21;
            lbIsFree.Text = "Miễn phí";
            lbIsFree.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnStar
            // 
            pnStar.Controls.Add(lbStar);
            pnStar.Controls.Add(picStar);
            pnStar.Location = new Point(14, 35);
            pnStar.Margin = new Padding(2);
            pnStar.Name = "pnStar";
            pnStar.Size = new Size(68, 27);
            pnStar.TabIndex = 13;
            // 
            // lbStar
            // 
            lbStar.AutoSize = true;
            lbStar.Font = new Font("Segoe UI", 11F);
            lbStar.Location = new Point(28, 0);
            lbStar.Margin = new Padding(2, 0, 2, 0);
            lbStar.Name = "lbStar";
            lbStar.Size = new Size(36, 25);
            lbStar.TabIndex = 4;
            lbStar.Text = "3.5";
            // 
            // picStar
            // 
            picStar.BackColor = Color.Transparent;
            picStar.Image = Properties.Resources.star;
            picStar.Location = new Point(-1, 0);
            picStar.Margin = new Padding(2);
            picStar.Name = "picStar";
            picStar.Size = new Size(27, 27);
            picStar.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar.TabIndex = 3;
            picStar.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbType);
            panel2.Controls.Add(lbDescription);
            panel2.Controls.Add(lbLastUpdate);
            panel2.Controls.Add(lbCreatedAt);
            panel2.Controls.Add(lbNumberChapter);
            panel2.Controls.Add(lbStatus);
            panel2.Controls.Add(lbAuthor);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(370, 124);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1062, 370);
            panel2.TabIndex = 15;
            // 
            // lbType
            // 
            lbType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbType.ForeColor = Color.DarkGreen;
            lbType.Location = new Point(78, 27);
            lbType.Margin = new Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(485, 24);
            lbType.TabIndex = 20;
            lbType.Text = "Ngôn tình";
            // 
            // lbDescription
            // 
            lbDescription.Font = new Font("Segoe UI", 11F);
            lbDescription.Location = new Point(0, 180);
            lbDescription.Margin = new Padding(2, 0, 2, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(1060, 185);
            lbDescription.TabIndex = 19;
            lbDescription.Text = resources.GetString("lbDescription.Text");
            // 
            // lbLastUpdate
            // 
            lbLastUpdate.Font = new Font("Segoe UI", 11F);
            lbLastUpdate.ForeColor = Color.Black;
            lbLastUpdate.Location = new Point(87, 133);
            lbLastUpdate.Margin = new Padding(2, 0, 2, 0);
            lbLastUpdate.Name = "lbLastUpdate";
            lbLastUpdate.Size = new Size(200, 24);
            lbLastUpdate.TabIndex = 18;
            lbLastUpdate.Text = "04/06/2024";
            // 
            // lbCreatedAt
            // 
            lbCreatedAt.Font = new Font("Segoe UI", 11F);
            lbCreatedAt.ForeColor = Color.Black;
            lbCreatedAt.Location = new Point(101, 107);
            lbCreatedAt.Margin = new Padding(2, 0, 2, 0);
            lbCreatedAt.Name = "lbCreatedAt";
            lbCreatedAt.Size = new Size(200, 24);
            lbCreatedAt.TabIndex = 17;
            lbCreatedAt.Text = "04/06/2024";
            // 
            // lbNumberChapter
            // 
            lbNumberChapter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbNumberChapter.ForeColor = Color.Black;
            lbNumberChapter.Location = new Point(94, 79);
            lbNumberChapter.Margin = new Padding(2, 0, 2, 0);
            lbNumberChapter.Name = "lbNumberChapter";
            lbNumberChapter.Size = new Size(123, 24);
            lbNumberChapter.TabIndex = 16;
            lbNumberChapter.Text = "40";
            // 
            // lbAuthor
            // 
            lbAuthor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbAuthor.ForeColor = Color.DarkGreen;
            lbAuthor.Location = new Point(69, 0);
            lbAuthor.Margin = new Padding(2, 0, 2, 0);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(485, 24);
            lbAuthor.TabIndex = 13;
            lbAuthor.Text = "Nhớ mãi không quên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(0, 133);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 5;
            label6.Text = "Cập nhật:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(0, 107);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 4;
            label5.Text = "Ngày đăng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(0, 80);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 3;
            label4.Text = "Số chương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(0, 53);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(0, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 1;
            label2.Text = "Thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Tác giả:";
            // 
            // flowChapter1
            // 
            flowChapter1.AutoScroll = true;
            flowChapter1.Location = new Point(33, 535);
            flowChapter1.Margin = new Padding(2);
            flowChapter1.Name = "flowChapter1";
            flowChapter1.Size = new Size(440, 425);
            flowChapter1.TabIndex = 16;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(33, 501);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(243, 29);
            label7.TabIndex = 14;
            label7.Text = "DANH SÁCH CHƯƠNG";
            // 
            // flowChapter2
            // 
            flowChapter2.AutoScroll = true;
            flowChapter2.Location = new Point(507, 535);
            flowChapter2.Margin = new Padding(2);
            flowChapter2.Name = "flowChapter2";
            flowChapter2.Size = new Size(440, 425);
            flowChapter2.TabIndex = 17;
            // 
            // flowComment
            // 
            flowComment.AutoScroll = true;
            flowComment.BackColor = Color.White;
            flowComment.Location = new Point(983, 655);
            flowComment.Margin = new Padding(2);
            flowComment.Name = "flowComment";
            flowComment.Size = new Size(449, 310);
            flowComment.TabIndex = 18;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(983, 501);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(243, 29);
            label8.TabIndex = 19;
            label8.Text = "ĐÁNH GIÁ";
            // 
            // pnNewComment
            // 
            pnNewComment.Controls.Add(btnSearch);
            pnNewComment.Controls.Add(txtNewComment);
            pnNewComment.Controls.Add(panel1);
            pnNewComment.Controls.Add(picAvat);
            pnNewComment.Location = new Point(983, 540);
            pnNewComment.Margin = new Padding(2);
            pnNewComment.Name = "pnNewComment";
            pnNewComment.Size = new Size(449, 111);
            pnNewComment.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.DarkGreen;
            btnSearch.Location = new Point(363, 2);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Đăng";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtNewComment
            // 
            txtNewComment.Location = new Point(80, 37);
            txtNewComment.Margin = new Padding(2);
            txtNewComment.Name = "txtNewComment";
            txtNewComment.Size = new Size(368, 68);
            txtNewComment.TabIndex = 15;
            txtNewComment.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(picStar5);
            panel1.Controls.Add(picStar4);
            panel1.Controls.Add(picStar3);
            panel1.Controls.Add(picStar2);
            panel1.Controls.Add(picStar1);
            panel1.Location = new Point(80, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 27);
            panel1.TabIndex = 14;
            // 
            // picStar5
            // 
            picStar5.BackColor = Color.Transparent;
            picStar5.Image = Properties.Resources.star_gray;
            picStar5.Location = new Point(121, 0);
            picStar5.Margin = new Padding(2);
            picStar5.Name = "picStar5";
            picStar5.Size = new Size(27, 27);
            picStar5.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar5.TabIndex = 7;
            picStar5.TabStop = false;
            picStar5.Click += picStar5_Click;
            // 
            // picStar4
            // 
            picStar4.BackColor = Color.Transparent;
            picStar4.Image = Properties.Resources.star_gray;
            picStar4.Location = new Point(91, 0);
            picStar4.Margin = new Padding(2);
            picStar4.Name = "picStar4";
            picStar4.Size = new Size(27, 27);
            picStar4.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar4.TabIndex = 6;
            picStar4.TabStop = false;
            picStar4.Click += picStar4_Click;
            // 
            // picStar3
            // 
            picStar3.BackColor = Color.Transparent;
            picStar3.Image = Properties.Resources.star_gray;
            picStar3.Location = new Point(60, 0);
            picStar3.Margin = new Padding(2);
            picStar3.Name = "picStar3";
            picStar3.Size = new Size(27, 27);
            picStar3.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar3.TabIndex = 5;
            picStar3.TabStop = false;
            picStar3.Click += picStar3_Click;
            // 
            // picStar2
            // 
            picStar2.BackColor = Color.Transparent;
            picStar2.Image = Properties.Resources.star_gray;
            picStar2.Location = new Point(29, 0);
            picStar2.Margin = new Padding(2);
            picStar2.Name = "picStar2";
            picStar2.Size = new Size(27, 27);
            picStar2.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar2.TabIndex = 4;
            picStar2.TabStop = false;
            picStar2.Click += picStar2_Click;
            // 
            // picStar1
            // 
            picStar1.BackColor = Color.Transparent;
            picStar1.Image = Properties.Resources.star_gray;
            picStar1.Location = new Point(-1, 0);
            picStar1.Margin = new Padding(2);
            picStar1.Name = "picStar1";
            picStar1.Size = new Size(27, 27);
            picStar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar1.TabIndex = 3;
            picStar1.TabStop = false;
            picStar1.Click += picStar1_Click;
            // 
            // picAvat
            // 
            picAvat.BackColor = Color.Transparent;
            picAvat.Image = Properties.Resources.avat_default;
            picAvat.Location = new Point(0, 0);
            picAvat.Margin = new Padding(2);
            picAvat.Name = "picAvat";
            picAvat.Size = new Size(67, 67);
            picAvat.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvat.TabIndex = 4;
            picAvat.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // pcAddChapter
            // 
            pcAddChapter.BackgroundImage = Properties.Resources.icons8_add_48;
            pcAddChapter.BackgroundImageLayout = ImageLayout.Stretch;
            pcAddChapter.Location = new Point(182, 490);
            pcAddChapter.Name = "pcAddChapter";
            pcAddChapter.Size = new Size(40, 40);
            pcAddChapter.TabIndex = 21;
            pcAddChapter.TabStop = false;
            pcAddChapter.Visible = false;
            // 
            // UCStoryDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pcAddChapter);
            Controls.Add(pnNewComment);
            Controls.Add(label8);
            Controls.Add(flowComment);
            Controls.Add(flowChapter2);
            Controls.Add(label7);
            Controls.Add(flowChapter1);
            Controls.Add(picImage);
            Controls.Add(panel2);
            Controls.Add(pnTitle);
            Margin = new Padding(2);
            Name = "UCStoryDetails";
            Size = new Size(1460, 983);
            Load += UCStoryDetails_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            pnPrice.ResumeLayout(false);
            pnPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnStar.ResumeLayout(false);
            pnStar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnNewComment.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcAddChapter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnNewComment;
        private Label lbName;
        private Label lbStatus;
        private PictureBox picImage;
        private Panel pnTitle;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lbAuthor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lbNumberChapter;
        private Label lbLastUpdate;
        private Label lbCreatedAt;
        private Panel pnStar;
        private PictureBox picStar;
        private Label lbDescription;
        private Label lbStar;
        private Label lbType;
        private FlowLayoutPanel flowChapter1;
        private Label label7;
        private Label lbIsFree;
        private FlowLayoutPanel flowChapter2;
        private FlowLayoutPanel flowComment;
        private Label label8;
        private Panel panel1;
        private PictureBox picStar1;
        private PictureBox picAvat;
        private PictureBox picStar5;
        private PictureBox picStar4;
        private PictureBox picStar3;
        private PictureBox picStar2;
        private RichTextBox txtNewComment;
        private Button btnSearch;
        private Panel pnPrice;
        private Label lbPrice;
        private PictureBox pictureBox1;
        private ComboBox cbReadingList;
        private Button btnAddStoryIntoRL;
        private Label lbInfor;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pcAddChapter;
    }
}
