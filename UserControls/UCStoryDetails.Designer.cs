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
            btnPostCmt = new Button();
            txtNewComment = new RichTextBox();
            panel1 = new Panel();
            picStar5 = new PictureBox();
            picStar4 = new PictureBox();
            picStar3 = new PictureBox();
            picStar2 = new PictureBox();
            picStar1 = new PictureBox();
            picAvat = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbInforCmt = new Label();
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
            SuspendLayout();
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.BackColor = Color.Green;
            lbStatus.Font = new Font("Segoe UI", 10F);
            lbStatus.ForeColor = Color.White;
            lbStatus.Location = new Point(136, 81);
            lbStatus.Name = "lbStatus";
            lbStatus.Padding = new Padding(10, 2, 10, 2);
            lbStatus.Size = new Size(190, 36);
            lbStatus.TabIndex = 15;
            lbStatus.Text = "Đang cập nhật";
            lbStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            picImage.Image = Properties.Resources.temp_image_story;
            picImage.Location = new Point(50, 60);
            picImage.Name = "picImage";
            picImage.Size = new Size(450, 630);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 14;
            picImage.TabStop = false;
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbName.Location = new Point(3, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(976, 50);
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
            pnTitle.Location = new Point(530, 60);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(1618, 95);
            pnTitle.TabIndex = 14;
            // 
            // lbInfor
            // 
            lbInfor.BackColor = Color.Transparent;
            lbInfor.Font = new Font("Segoe UI", 8F);
            lbInfor.ForeColor = Color.Red;
            lbInfor.Location = new Point(985, 61);
            lbInfor.Name = "lbInfor";
            lbInfor.Size = new Size(630, 25);
            lbInfor.TabIndex = 24;
            lbInfor.Text = "Thêm vào danh sách đọc thành công!";
            lbInfor.TextAlign = ContentAlignment.MiddleLeft;
            lbInfor.Visible = false;
            // 
            // cbReadingList
            // 
            cbReadingList.FormattingEnabled = true;
            cbReadingList.Location = new Point(985, 9);
            cbReadingList.Name = "cbReadingList";
            cbReadingList.Size = new Size(350, 38);
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
            btnAddStoryIntoRL.Location = new Point(1341, 0);
            btnAddStoryIntoRL.Name = "btnAddStoryIntoRL";
            btnAddStoryIntoRL.Size = new Size(277, 61);
            btnAddStoryIntoRL.TabIndex = 22;
            btnAddStoryIntoRL.Text = "Thêm vào danh sách đọc ";
            btnAddStoryIntoRL.UseVisualStyleBackColor = false;
            btnAddStoryIntoRL.Click += btnAddStoryIntoRL_Click;
            // 
            // pnPrice
            // 
            pnPrice.Controls.Add(lbPrice);
            pnPrice.Controls.Add(pictureBox1);
            pnPrice.Location = new Point(129, 52);
            pnPrice.Name = "pnPrice";
            pnPrice.Size = new Size(150, 40);
            pnPrice.TabIndex = 14;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 11F);
            lbPrice.Location = new Point(42, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 36);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "3.5";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cost;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
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
            lbIsFree.Location = new Point(129, 53);
            lbIsFree.Name = "lbIsFree";
            lbIsFree.Padding = new Padding(10, 2, 10, 2);
            lbIsFree.Size = new Size(130, 36);
            lbIsFree.TabIndex = 21;
            lbIsFree.Text = "Miễn phí";
            lbIsFree.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnStar
            // 
            pnStar.Controls.Add(lbStar);
            pnStar.Controls.Add(picStar);
            pnStar.Location = new Point(21, 52);
            pnStar.Name = "pnStar";
            pnStar.Size = new Size(102, 40);
            pnStar.TabIndex = 13;
            // 
            // lbStar
            // 
            lbStar.AutoSize = true;
            lbStar.Font = new Font("Segoe UI", 11F);
            lbStar.Location = new Point(42, 0);
            lbStar.Name = "lbStar";
            lbStar.Size = new Size(49, 36);
            lbStar.TabIndex = 4;
            lbStar.Text = "3.5";
            // 
            // picStar
            // 
            picStar.BackColor = Color.Transparent;
            picStar.Image = Properties.Resources.star;
            picStar.Location = new Point(-2, 0);
            picStar.Name = "picStar";
            picStar.Size = new Size(40, 40);
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
            panel2.Location = new Point(555, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(1593, 555);
            panel2.TabIndex = 15;
            // 
            // lbType
            // 
            lbType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbType.ForeColor = Color.DarkGreen;
            lbType.Location = new Point(117, 40);
            lbType.Name = "lbType";
            lbType.Size = new Size(728, 36);
            lbType.TabIndex = 20;
            lbType.Text = "Ngôn tình";
            // 
            // lbDescription
            // 
            lbDescription.Font = new Font("Segoe UI", 11F);
            lbDescription.Location = new Point(0, 270);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(1590, 278);
            lbDescription.TabIndex = 19;
            lbDescription.Text = resources.GetString("lbDescription.Text");
            // 
            // lbLastUpdate
            // 
            lbLastUpdate.Font = new Font("Segoe UI", 11F);
            lbLastUpdate.ForeColor = Color.Black;
            lbLastUpdate.Location = new Point(130, 200);
            lbLastUpdate.Name = "lbLastUpdate";
            lbLastUpdate.Size = new Size(300, 36);
            lbLastUpdate.TabIndex = 18;
            lbLastUpdate.Text = "04/06/2024";
            // 
            // lbCreatedAt
            // 
            lbCreatedAt.Font = new Font("Segoe UI", 11F);
            lbCreatedAt.ForeColor = Color.Black;
            lbCreatedAt.Location = new Point(152, 160);
            lbCreatedAt.Name = "lbCreatedAt";
            lbCreatedAt.Size = new Size(300, 36);
            lbCreatedAt.TabIndex = 17;
            lbCreatedAt.Text = "04/06/2024";
            // 
            // lbNumberChapter
            // 
            lbNumberChapter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbNumberChapter.ForeColor = Color.Black;
            lbNumberChapter.Location = new Point(141, 119);
            lbNumberChapter.Name = "lbNumberChapter";
            lbNumberChapter.Size = new Size(185, 36);
            lbNumberChapter.TabIndex = 16;
            lbNumberChapter.Text = "40";
            // 
            // lbAuthor
            // 
            lbAuthor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbAuthor.ForeColor = Color.DarkGreen;
            lbAuthor.Location = new Point(104, 0);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(728, 36);
            lbAuthor.TabIndex = 13;
            lbAuthor.Text = "Nhớ mãi không quên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(0, 200);
            label6.Name = "label6";
            label6.Size = new Size(124, 36);
            label6.TabIndex = 5;
            label6.Text = "Cập nhật:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(0, 160);
            label5.Name = "label5";
            label5.Size = new Size(146, 36);
            label5.TabIndex = 4;
            label5.Text = "Ngày đăng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(0, 120);
            label4.Name = "label4";
            label4.Size = new Size(145, 36);
            label4.TabIndex = 3;
            label4.Text = "Số chương:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(0, 80);
            label3.Name = "label3";
            label3.Size = new Size(135, 36);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(0, 40);
            label2.Name = "label2";
            label2.Size = new Size(111, 36);
            label2.TabIndex = 1;
            label2.Text = "Thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 36);
            label1.TabIndex = 0;
            label1.Text = "Tác giả:";
            // 
            // flowChapter1
            // 
            flowChapter1.AutoScroll = true;
            flowChapter1.Location = new Point(50, 798);
            flowChapter1.Name = "flowChapter1";
            flowChapter1.Size = new Size(670, 650);
            flowChapter1.TabIndex = 16;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(50, 751);
            label7.Name = "label7";
            label7.Size = new Size(365, 44);
            label7.TabIndex = 14;
            label7.Text = "DANH SÁCH CHƯƠNG";
            // 
            // flowChapter2
            // 
            flowChapter2.AutoScroll = true;
            flowChapter2.Location = new Point(760, 798);
            flowChapter2.Name = "flowChapter2";
            flowChapter2.Size = new Size(670, 650);
            flowChapter2.TabIndex = 17;
            // 
            // flowComment
            // 
            flowComment.AutoScroll = true;
            flowComment.BackColor = Color.White;
            flowComment.Location = new Point(1475, 983);
            flowComment.Name = "flowComment";
            flowComment.Size = new Size(673, 465);
            flowComment.TabIndex = 18;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(1475, 751);
            label8.Name = "label8";
            label8.Size = new Size(365, 44);
            label8.TabIndex = 19;
            label8.Text = "ĐÁNH GIÁ";
            // 
            // pnNewComment
            // 
            pnNewComment.Controls.Add(btnPostCmt);
            pnNewComment.Controls.Add(txtNewComment);
            pnNewComment.Controls.Add(panel1);
            pnNewComment.Controls.Add(picAvat);
            pnNewComment.Location = new Point(1475, 810);
            pnNewComment.Name = "pnNewComment";
            pnNewComment.Size = new Size(673, 167);
            pnNewComment.TabIndex = 20;
            // 
            // btnPostCmt
            // 
            btnPostCmt.BackColor = Color.LightGreen;
            btnPostCmt.FlatStyle = FlatStyle.Flat;
            btnPostCmt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPostCmt.ForeColor = Color.DarkGreen;
            btnPostCmt.Location = new Point(545, 3);
            btnPostCmt.Name = "btnPostCmt";
            btnPostCmt.Size = new Size(128, 47);
            btnPostCmt.TabIndex = 16;
            btnPostCmt.Text = "Đăng";
            btnPostCmt.UseVisualStyleBackColor = false;
            btnPostCmt.Click += btnPostCmt_Click;
            // 
            // txtNewComment
            // 
            txtNewComment.Location = new Point(120, 56);
            txtNewComment.Name = "txtNewComment";
            txtNewComment.Size = new Size(550, 100);
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
            panel1.Location = new Point(120, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 40);
            panel1.TabIndex = 14;
            // 
            // picStar5
            // 
            picStar5.BackColor = Color.Transparent;
            picStar5.Image = Properties.Resources.star_gray;
            picStar5.Location = new Point(182, 0);
            picStar5.Name = "picStar5";
            picStar5.Size = new Size(40, 40);
            picStar5.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar5.TabIndex = 7;
            picStar5.TabStop = false;
            picStar5.Click += picStar5_Click;
            // 
            // picStar4
            // 
            picStar4.BackColor = Color.Transparent;
            picStar4.Image = Properties.Resources.star_gray;
            picStar4.Location = new Point(136, 0);
            picStar4.Name = "picStar4";
            picStar4.Size = new Size(40, 40);
            picStar4.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar4.TabIndex = 6;
            picStar4.TabStop = false;
            picStar4.Click += picStar4_Click;
            // 
            // picStar3
            // 
            picStar3.BackColor = Color.Transparent;
            picStar3.Image = Properties.Resources.star_gray;
            picStar3.Location = new Point(90, 0);
            picStar3.Name = "picStar3";
            picStar3.Size = new Size(40, 40);
            picStar3.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar3.TabIndex = 5;
            picStar3.TabStop = false;
            picStar3.Click += picStar3_Click;
            // 
            // picStar2
            // 
            picStar2.BackColor = Color.Transparent;
            picStar2.Image = Properties.Resources.star_gray;
            picStar2.Location = new Point(44, 0);
            picStar2.Name = "picStar2";
            picStar2.Size = new Size(40, 40);
            picStar2.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar2.TabIndex = 4;
            picStar2.TabStop = false;
            picStar2.Click += picStar2_Click;
            // 
            // picStar1
            // 
            picStar1.BackColor = Color.Transparent;
            picStar1.Image = Properties.Resources.star_gray;
            picStar1.Location = new Point(-2, 0);
            picStar1.Name = "picStar1";
            picStar1.Size = new Size(40, 40);
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
            picAvat.Name = "picAvat";
            picAvat.Size = new Size(100, 100);
            picAvat.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvat.TabIndex = 4;
            picAvat.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // lbInforCmt
            // 
            lbInforCmt.BackColor = Color.Transparent;
            lbInforCmt.Font = new Font("Segoe UI", 8F);
            lbInforCmt.ForeColor = Color.Red;
            lbInforCmt.Location = new Point(1884, 785);
            lbInforCmt.Name = "lbInforCmt";
            lbInforCmt.Size = new Size(274, 25);
            lbInforCmt.TabIndex = 25;
            lbInforCmt.Text = "Vui lòng chọn số sao đánh giá!";
            lbInforCmt.TextAlign = ContentAlignment.MiddleLeft;
            lbInforCmt.Visible = false;
            // 
            // UCStoryDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbInforCmt);
            Controls.Add(pnNewComment);
            Controls.Add(label8);
            Controls.Add(flowComment);
            Controls.Add(flowChapter2);
            Controls.Add(label7);
            Controls.Add(flowChapter1);
            Controls.Add(picImage);
            Controls.Add(panel2);
            Controls.Add(pnTitle);
            Name = "UCStoryDetails";
            Size = new Size(2190, 1475);
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
        private Button btnPostCmt;
        private Panel pnPrice;
        private Label lbPrice;
        private PictureBox pictureBox1;
        private ComboBox cbReadingList;
        private Button btnAddStoryIntoRL;
        private Label lbInfor;
        private System.Windows.Forms.Timer timer1;
        private Label lbInforCmt;
    }
}
