namespace ReadingApp.UserControls
{
    partial class UCHome
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
            picAvat = new PictureBox();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            pnType = new Panel();
            lbType = new Label();
            picType = new PictureBox();
            flowMain = new FlowLayoutPanel();
            pnLasted = new Panel();
            lbLastedAuthor5 = new Label();
            lbLastedName5 = new Label();
            lbLastedAuthor4 = new Label();
            lbLastedName4 = new Label();
            lbLastedAuthor3 = new Label();
            lbLastedName3 = new Label();
            lbLastedAuthor2 = new Label();
            lbLastedName2 = new Label();
            lbLastedAuthor1 = new Label();
            lbLastedName1 = new Label();
            label1 = new Label();
            pnSearch = new Panel();
            btnSearch = new Button();
            pnUpdating = new Panel();
            lbUpdating = new Label();
            picUpdating = new PictureBox();
            pnFull = new Panel();
            lbFull = new Label();
            picFull = new PictureBox();
            pnFee = new Panel();
            lbFee = new Label();
            picFee = new PictureBox();
            pnStory = new Panel();
            lbStory = new Label();
            picStory = new PictureBox();
            pnFree = new Panel();
            lbFree = new Label();
            picFree = new PictureBox();
            pnComic = new Panel();
            lbComic = new Label();
            picComic = new PictureBox();
            cbArrange = new ComboBox();
            cbType = new ComboBox();
            panelType = new Panel();
            lbTheLoai6 = new Label();
            lbTheLoai5 = new Label();
            lbBachHop = new Label();
            lbCungDau = new Label();
            lbCoTrang = new Label();
            lbNgonTinh = new Label();
            panelState = new Panel();
            pnStar = new Panel();
            lbStarAuthor4 = new Label();
            lbStarName4 = new Label();
            lbStarAuthor3 = new Label();
            lbStarName3 = new Label();
            lbStarAuthor2 = new Label();
            lbStarName2 = new Label();
            lbStarAuthor1 = new Label();
            lbStarName1 = new Label();
            label12 = new Label();
            pnOutstanding = new Panel();
            lbOutsAuthor4 = new Label();
            lbOutsName4 = new Label();
            lbOutsAuthor3 = new Label();
            lbOutsName3 = new Label();
            lbOutsAuthor2 = new Label();
            lbOutsName2 = new Label();
            lbOutsAuthor1 = new Label();
            lbOutsName1 = new Label();
            label22 = new Label();
            btnWrite = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvat).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picType).BeginInit();
            pnLasted.SuspendLayout();
            pnSearch.SuspendLayout();
            pnUpdating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUpdating).BeginInit();
            pnFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFull).BeginInit();
            pnFee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFee).BeginInit();
            pnStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStory).BeginInit();
            pnFree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFree).BeginInit();
            pnComic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picComic).BeginInit();
            panelType.SuspendLayout();
            panelState.SuspendLayout();
            pnStar.SuspendLayout();
            pnOutstanding.SuspendLayout();
            SuspendLayout();
            // 
            // picAvat
            // 
            picAvat.Image = Properties.Resources.image_user;
            picAvat.Location = new Point(1373, 20);
            picAvat.Margin = new Padding(2);
            picAvat.Name = "picAvat";
            picAvat.Size = new Size(60, 60);
            picAvat.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvat.TabIndex = 1;
            picAvat.TabStop = false;
            picAvat.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.bg_search;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(553, 27);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 47);
            panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(10, 11);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm tại đây...";
            txtSearch.Size = new Size(733, 27);
            txtSearch.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(763, 8);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pnType
            // 
            pnType.Controls.Add(lbType);
            pnType.Controls.Add(picType);
            pnType.Location = new Point(423, 33);
            pnType.Margin = new Padding(2);
            pnType.Name = "pnType";
            pnType.Size = new Size(113, 33);
            pnType.TabIndex = 3;
            pnType.Click += pnType_Click;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 12F);
            lbType.Location = new Point(28, 4);
            lbType.Margin = new Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(80, 28);
            lbType.TabIndex = 5;
            lbType.Text = "Thể loại";
            lbType.Click += pnType_Click;
            // 
            // picType
            // 
            picType.Image = Properties.Resources.type;
            picType.Location = new Point(3, 5);
            picType.Margin = new Padding(2);
            picType.Name = "picType";
            picType.Size = new Size(23, 23);
            picType.SizeMode = PictureBoxSizeMode.StretchImage;
            picType.TabIndex = 4;
            picType.TabStop = false;
            picType.Click += pnType_Click;
            // 
            // flowMain
            // 
            flowMain.AutoScroll = true;
            flowMain.Location = new Point(0, 100);
            flowMain.Margin = new Padding(2);
            flowMain.Name = "flowMain";
            flowMain.Size = new Size(1173, 883);
            flowMain.TabIndex = 4;
            // 
            // pnLasted
            // 
            pnLasted.BackgroundImage = Properties.Resources.bg_lasted;
            pnLasted.BackgroundImageLayout = ImageLayout.Stretch;
            pnLasted.Controls.Add(lbLastedAuthor5);
            pnLasted.Controls.Add(lbLastedName5);
            pnLasted.Controls.Add(lbLastedAuthor4);
            pnLasted.Controls.Add(lbLastedName4);
            pnLasted.Controls.Add(lbLastedAuthor3);
            pnLasted.Controls.Add(lbLastedName3);
            pnLasted.Controls.Add(lbLastedAuthor2);
            pnLasted.Controls.Add(lbLastedName2);
            pnLasted.Controls.Add(lbLastedAuthor1);
            pnLasted.Controls.Add(lbLastedName1);
            pnLasted.Controls.Add(label1);
            pnLasted.Location = new Point(0, 0);
            pnLasted.Margin = new Padding(2);
            pnLasted.Name = "pnLasted";
            pnLasted.Size = new Size(247, 270);
            pnLasted.TabIndex = 5;
            // 
            // lbLastedAuthor5
            // 
            lbLastedAuthor5.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor5.ForeColor = Color.Gray;
            lbLastedAuthor5.Location = new Point(13, 247);
            lbLastedAuthor5.Margin = new Padding(2, 0, 2, 0);
            lbLastedAuthor5.Name = "lbLastedAuthor5";
            lbLastedAuthor5.Size = new Size(220, 17);
            lbLastedAuthor5.TabIndex = 17;
            lbLastedAuthor5.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName5
            // 
            lbLastedName5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName5.Location = new Point(13, 223);
            lbLastedName5.Margin = new Padding(2, 0, 2, 0);
            lbLastedName5.Name = "lbLastedName5";
            lbLastedName5.Size = new Size(220, 27);
            lbLastedName5.TabIndex = 16;
            lbLastedName5.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor4
            // 
            lbLastedAuthor4.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor4.ForeColor = Color.Gray;
            lbLastedAuthor4.Location = new Point(13, 200);
            lbLastedAuthor4.Margin = new Padding(2, 0, 2, 0);
            lbLastedAuthor4.Name = "lbLastedAuthor4";
            lbLastedAuthor4.Size = new Size(220, 17);
            lbLastedAuthor4.TabIndex = 15;
            lbLastedAuthor4.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName4
            // 
            lbLastedName4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName4.Location = new Point(13, 177);
            lbLastedName4.Margin = new Padding(2, 0, 2, 0);
            lbLastedName4.Name = "lbLastedName4";
            lbLastedName4.Size = new Size(220, 27);
            lbLastedName4.TabIndex = 14;
            lbLastedName4.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor3
            // 
            lbLastedAuthor3.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor3.ForeColor = Color.Gray;
            lbLastedAuthor3.Location = new Point(13, 153);
            lbLastedAuthor3.Margin = new Padding(2, 0, 2, 0);
            lbLastedAuthor3.Name = "lbLastedAuthor3";
            lbLastedAuthor3.Size = new Size(220, 17);
            lbLastedAuthor3.TabIndex = 13;
            lbLastedAuthor3.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName3
            // 
            lbLastedName3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName3.Location = new Point(13, 130);
            lbLastedName3.Margin = new Padding(2, 0, 2, 0);
            lbLastedName3.Name = "lbLastedName3";
            lbLastedName3.Size = new Size(220, 27);
            lbLastedName3.TabIndex = 12;
            lbLastedName3.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor2
            // 
            lbLastedAuthor2.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor2.ForeColor = Color.Gray;
            lbLastedAuthor2.Location = new Point(13, 107);
            lbLastedAuthor2.Margin = new Padding(2, 0, 2, 0);
            lbLastedAuthor2.Name = "lbLastedAuthor2";
            lbLastedAuthor2.Size = new Size(220, 17);
            lbLastedAuthor2.TabIndex = 11;
            lbLastedAuthor2.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName2
            // 
            lbLastedName2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName2.Location = new Point(13, 83);
            lbLastedName2.Margin = new Padding(2, 0, 2, 0);
            lbLastedName2.Name = "lbLastedName2";
            lbLastedName2.Size = new Size(220, 27);
            lbLastedName2.TabIndex = 10;
            lbLastedName2.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor1
            // 
            lbLastedAuthor1.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor1.ForeColor = Color.Gray;
            lbLastedAuthor1.Location = new Point(13, 60);
            lbLastedAuthor1.Margin = new Padding(2, 0, 2, 0);
            lbLastedAuthor1.Name = "lbLastedAuthor1";
            lbLastedAuthor1.Size = new Size(220, 17);
            lbLastedAuthor1.TabIndex = 9;
            lbLastedAuthor1.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName1
            // 
            lbLastedName1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName1.Location = new Point(13, 37);
            lbLastedName1.Margin = new Padding(2, 0, 2, 0);
            lbLastedName1.Name = "lbLastedName1";
            lbLastedName1.Size = new Size(220, 27);
            lbLastedName1.TabIndex = 8;
            lbLastedName1.Text = "Nhớ mãi không quên";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(7, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 0;
            label1.Text = "Mới nhất";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnSearch
            // 
            pnSearch.BorderStyle = BorderStyle.FixedSingle;
            pnSearch.Controls.Add(btnSearch);
            pnSearch.Controls.Add(pnUpdating);
            pnSearch.Controls.Add(pnFull);
            pnSearch.Controls.Add(pnFee);
            pnSearch.Controls.Add(pnStory);
            pnSearch.Controls.Add(pnFree);
            pnSearch.Controls.Add(pnComic);
            pnSearch.Controls.Add(cbArrange);
            pnSearch.Controls.Add(cbType);
            pnSearch.Location = new Point(0, 80);
            pnSearch.Margin = new Padding(2);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(1462, 87);
            pnSearch.TabIndex = 6;
            pnSearch.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.ForestGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1279, 22);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 40);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm truyện";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnUpdating
            // 
            pnUpdating.Controls.Add(lbUpdating);
            pnUpdating.Controls.Add(picUpdating);
            pnUpdating.Location = new Point(909, 44);
            pnUpdating.Margin = new Padding(2);
            pnUpdating.Name = "pnUpdating";
            pnUpdating.Size = new Size(191, 27);
            pnUpdating.TabIndex = 9;
            pnUpdating.Click += pnUpdating_Click;
            // 
            // lbUpdating
            // 
            lbUpdating.AutoSize = true;
            lbUpdating.Font = new Font("Segoe UI", 10F);
            lbUpdating.Location = new Point(24, 3);
            lbUpdating.Margin = new Padding(2, 0, 2, 0);
            lbUpdating.Name = "lbUpdating";
            lbUpdating.Size = new Size(177, 23);
            lbUpdating.TabIndex = 5;
            lbUpdating.Text = "Truyện đang cập nhật";
            lbUpdating.Click += pnUpdating_Click;
            // 
            // picUpdating
            // 
            picUpdating.Image = Properties.Resources.check;
            picUpdating.Location = new Point(0, 3);
            picUpdating.Margin = new Padding(2);
            picUpdating.Name = "picUpdating";
            picUpdating.Size = new Size(20, 20);
            picUpdating.SizeMode = PictureBoxSizeMode.StretchImage;
            picUpdating.TabIndex = 4;
            picUpdating.TabStop = false;
            picUpdating.Click += pnUpdating_Click;
            // 
            // pnFull
            // 
            pnFull.Controls.Add(lbFull);
            pnFull.Controls.Add(picFull);
            pnFull.Location = new Point(909, 13);
            pnFull.Margin = new Padding(2);
            pnFull.Name = "pnFull";
            pnFull.Size = new Size(114, 27);
            pnFull.TabIndex = 8;
            pnFull.Click += pnFull_Click;
            // 
            // lbFull
            // 
            lbFull.AutoSize = true;
            lbFull.Font = new Font("Segoe UI", 10F);
            lbFull.Location = new Point(24, 3);
            lbFull.Margin = new Padding(2, 0, 2, 0);
            lbFull.Name = "lbFull";
            lbFull.Size = new Size(89, 23);
            lbFull.TabIndex = 5;
            lbFull.Text = "Truyện full";
            lbFull.Click += pnFull_Click;
            // 
            // picFull
            // 
            picFull.Image = Properties.Resources.check;
            picFull.Location = new Point(0, 3);
            picFull.Margin = new Padding(2);
            picFull.Name = "picFull";
            picFull.Size = new Size(20, 20);
            picFull.SizeMode = PictureBoxSizeMode.StretchImage;
            picFull.TabIndex = 4;
            picFull.TabStop = false;
            picFull.Click += pnFull_Click;
            // 
            // pnFee
            // 
            pnFee.Controls.Add(lbFee);
            pnFee.Controls.Add(picFee);
            pnFee.Location = new Point(1143, 44);
            pnFee.Margin = new Padding(2);
            pnFee.Name = "pnFee";
            pnFee.Size = new Size(85, 27);
            pnFee.TabIndex = 7;
            pnFee.Click += pnFee_Click;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Font = new Font("Segoe UI", 10F);
            lbFee.Location = new Point(24, 3);
            lbFee.Margin = new Padding(2, 0, 2, 0);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(60, 23);
            lbFee.TabIndex = 5;
            lbFee.Text = "Có phí";
            lbFee.Click += pnFee_Click;
            // 
            // picFee
            // 
            picFee.Image = Properties.Resources.check;
            picFee.Location = new Point(0, 3);
            picFee.Margin = new Padding(2);
            picFee.Name = "picFee";
            picFee.Size = new Size(20, 20);
            picFee.SizeMode = PictureBoxSizeMode.StretchImage;
            picFee.TabIndex = 4;
            picFee.TabStop = false;
            picFee.Click += pnFee_Click;
            // 
            // pnStory
            // 
            pnStory.Controls.Add(lbStory);
            pnStory.Controls.Add(picStory);
            pnStory.Location = new Point(743, 44);
            pnStory.Margin = new Padding(2);
            pnStory.Name = "pnStory";
            pnStory.Size = new Size(123, 27);
            pnStory.TabIndex = 5;
            pnStory.Click += pnStory_Click;
            // 
            // lbStory
            // 
            lbStory.AutoSize = true;
            lbStory.Font = new Font("Segoe UI", 10F);
            lbStory.Location = new Point(24, 3);
            lbStory.Margin = new Padding(2, 0, 2, 0);
            lbStory.Name = "lbStory";
            lbStory.Size = new Size(94, 23);
            lbStory.TabIndex = 5;
            lbStory.Text = "Truyện chữ";
            lbStory.Click += pnStory_Click;
            // 
            // picStory
            // 
            picStory.Image = Properties.Resources.check;
            picStory.Location = new Point(0, 3);
            picStory.Margin = new Padding(2);
            picStory.Name = "picStory";
            picStory.Size = new Size(20, 20);
            picStory.SizeMode = PictureBoxSizeMode.StretchImage;
            picStory.TabIndex = 4;
            picStory.TabStop = false;
            picStory.Click += pnStory_Click;
            // 
            // pnFree
            // 
            pnFree.Controls.Add(lbFree);
            pnFree.Controls.Add(picFree);
            pnFree.Location = new Point(1143, 13);
            pnFree.Margin = new Padding(2);
            pnFree.Name = "pnFree";
            pnFree.Size = new Size(102, 27);
            pnFree.TabIndex = 6;
            pnFree.Click += pnFree_Click;
            // 
            // lbFree
            // 
            lbFree.AutoSize = true;
            lbFree.Font = new Font("Segoe UI", 10F);
            lbFree.Location = new Point(24, 3);
            lbFree.Margin = new Padding(2, 0, 2, 0);
            lbFree.Name = "lbFree";
            lbFree.Size = new Size(77, 23);
            lbFree.TabIndex = 5;
            lbFree.Text = "Miễn phí";
            lbFree.Click += pnFree_Click;
            // 
            // picFree
            // 
            picFree.Image = Properties.Resources.check;
            picFree.Location = new Point(0, 3);
            picFree.Margin = new Padding(2);
            picFree.Name = "picFree";
            picFree.Size = new Size(20, 20);
            picFree.SizeMode = PictureBoxSizeMode.StretchImage;
            picFree.TabIndex = 4;
            picFree.TabStop = false;
            picFree.Click += pnFree_Click;
            // 
            // pnComic
            // 
            pnComic.Controls.Add(lbComic);
            pnComic.Controls.Add(picComic);
            pnComic.Location = new Point(743, 13);
            pnComic.Margin = new Padding(2);
            pnComic.Name = "pnComic";
            pnComic.Size = new Size(123, 27);
            pnComic.TabIndex = 4;
            pnComic.Click += pnComic_Click;
            // 
            // lbComic
            // 
            lbComic.AutoSize = true;
            lbComic.Font = new Font("Segoe UI", 10F);
            lbComic.Location = new Point(24, 3);
            lbComic.Margin = new Padding(2, 0, 2, 0);
            lbComic.Name = "lbComic";
            lbComic.Size = new Size(107, 23);
            lbComic.TabIndex = 5;
            lbComic.Text = "Truyện tranh";
            lbComic.Click += pnComic_Click;
            // 
            // picComic
            // 
            picComic.Image = Properties.Resources.check;
            picComic.Location = new Point(0, 3);
            picComic.Margin = new Padding(2);
            picComic.Name = "picComic";
            picComic.Size = new Size(20, 20);
            picComic.SizeMode = PictureBoxSizeMode.StretchImage;
            picComic.TabIndex = 4;
            picComic.TabStop = false;
            picComic.Click += pnComic_Click;
            // 
            // cbArrange
            // 
            cbArrange.Font = new Font("Segoe UI", 12F);
            cbArrange.ForeColor = Color.Gray;
            cbArrange.FormattingEnabled = true;
            cbArrange.ItemHeight = 28;
            cbArrange.Items.AddRange(new object[] { "Full", "Mới nhất", "Tác giả", "Tên truyện" });
            cbArrange.Location = new Point(387, 27);
            cbArrange.Margin = new Padding(2);
            cbArrange.Name = "cbArrange";
            cbArrange.Size = new Size(335, 36);
            cbArrange.Sorted = true;
            cbArrange.TabIndex = 1;
            cbArrange.Tag = "";
            cbArrange.Text = "Sắp xếp theo";
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 12F);
            cbType.ForeColor = Color.Gray;
            cbType.FormattingEnabled = true;
            cbType.ItemHeight = 28;
            cbType.Items.AddRange(new object[] { "Ngôn tình", "Cổ trang", "Bách hợp", "Cung đấu", "Thể loại 5", "Thể loại 6" });
            cbType.Location = new Point(23, 27);
            cbType.Margin = new Padding(2);
            cbType.Name = "cbType";
            cbType.Size = new Size(335, 36);
            cbType.TabIndex = 0;
            cbType.Tag = "";
            cbType.Text = "Thể loại 5";
            // 
            // panelType
            // 
            panelType.BackgroundImage = Properties.Resources.bg_search;
            panelType.BackgroundImageLayout = ImageLayout.Stretch;
            panelType.Controls.Add(lbTheLoai6);
            panelType.Controls.Add(lbTheLoai5);
            panelType.Controls.Add(lbBachHop);
            panelType.Controls.Add(lbCungDau);
            panelType.Controls.Add(lbCoTrang);
            panelType.Controls.Add(lbNgonTinh);
            panelType.Location = new Point(310, 67);
            panelType.Margin = new Padding(2);
            panelType.Name = "panelType";
            panelType.Size = new Size(233, 107);
            panelType.TabIndex = 7;
            panelType.Visible = false;
            // 
            // lbTheLoai6
            // 
            lbTheLoai6.Font = new Font("Segoe UI", 11F);
            lbTheLoai6.Location = new Point(131, 73);
            lbTheLoai6.Margin = new Padding(2, 0, 2, 0);
            lbTheLoai6.Name = "lbTheLoai6";
            lbTheLoai6.Size = new Size(93, 25);
            lbTheLoai6.TabIndex = 11;
            lbTheLoai6.Text = "Thể loại 6";
            lbTheLoai6.Click += lbTheLoai6_Click;
            lbTheLoai6.MouseLeave += lbTheLoai6_MouseLeave;
            lbTheLoai6.MouseHover += lbTheLoai6_MouseHover;
            // 
            // lbTheLoai5
            // 
            lbTheLoai5.Font = new Font("Segoe UI", 11F);
            lbTheLoai5.Location = new Point(131, 40);
            lbTheLoai5.Margin = new Padding(2, 0, 2, 0);
            lbTheLoai5.Name = "lbTheLoai5";
            lbTheLoai5.Size = new Size(93, 25);
            lbTheLoai5.TabIndex = 10;
            lbTheLoai5.Text = "Thể loại 5";
            lbTheLoai5.Click += lbTheLoai5_Click;
            lbTheLoai5.MouseLeave += lbTheLoai5_MouseLeave;
            lbTheLoai5.MouseHover += lbTheLoai5_MouseHover;
            // 
            // lbBachHop
            // 
            lbBachHop.Font = new Font("Segoe UI", 11F);
            lbBachHop.Location = new Point(131, 7);
            lbBachHop.Margin = new Padding(2, 0, 2, 0);
            lbBachHop.Name = "lbBachHop";
            lbBachHop.Size = new Size(83, 25);
            lbBachHop.TabIndex = 9;
            lbBachHop.Text = "Bách hợp";
            lbBachHop.Click += lbBachHop_Click;
            lbBachHop.MouseLeave += lbBachHop_MouseLeave;
            lbBachHop.MouseHover += lbBachHop_MouseHover;
            // 
            // lbCungDau
            // 
            lbCungDau.Font = new Font("Segoe UI", 11F);
            lbCungDau.Location = new Point(13, 73);
            lbCungDau.Margin = new Padding(2, 0, 2, 0);
            lbCungDau.Name = "lbCungDau";
            lbCungDau.Size = new Size(89, 25);
            lbCungDau.TabIndex = 8;
            lbCungDau.Text = "Cung đấu";
            lbCungDau.Click += lbCungDau_Click;
            lbCungDau.MouseLeave += lbCungDau_MouseLeave;
            lbCungDau.MouseHover += lbCungDau_MouseHover;
            // 
            // lbCoTrang
            // 
            lbCoTrang.Font = new Font("Segoe UI", 11F);
            lbCoTrang.Location = new Point(13, 40);
            lbCoTrang.Margin = new Padding(2, 0, 2, 0);
            lbCoTrang.Name = "lbCoTrang";
            lbCoTrang.Size = new Size(78, 25);
            lbCoTrang.TabIndex = 7;
            lbCoTrang.Text = "Cổ trang";
            lbCoTrang.Click += lbCoTrang_Click;
            lbCoTrang.MouseLeave += lbCoTrang_MouseLeave;
            lbCoTrang.MouseHover += lbCoTrang_MouseHover;
            // 
            // lbNgonTinh
            // 
            lbNgonTinh.Font = new Font("Segoe UI", 11F);
            lbNgonTinh.Location = new Point(13, 7);
            lbNgonTinh.Margin = new Padding(2, 0, 2, 0);
            lbNgonTinh.Name = "lbNgonTinh";
            lbNgonTinh.Size = new Size(89, 25);
            lbNgonTinh.TabIndex = 6;
            lbNgonTinh.Text = "Ngôn tình";
            lbNgonTinh.Click += lbNgonTinh_Click;
            lbNgonTinh.MouseLeave += lbNgonTinh_MouseLeave;
            lbNgonTinh.MouseHover += lbNgonTinh_MouseHover;
            // 
            // panelState
            // 
            panelState.Controls.Add(pnStar);
            panelState.Controls.Add(pnOutstanding);
            panelState.Controls.Add(pnLasted);
            panelState.Location = new Point(1187, 100);
            panelState.Margin = new Padding(2);
            panelState.Name = "panelState";
            panelState.Size = new Size(250, 773);
            panelState.TabIndex = 8;
            // 
            // pnStar
            // 
            pnStar.BackgroundImage = Properties.Resources.bg_lasted;
            pnStar.BackgroundImageLayout = ImageLayout.Stretch;
            pnStar.Controls.Add(lbStarAuthor4);
            pnStar.Controls.Add(lbStarName4);
            pnStar.Controls.Add(lbStarAuthor3);
            pnStar.Controls.Add(lbStarName3);
            pnStar.Controls.Add(lbStarAuthor2);
            pnStar.Controls.Add(lbStarName2);
            pnStar.Controls.Add(lbStarAuthor1);
            pnStar.Controls.Add(lbStarName1);
            pnStar.Controls.Add(label12);
            pnStar.Location = new Point(0, 550);
            pnStar.Margin = new Padding(2);
            pnStar.Name = "pnStar";
            pnStar.Size = new Size(247, 223);
            pnStar.TabIndex = 18;
            // 
            // lbStarAuthor4
            // 
            lbStarAuthor4.Font = new Font("Segoe UI", 8F);
            lbStarAuthor4.ForeColor = Color.Gray;
            lbStarAuthor4.Location = new Point(13, 200);
            lbStarAuthor4.Margin = new Padding(2, 0, 2, 0);
            lbStarAuthor4.Name = "lbStarAuthor4";
            lbStarAuthor4.Size = new Size(220, 17);
            lbStarAuthor4.TabIndex = 15;
            lbStarAuthor4.Text = "Thiên Hạ Thủy";
            // 
            // lbStarName4
            // 
            lbStarName4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbStarName4.Location = new Point(13, 177);
            lbStarName4.Margin = new Padding(2, 0, 2, 0);
            lbStarName4.Name = "lbStarName4";
            lbStarName4.Size = new Size(220, 27);
            lbStarName4.TabIndex = 14;
            lbStarName4.Text = "Nhớ mãi không quên";
            // 
            // lbStarAuthor3
            // 
            lbStarAuthor3.Font = new Font("Segoe UI", 8F);
            lbStarAuthor3.ForeColor = Color.Gray;
            lbStarAuthor3.Location = new Point(13, 153);
            lbStarAuthor3.Margin = new Padding(2, 0, 2, 0);
            lbStarAuthor3.Name = "lbStarAuthor3";
            lbStarAuthor3.Size = new Size(220, 17);
            lbStarAuthor3.TabIndex = 13;
            lbStarAuthor3.Text = "Thiên Hạ Thủy";
            // 
            // lbStarName3
            // 
            lbStarName3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbStarName3.Location = new Point(13, 130);
            lbStarName3.Margin = new Padding(2, 0, 2, 0);
            lbStarName3.Name = "lbStarName3";
            lbStarName3.Size = new Size(220, 27);
            lbStarName3.TabIndex = 12;
            lbStarName3.Text = "Nhớ mãi không quên";
            // 
            // lbStarAuthor2
            // 
            lbStarAuthor2.Font = new Font("Segoe UI", 8F);
            lbStarAuthor2.ForeColor = Color.Gray;
            lbStarAuthor2.Location = new Point(13, 107);
            lbStarAuthor2.Margin = new Padding(2, 0, 2, 0);
            lbStarAuthor2.Name = "lbStarAuthor2";
            lbStarAuthor2.Size = new Size(220, 17);
            lbStarAuthor2.TabIndex = 11;
            lbStarAuthor2.Text = "Thiên Hạ Thủy";
            // 
            // lbStarName2
            // 
            lbStarName2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbStarName2.Location = new Point(13, 83);
            lbStarName2.Margin = new Padding(2, 0, 2, 0);
            lbStarName2.Name = "lbStarName2";
            lbStarName2.Size = new Size(220, 27);
            lbStarName2.TabIndex = 10;
            lbStarName2.Text = "Nhớ mãi không quên";
            // 
            // lbStarAuthor1
            // 
            lbStarAuthor1.Font = new Font("Segoe UI", 8F);
            lbStarAuthor1.ForeColor = Color.Gray;
            lbStarAuthor1.Location = new Point(13, 60);
            lbStarAuthor1.Margin = new Padding(2, 0, 2, 0);
            lbStarAuthor1.Name = "lbStarAuthor1";
            lbStarAuthor1.Size = new Size(220, 17);
            lbStarAuthor1.TabIndex = 9;
            lbStarAuthor1.Text = "Thiên Hạ Thủy";
            // 
            // lbStarName1
            // 
            lbStarName1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbStarName1.Location = new Point(13, 37);
            lbStarName1.Margin = new Padding(2, 0, 2, 0);
            lbStarName1.Name = "lbStarName1";
            lbStarName1.Size = new Size(220, 27);
            lbStarName1.TabIndex = 8;
            lbStarName1.Text = "Nhớ mãi không quên";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(7, 5);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(233, 25);
            label12.TabIndex = 0;
            label12.Text = "Đánh giá cao";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnOutstanding
            // 
            pnOutstanding.BackgroundImage = Properties.Resources.bg_lasted;
            pnOutstanding.BackgroundImageLayout = ImageLayout.Stretch;
            pnOutstanding.Controls.Add(lbOutsAuthor4);
            pnOutstanding.Controls.Add(lbOutsName4);
            pnOutstanding.Controls.Add(lbOutsAuthor3);
            pnOutstanding.Controls.Add(lbOutsName3);
            pnOutstanding.Controls.Add(lbOutsAuthor2);
            pnOutstanding.Controls.Add(lbOutsName2);
            pnOutstanding.Controls.Add(lbOutsAuthor1);
            pnOutstanding.Controls.Add(lbOutsName1);
            pnOutstanding.Controls.Add(label22);
            pnOutstanding.Location = new Point(0, 300);
            pnOutstanding.Margin = new Padding(2);
            pnOutstanding.Name = "pnOutstanding";
            pnOutstanding.Size = new Size(247, 223);
            pnOutstanding.TabIndex = 6;
            // 
            // lbOutsAuthor4
            // 
            lbOutsAuthor4.Font = new Font("Segoe UI", 8F);
            lbOutsAuthor4.ForeColor = Color.Gray;
            lbOutsAuthor4.Location = new Point(13, 200);
            lbOutsAuthor4.Margin = new Padding(2, 0, 2, 0);
            lbOutsAuthor4.Name = "lbOutsAuthor4";
            lbOutsAuthor4.Size = new Size(220, 17);
            lbOutsAuthor4.TabIndex = 15;
            lbOutsAuthor4.Text = "Thiên Hạ Thủy";
            // 
            // lbOutsName4
            // 
            lbOutsName4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbOutsName4.Location = new Point(13, 177);
            lbOutsName4.Margin = new Padding(2, 0, 2, 0);
            lbOutsName4.Name = "lbOutsName4";
            lbOutsName4.Size = new Size(220, 27);
            lbOutsName4.TabIndex = 14;
            lbOutsName4.Text = "Nhớ mãi không quên";
            // 
            // lbOutsAuthor3
            // 
            lbOutsAuthor3.Font = new Font("Segoe UI", 8F);
            lbOutsAuthor3.ForeColor = Color.Gray;
            lbOutsAuthor3.Location = new Point(13, 153);
            lbOutsAuthor3.Margin = new Padding(2, 0, 2, 0);
            lbOutsAuthor3.Name = "lbOutsAuthor3";
            lbOutsAuthor3.Size = new Size(220, 17);
            lbOutsAuthor3.TabIndex = 13;
            lbOutsAuthor3.Text = "Thiên Hạ Thủy";
            // 
            // lbOutsName3
            // 
            lbOutsName3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbOutsName3.Location = new Point(13, 130);
            lbOutsName3.Margin = new Padding(2, 0, 2, 0);
            lbOutsName3.Name = "lbOutsName3";
            lbOutsName3.Size = new Size(220, 27);
            lbOutsName3.TabIndex = 12;
            lbOutsName3.Text = "Nhớ mãi không quên";
            // 
            // lbOutsAuthor2
            // 
            lbOutsAuthor2.Font = new Font("Segoe UI", 8F);
            lbOutsAuthor2.ForeColor = Color.Gray;
            lbOutsAuthor2.Location = new Point(13, 107);
            lbOutsAuthor2.Margin = new Padding(2, 0, 2, 0);
            lbOutsAuthor2.Name = "lbOutsAuthor2";
            lbOutsAuthor2.Size = new Size(220, 17);
            lbOutsAuthor2.TabIndex = 11;
            lbOutsAuthor2.Text = "Thiên Hạ Thủy";
            // 
            // lbOutsName2
            // 
            lbOutsName2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbOutsName2.Location = new Point(13, 83);
            lbOutsName2.Margin = new Padding(2, 0, 2, 0);
            lbOutsName2.Name = "lbOutsName2";
            lbOutsName2.Size = new Size(220, 27);
            lbOutsName2.TabIndex = 10;
            lbOutsName2.Text = "Nhớ mãi không quên";
            // 
            // lbOutsAuthor1
            // 
            lbOutsAuthor1.Font = new Font("Segoe UI", 8F);
            lbOutsAuthor1.ForeColor = Color.Gray;
            lbOutsAuthor1.Location = new Point(13, 60);
            lbOutsAuthor1.Margin = new Padding(2, 0, 2, 0);
            lbOutsAuthor1.Name = "lbOutsAuthor1";
            lbOutsAuthor1.Size = new Size(220, 17);
            lbOutsAuthor1.TabIndex = 9;
            lbOutsAuthor1.Text = "Thiên Hạ Thủy";
            // 
            // lbOutsName1
            // 
            lbOutsName1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbOutsName1.Location = new Point(13, 37);
            lbOutsName1.Margin = new Padding(2, 0, 2, 0);
            lbOutsName1.Name = "lbOutsName1";
            lbOutsName1.Size = new Size(220, 27);
            lbOutsName1.TabIndex = 8;
            lbOutsName1.Text = "Nhớ mãi không quên";
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label22.ForeColor = Color.DarkGreen;
            label22.Location = new Point(7, 5);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(233, 25);
            label22.TabIndex = 0;
            label22.Text = "Nổi bật";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWrite
            // 
            btnWrite.BackgroundImage = Properties.Resources.bg_updateAccount;
            btnWrite.BackgroundImageLayout = ImageLayout.Stretch;
            btnWrite.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.ForeColor = SystemColors.ButtonHighlight;
            btnWrite.Location = new Point(24, 24);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(116, 46);
            btnWrite.TabIndex = 9;
            btnWrite.Text = "Viết truyện";
            btnWrite.UseVisualStyleBackColor = true;
            // 
            // UCHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnWrite);
            Controls.Add(panelState);
            Controls.Add(panelType);
            Controls.Add(pnSearch);
            Controls.Add(flowMain);
            Controls.Add(pnType);
            Controls.Add(panel1);
            Controls.Add(picAvat);
            Margin = new Padding(2);
            Name = "UCHome";
            Size = new Size(1460, 983);
            Load += UCHome_Load;
            ((System.ComponentModel.ISupportInitialize)picAvat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnType.ResumeLayout(false);
            pnType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picType).EndInit();
            pnLasted.ResumeLayout(false);
            pnSearch.ResumeLayout(false);
            pnUpdating.ResumeLayout(false);
            pnUpdating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUpdating).EndInit();
            pnFull.ResumeLayout(false);
            pnFull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFull).EndInit();
            pnFee.ResumeLayout(false);
            pnFee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFee).EndInit();
            pnStory.ResumeLayout(false);
            pnStory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStory).EndInit();
            pnFree.ResumeLayout(false);
            pnFree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFree).EndInit();
            pnComic.ResumeLayout(false);
            pnComic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picComic).EndInit();
            panelType.ResumeLayout(false);
            panelState.ResumeLayout(false);
            pnStar.ResumeLayout(false);
            pnOutstanding.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picAvat;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox2;
        private Panel pnType;
        private Label lbType;
        private PictureBox picType;
        private FlowLayoutPanel flowMain;
        private Panel pnLasted;
        private Label label1;
        private Label lbLastedAuthor1;
        private Label lbLastedName1;
        private Label lbLastedAuthor4;
        private Label lbLastedName4;
        private Label lbLastedAuthor3;
        private Label lbLastedName3;
        private Label lbLastedAuthor2;
        private Label lbLastedName2;
        private Panel pnSearch;
        private ComboBox cbType;
        private ComboBox cbArrange;
        private Panel pnComic;
        private Label lbComic;
        private PictureBox picComic;
        private Panel pnStory;
        private Label lbStory;
        private PictureBox picStory;
        private Panel pnUpdating;
        private Label lbUpdating;
        private PictureBox picUpdating;
        private Panel pnFull;
        private Label lbFull;
        private PictureBox picFull;
        private Panel pnFee;
        private Label lbFee;
        private PictureBox picFee;
        private Panel pnFree;
        private Label lbFree;
        private PictureBox picFree;
        private Button btnSearch;
        private Panel panelType;
        private Label lbTheLoai6;
        private Label lbTheLoai5;
        private Label lbBachHop;
        private Label lbCungDau;
        private Label lbCoTrang;
        private Label lbNgonTinh;
        private Panel panelState;
        private Panel pnOutstanding;
        private Label lbOutsAuthor4;
        private Label lbOutsName4;
        private Label lbOutsAuthor3;
        private Label lbOutsName3;
        private Label lbOutsAuthor2;
        private Label lbOutsName2;
        private Label lbOutsAuthor1;
        private Label lbOutsName1;
        private Label label22;
        private Panel pnStar;
        private Label lbStarAuthor4;
        private Label lbStarName4;
        private Label lbStarAuthor3;
        private Label lbStarName3;
        private Label lbStarAuthor2;
        private Label lbStarName2;
        private Label lbStarAuthor1;
        private Label lbStarName1;
        private Label label12;
        private Label lbLastedAuthor5;
        private Label lbLastedName5;
        private Button btnWrite;
    }
}
