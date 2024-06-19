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
            flowLasted = new FlowLayoutPanel();
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
            cbArrange = new ComboBox();
            pnComic = new Panel();
            lbComic = new Label();
            picComic = new PictureBox();
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
            flowStar = new FlowLayoutPanel();
            label12 = new Label();
            pnOutstanding = new Panel();
            flowOuts = new FlowLayoutPanel();
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
            picAvat.Location = new Point(2060, 30);
            picAvat.Name = "picAvat";
            picAvat.Size = new Size(90, 90);
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
            panel1.Location = new Point(830, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 70);
            panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(15, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm tại đây...";
            txtSearch.Size = new Size(1100, 38);
            txtSearch.TabIndex = 4;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1144, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pnType
            // 
            pnType.Controls.Add(lbType);
            pnType.Controls.Add(picType);
            pnType.Location = new Point(634, 50);
            pnType.Name = "pnType";
            pnType.Size = new Size(170, 50);
            pnType.TabIndex = 3;
            pnType.Click += pnType_Click;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 12F);
            lbType.Location = new Point(42, 6);
            lbType.Name = "lbType";
            lbType.Size = new Size(115, 38);
            lbType.TabIndex = 5;
            lbType.Text = "Thể loại";
            lbType.Click += pnType_Click;
            // 
            // picType
            // 
            picType.Image = Properties.Resources.type;
            picType.Location = new Point(4, 8);
            picType.Name = "picType";
            picType.Size = new Size(34, 34);
            picType.SizeMode = PictureBoxSizeMode.StretchImage;
            picType.TabIndex = 4;
            picType.TabStop = false;
            picType.Click += pnType_Click;
            // 
            // flowMain
            // 
            flowMain.AutoScroll = true;
            flowMain.Location = new Point(0, 150);
            flowMain.Name = "flowMain";
            flowMain.Size = new Size(1760, 1324);
            flowMain.TabIndex = 4;
            // 
            // pnLasted
            // 
            pnLasted.BackgroundImage = Properties.Resources.bg_lasted;
            pnLasted.BackgroundImageLayout = ImageLayout.Stretch;
            pnLasted.Controls.Add(flowLasted);
            pnLasted.Controls.Add(label1);
            pnLasted.Location = new Point(0, 0);
            pnLasted.Name = "pnLasted";
            pnLasted.Size = new Size(380, 390);
            pnLasted.TabIndex = 5;
            // 
            // flowLasted
            // 
            flowLasted.FlowDirection = FlowDirection.TopDown;
            flowLasted.Location = new Point(22, 60);
            flowLasted.Margin = new Padding(4);
            flowLasted.Name = "flowLasted";
            flowLasted.Size = new Size(336, 320);
            flowLasted.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(350, 38);
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
            pnSearch.Controls.Add(cbArrange);
            pnSearch.Controls.Add(pnComic);
            pnSearch.Controls.Add(cbType);
            pnSearch.Location = new Point(0, 120);
            pnSearch.Name = "pnSearch";
            pnSearch.Size = new Size(2192, 130);
            pnSearch.TabIndex = 6;
            pnSearch.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.ForestGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1918, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(222, 60);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm truyện";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnUpdating
            // 
            pnUpdating.Controls.Add(lbUpdating);
            pnUpdating.Controls.Add(picUpdating);
            pnUpdating.Location = new Point(1364, 66);
            pnUpdating.Name = "pnUpdating";
            pnUpdating.Size = new Size(286, 40);
            pnUpdating.TabIndex = 9;
            pnUpdating.Click += pnUpdating_Click;
            // 
            // lbUpdating
            // 
            lbUpdating.AutoSize = true;
            lbUpdating.Font = new Font("Segoe UI", 10F);
            lbUpdating.Location = new Point(36, 4);
            lbUpdating.Name = "lbUpdating";
            lbUpdating.Size = new Size(246, 32);
            lbUpdating.TabIndex = 5;
            lbUpdating.Text = "Truyện đang cập nhật";
            lbUpdating.Click += pnUpdating_Click;
            // 
            // picUpdating
            // 
            picUpdating.Image = Properties.Resources.check;
            picUpdating.Location = new Point(0, 4);
            picUpdating.Name = "picUpdating";
            picUpdating.Size = new Size(30, 30);
            picUpdating.SizeMode = PictureBoxSizeMode.StretchImage;
            picUpdating.TabIndex = 4;
            picUpdating.TabStop = false;
            picUpdating.Click += pnUpdating_Click;
            // 
            // pnFull
            // 
            pnFull.Controls.Add(lbFull);
            pnFull.Controls.Add(picFull);
            pnFull.Location = new Point(1364, 20);
            pnFull.Name = "pnFull";
            pnFull.Size = new Size(171, 40);
            pnFull.TabIndex = 8;
            pnFull.Click += pnFull_Click;
            // 
            // lbFull
            // 
            lbFull.AutoSize = true;
            lbFull.Font = new Font("Segoe UI", 10F);
            lbFull.Location = new Point(36, 4);
            lbFull.Name = "lbFull";
            lbFull.Size = new Size(127, 32);
            lbFull.TabIndex = 5;
            lbFull.Text = "Truyện full";
            lbFull.Click += pnFull_Click;
            // 
            // picFull
            // 
            picFull.Image = Properties.Resources.check;
            picFull.Location = new Point(0, 4);
            picFull.Name = "picFull";
            picFull.Size = new Size(30, 30);
            picFull.SizeMode = PictureBoxSizeMode.StretchImage;
            picFull.TabIndex = 4;
            picFull.TabStop = false;
            picFull.Click += pnFull_Click;
            // 
            // pnFee
            // 
            pnFee.Controls.Add(lbFee);
            pnFee.Controls.Add(picFee);
            pnFee.Location = new Point(1714, 66);
            pnFee.Name = "pnFee";
            pnFee.Size = new Size(128, 40);
            pnFee.TabIndex = 7;
            pnFee.Click += pnFee_Click;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Font = new Font("Segoe UI", 10F);
            lbFee.Location = new Point(36, 4);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(84, 32);
            lbFee.TabIndex = 5;
            lbFee.Text = "Có phí";
            lbFee.Click += pnFee_Click;
            // 
            // picFee
            // 
            picFee.Image = Properties.Resources.check;
            picFee.Location = new Point(0, 4);
            picFee.Name = "picFee";
            picFee.Size = new Size(30, 30);
            picFee.SizeMode = PictureBoxSizeMode.StretchImage;
            picFee.TabIndex = 4;
            picFee.TabStop = false;
            picFee.Click += pnFee_Click;
            // 
            // pnStory
            // 
            pnStory.Controls.Add(lbStory);
            pnStory.Controls.Add(picStory);
            pnStory.Location = new Point(1114, 66);
            pnStory.Name = "pnStory";
            pnStory.Size = new Size(184, 40);
            pnStory.TabIndex = 5;
            pnStory.Click += pnStory_Click;
            // 
            // lbStory
            // 
            lbStory.AutoSize = true;
            lbStory.Font = new Font("Segoe UI", 10F);
            lbStory.Location = new Point(36, 4);
            lbStory.Name = "lbStory";
            lbStory.Size = new Size(132, 32);
            lbStory.TabIndex = 5;
            lbStory.Text = "Truyện chữ";
            lbStory.Click += pnStory_Click;
            // 
            // picStory
            // 
            picStory.Image = Properties.Resources.check;
            picStory.Location = new Point(0, 4);
            picStory.Name = "picStory";
            picStory.Size = new Size(30, 30);
            picStory.SizeMode = PictureBoxSizeMode.StretchImage;
            picStory.TabIndex = 4;
            picStory.TabStop = false;
            picStory.Click += pnStory_Click;
            // 
            // pnFree
            // 
            pnFree.Controls.Add(lbFree);
            pnFree.Controls.Add(picFree);
            pnFree.Location = new Point(1714, 20);
            pnFree.Name = "pnFree";
            pnFree.Size = new Size(153, 40);
            pnFree.TabIndex = 6;
            pnFree.Click += pnFree_Click;
            // 
            // lbFree
            // 
            lbFree.AutoSize = true;
            lbFree.Font = new Font("Segoe UI", 10F);
            lbFree.Location = new Point(36, 4);
            lbFree.Name = "lbFree";
            lbFree.Size = new Size(110, 32);
            lbFree.TabIndex = 5;
            lbFree.Text = "Miễn phí";
            lbFree.Click += pnFree_Click;
            // 
            // picFree
            // 
            picFree.Image = Properties.Resources.check;
            picFree.Location = new Point(0, 4);
            picFree.Name = "picFree";
            picFree.Size = new Size(30, 30);
            picFree.SizeMode = PictureBoxSizeMode.StretchImage;
            picFree.TabIndex = 4;
            picFree.TabStop = false;
            picFree.Click += pnFree_Click;
            // 
            // cbArrange
            // 
            cbArrange.Font = new Font("Segoe UI", 12F);
            cbArrange.ForeColor = Color.Gray;
            cbArrange.FormattingEnabled = true;
            cbArrange.ItemHeight = 38;
            cbArrange.Items.AddRange(new object[] { "Đánh giá cao", "Mới nhất", "Nổi bật" });
            cbArrange.Location = new Point(581, 39);
            cbArrange.Margin = new Padding(4);
            cbArrange.Name = "cbArrange";
            cbArrange.Size = new Size(500, 46);
            cbArrange.Sorted = true;
            cbArrange.TabIndex = 1;
            cbArrange.Tag = "";
            cbArrange.Text = "Sắp xếp theo";
            // 
            // pnComic
            // 
            pnComic.Controls.Add(lbComic);
            pnComic.Controls.Add(picComic);
            pnComic.Location = new Point(1114, 20);
            pnComic.Name = "pnComic";
            pnComic.Size = new Size(184, 40);
            pnComic.TabIndex = 4;
            pnComic.Click += pnComic_Click;
            // 
            // lbComic
            // 
            lbComic.AutoSize = true;
            lbComic.Font = new Font("Segoe UI", 10F);
            lbComic.Location = new Point(36, 4);
            lbComic.Name = "lbComic";
            lbComic.Size = new Size(149, 32);
            lbComic.TabIndex = 5;
            lbComic.Text = "Truyện tranh";
            lbComic.Click += pnComic_Click;
            // 
            // picComic
            // 
            picComic.Image = Properties.Resources.check;
            picComic.Location = new Point(0, 4);
            picComic.Name = "picComic";
            picComic.Size = new Size(30, 30);
            picComic.SizeMode = PictureBoxSizeMode.StretchImage;
            picComic.TabIndex = 4;
            picComic.TabStop = false;
            picComic.Click += pnComic_Click;
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 12F);
            cbType.ForeColor = Color.Gray;
            cbType.FormattingEnabled = true;
            cbType.ItemHeight = 38;
            cbType.Items.AddRange(new object[] { "Ngôn tình", "Cổ trang", "Bách hợp", "Cung đấu", "Thể loại 5", "Thể loại 6" });
            cbType.Location = new Point(34, 40);
            cbType.Name = "cbType";
            cbType.Size = new Size(500, 46);
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
            panelType.Location = new Point(465, 100);
            panelType.Name = "panelType";
            panelType.Size = new Size(350, 160);
            panelType.TabIndex = 7;
            panelType.Visible = false;
            // 
            // lbTheLoai6
            // 
            lbTheLoai6.Font = new Font("Segoe UI", 11F);
            lbTheLoai6.Location = new Point(196, 110);
            lbTheLoai6.Name = "lbTheLoai6";
            lbTheLoai6.Size = new Size(151, 38);
            lbTheLoai6.TabIndex = 11;
            lbTheLoai6.Text = "Trinh thám";
            lbTheLoai6.Click += lbTheLoai6_Click;
            lbTheLoai6.MouseLeave += lbTheLoai6_MouseLeave;
            lbTheLoai6.MouseHover += lbTheLoai6_MouseHover;
            // 
            // lbTheLoai5
            // 
            lbTheLoai5.Font = new Font("Segoe UI", 11F);
            lbTheLoai5.Location = new Point(196, 60);
            lbTheLoai5.Name = "lbTheLoai5";
            lbTheLoai5.Size = new Size(140, 38);
            lbTheLoai5.TabIndex = 10;
            lbTheLoai5.Text = "Đam mỹ";
            lbTheLoai5.Click += lbTheLoai5_Click;
            lbTheLoai5.MouseLeave += lbTheLoai5_MouseLeave;
            lbTheLoai5.MouseHover += lbTheLoai5_MouseHover;
            // 
            // lbBachHop
            // 
            lbBachHop.Font = new Font("Segoe UI", 11F);
            lbBachHop.Location = new Point(196, 10);
            lbBachHop.Name = "lbBachHop";
            lbBachHop.Size = new Size(124, 38);
            lbBachHop.TabIndex = 9;
            lbBachHop.Text = "Bách hợp";
            lbBachHop.Click += lbBachHop_Click;
            lbBachHop.MouseLeave += lbBachHop_MouseLeave;
            lbBachHop.MouseHover += lbBachHop_MouseHover;
            // 
            // lbCungDau
            // 
            lbCungDau.Font = new Font("Segoe UI", 11F);
            lbCungDau.Location = new Point(20, 110);
            lbCungDau.Name = "lbCungDau";
            lbCungDau.Size = new Size(134, 38);
            lbCungDau.TabIndex = 8;
            lbCungDau.Text = "Cung đấu";
            lbCungDau.Click += lbCungDau_Click;
            lbCungDau.MouseLeave += lbCungDau_MouseLeave;
            lbCungDau.MouseHover += lbCungDau_MouseHover;
            // 
            // lbCoTrang
            // 
            lbCoTrang.Font = new Font("Segoe UI", 11F);
            lbCoTrang.Location = new Point(20, 60);
            lbCoTrang.Name = "lbCoTrang";
            lbCoTrang.Size = new Size(117, 38);
            lbCoTrang.TabIndex = 7;
            lbCoTrang.Text = "Cổ trang";
            lbCoTrang.Click += lbCoTrang_Click;
            lbCoTrang.MouseLeave += lbCoTrang_MouseLeave;
            lbCoTrang.MouseHover += lbCoTrang_MouseHover;
            // 
            // lbNgonTinh
            // 
            lbNgonTinh.Font = new Font("Segoe UI", 11F);
            lbNgonTinh.Location = new Point(20, 10);
            lbNgonTinh.Name = "lbNgonTinh";
            lbNgonTinh.Size = new Size(134, 38);
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
            panelState.Location = new Point(1780, 150);
            panelState.Name = "panelState";
            panelState.Size = new Size(562, 1902);
            panelState.TabIndex = 8;
            // 
            // pnStar
            // 
            pnStar.BackgroundImage = Properties.Resources.bg_lasted;
            pnStar.BackgroundImageLayout = ImageLayout.Stretch;
            pnStar.Controls.Add(flowStar);
            pnStar.Controls.Add(label12);
            pnStar.Location = new Point(0, 794);
            pnStar.Margin = new Padding(4);
            pnStar.Name = "pnStar";
            pnStar.Size = new Size(380, 390);
            pnStar.TabIndex = 18;
            // 
            // flowStar
            // 
            flowStar.FlowDirection = FlowDirection.TopDown;
            flowStar.Location = new Point(22, 60);
            flowStar.Margin = new Padding(4);
            flowStar.Name = "flowStar";
            flowStar.Size = new Size(336, 320);
            flowStar.TabIndex = 2;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(10, 8);
            label12.Name = "label12";
            label12.Size = new Size(350, 38);
            label12.TabIndex = 0;
            label12.Text = "Đánh giá cao";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnOutstanding
            // 
            pnOutstanding.BackgroundImage = Properties.Resources.bg_lasted;
            pnOutstanding.BackgroundImageLayout = ImageLayout.Stretch;
            pnOutstanding.Controls.Add(flowOuts);
            pnOutstanding.Controls.Add(label22);
            pnOutstanding.Location = new Point(0, 396);
            pnOutstanding.Margin = new Padding(4);
            pnOutstanding.Name = "pnOutstanding";
            pnOutstanding.Size = new Size(380, 390);
            pnOutstanding.TabIndex = 6;
            // 
            // flowOuts
            // 
            flowOuts.FlowDirection = FlowDirection.TopDown;
            flowOuts.Location = new Point(22, 60);
            flowOuts.Margin = new Padding(4);
            flowOuts.Name = "flowOuts";
            flowOuts.Size = new Size(336, 320);
            flowOuts.TabIndex = 1;
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label22.ForeColor = Color.DarkGreen;
            label22.Location = new Point(10, 8);
            label22.Name = "label22";
            label22.Size = new Size(350, 38);
            label22.TabIndex = 0;
            label22.Text = "Nổi bật";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.ForestGreen;
            btnWrite.BackgroundImageLayout = ImageLayout.None;
            btnWrite.Cursor = Cursors.Hand;
            btnWrite.FlatStyle = FlatStyle.Flat;
            btnWrite.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.ForeColor = SystemColors.ButtonHighlight;
            btnWrite.Location = new Point(36, 36);
            btnWrite.Margin = new Padding(4);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(174, 69);
            btnWrite.TabIndex = 9;
            btnWrite.Text = "Viết truyện";
            btnWrite.UseVisualStyleBackColor = false;
            // 
            // UCHome
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
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
            Name = "UCHome";
            Size = new Size(2190, 1474);
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
        private Label label22;
        private Button btnWrite;
        private Panel pnStar;
        private Label label12;
        private FlowLayoutPanel flowLasted;
        private FlowLayoutPanel flowOuts;
        private FlowLayoutPanel flowStar;
    }
}
