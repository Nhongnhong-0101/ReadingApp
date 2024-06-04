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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            pnType = new Panel();
            lbType = new Label();
            picType = new PictureBox();
            flowMain = new FlowLayoutPanel();
            pnLasted = new Panel();
            lbLastedAuthor10 = new Label();
            lbLastedName10 = new Label();
            lbLastedAuthor9 = new Label();
            lbLastedName9 = new Label();
            lbLastedAuthor8 = new Label();
            lbLastedName8 = new Label();
            lbLastedAuthor7 = new Label();
            lbLastedName7 = new Label();
            lbLastedAuthor6 = new Label();
            lbLastedName6 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_user;
            pictureBox1.Location = new Point(2060, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.search;
            pictureBox2.Location = new Point(1145, 12);
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
            pnType.Location = new Point(635, 50);
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
            picType.Location = new Point(5, 8);
            picType.Name = "picType";
            picType.Size = new Size(35, 35);
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
            flowMain.Size = new Size(1760, 1325);
            flowMain.TabIndex = 4;
            // 
            // pnLasted
            // 
            pnLasted.BackgroundImage = Properties.Resources.bg_lasted;
            pnLasted.BackgroundImageLayout = ImageLayout.Stretch;
            pnLasted.Controls.Add(lbLastedAuthor10);
            pnLasted.Controls.Add(lbLastedName10);
            pnLasted.Controls.Add(lbLastedAuthor9);
            pnLasted.Controls.Add(lbLastedName9);
            pnLasted.Controls.Add(lbLastedAuthor8);
            pnLasted.Controls.Add(lbLastedName8);
            pnLasted.Controls.Add(lbLastedAuthor7);
            pnLasted.Controls.Add(lbLastedName7);
            pnLasted.Controls.Add(lbLastedAuthor6);
            pnLasted.Controls.Add(lbLastedName6);
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
            pnLasted.Location = new Point(1790, 150);
            pnLasted.Name = "pnLasted";
            pnLasted.Size = new Size(370, 930);
            pnLasted.TabIndex = 5;
            // 
            // lbLastedAuthor10
            // 
            lbLastedAuthor10.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor10.ForeColor = Color.Gray;
            lbLastedAuthor10.Location = new Point(20, 880);
            lbLastedAuthor10.Name = "lbLastedAuthor10";
            lbLastedAuthor10.Size = new Size(330, 30);
            lbLastedAuthor10.TabIndex = 27;
            lbLastedAuthor10.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName10
            // 
            lbLastedName10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName10.Location = new Point(20, 840);
            lbLastedName10.Name = "lbLastedName10";
            lbLastedName10.Size = new Size(330, 40);
            lbLastedName10.TabIndex = 26;
            lbLastedName10.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor9
            // 
            lbLastedAuthor9.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor9.ForeColor = Color.Gray;
            lbLastedAuthor9.Location = new Point(20, 795);
            lbLastedAuthor9.Name = "lbLastedAuthor9";
            lbLastedAuthor9.Size = new Size(330, 30);
            lbLastedAuthor9.TabIndex = 25;
            lbLastedAuthor9.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName9
            // 
            lbLastedName9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName9.Location = new Point(20, 755);
            lbLastedName9.Name = "lbLastedName9";
            lbLastedName9.Size = new Size(330, 40);
            lbLastedName9.TabIndex = 24;
            lbLastedName9.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor8
            // 
            lbLastedAuthor8.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor8.ForeColor = Color.Gray;
            lbLastedAuthor8.Location = new Point(20, 710);
            lbLastedAuthor8.Name = "lbLastedAuthor8";
            lbLastedAuthor8.Size = new Size(330, 30);
            lbLastedAuthor8.TabIndex = 23;
            lbLastedAuthor8.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName8
            // 
            lbLastedName8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName8.Location = new Point(20, 670);
            lbLastedName8.Name = "lbLastedName8";
            lbLastedName8.Size = new Size(330, 40);
            lbLastedName8.TabIndex = 22;
            lbLastedName8.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor7
            // 
            lbLastedAuthor7.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor7.ForeColor = Color.Gray;
            lbLastedAuthor7.Location = new Point(20, 625);
            lbLastedAuthor7.Name = "lbLastedAuthor7";
            lbLastedAuthor7.Size = new Size(330, 30);
            lbLastedAuthor7.TabIndex = 21;
            lbLastedAuthor7.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName7
            // 
            lbLastedName7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName7.Location = new Point(20, 585);
            lbLastedName7.Name = "lbLastedName7";
            lbLastedName7.Size = new Size(330, 40);
            lbLastedName7.TabIndex = 20;
            lbLastedName7.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor6
            // 
            lbLastedAuthor6.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor6.ForeColor = Color.Gray;
            lbLastedAuthor6.Location = new Point(20, 540);
            lbLastedAuthor6.Name = "lbLastedAuthor6";
            lbLastedAuthor6.Size = new Size(330, 30);
            lbLastedAuthor6.TabIndex = 19;
            lbLastedAuthor6.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName6
            // 
            lbLastedName6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName6.Location = new Point(20, 500);
            lbLastedName6.Name = "lbLastedName6";
            lbLastedName6.Size = new Size(330, 40);
            lbLastedName6.TabIndex = 18;
            lbLastedName6.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor5
            // 
            lbLastedAuthor5.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor5.ForeColor = Color.Gray;
            lbLastedAuthor5.Location = new Point(20, 455);
            lbLastedAuthor5.Name = "lbLastedAuthor5";
            lbLastedAuthor5.Size = new Size(330, 30);
            lbLastedAuthor5.TabIndex = 17;
            lbLastedAuthor5.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName5
            // 
            lbLastedName5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName5.Location = new Point(20, 415);
            lbLastedName5.Name = "lbLastedName5";
            lbLastedName5.Size = new Size(330, 40);
            lbLastedName5.TabIndex = 16;
            lbLastedName5.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor4
            // 
            lbLastedAuthor4.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor4.ForeColor = Color.Gray;
            lbLastedAuthor4.Location = new Point(20, 370);
            lbLastedAuthor4.Name = "lbLastedAuthor4";
            lbLastedAuthor4.Size = new Size(330, 30);
            lbLastedAuthor4.TabIndex = 15;
            lbLastedAuthor4.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName4
            // 
            lbLastedName4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName4.Location = new Point(20, 330);
            lbLastedName4.Name = "lbLastedName4";
            lbLastedName4.Size = new Size(330, 40);
            lbLastedName4.TabIndex = 14;
            lbLastedName4.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor3
            // 
            lbLastedAuthor3.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor3.ForeColor = Color.Gray;
            lbLastedAuthor3.Location = new Point(20, 285);
            lbLastedAuthor3.Name = "lbLastedAuthor3";
            lbLastedAuthor3.Size = new Size(330, 30);
            lbLastedAuthor3.TabIndex = 13;
            lbLastedAuthor3.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName3
            // 
            lbLastedName3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName3.Location = new Point(20, 245);
            lbLastedName3.Name = "lbLastedName3";
            lbLastedName3.Size = new Size(330, 40);
            lbLastedName3.TabIndex = 12;
            lbLastedName3.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor2
            // 
            lbLastedAuthor2.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor2.ForeColor = Color.Gray;
            lbLastedAuthor2.Location = new Point(20, 200);
            lbLastedAuthor2.Name = "lbLastedAuthor2";
            lbLastedAuthor2.Size = new Size(330, 30);
            lbLastedAuthor2.TabIndex = 11;
            lbLastedAuthor2.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName2
            // 
            lbLastedName2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName2.Location = new Point(20, 160);
            lbLastedName2.Name = "lbLastedName2";
            lbLastedName2.Size = new Size(330, 40);
            lbLastedName2.TabIndex = 10;
            lbLastedName2.Text = "Nhớ mãi không quên";
            // 
            // lbLastedAuthor1
            // 
            lbLastedAuthor1.Font = new Font("Segoe UI", 8F);
            lbLastedAuthor1.ForeColor = Color.Gray;
            lbLastedAuthor1.Location = new Point(20, 115);
            lbLastedAuthor1.Name = "lbLastedAuthor1";
            lbLastedAuthor1.Size = new Size(330, 30);
            lbLastedAuthor1.TabIndex = 9;
            lbLastedAuthor1.Text = "Thiên Hạ Thủy";
            // 
            // lbLastedName1
            // 
            lbLastedName1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbLastedName1.Location = new Point(20, 75);
            lbLastedName1.Name = "lbLastedName1";
            lbLastedName1.Size = new Size(330, 40);
            lbLastedName1.TabIndex = 8;
            lbLastedName1.Text = "Nhớ mãi không quên";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(350, 32);
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
            pnSearch.Location = new Point(-1, 120);
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
            lbUpdating.Location = new Point(36, 5);
            lbUpdating.Name = "lbUpdating";
            lbUpdating.Size = new Size(246, 32);
            lbUpdating.TabIndex = 5;
            lbUpdating.Text = "Truyện đang cập nhật";
            lbUpdating.Click += pnUpdating_Click;
            // 
            // picUpdating
            // 
            picUpdating.Image = Properties.Resources.check;
            picUpdating.Location = new Point(0, 5);
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
            lbFull.Location = new Point(36, 5);
            lbFull.Name = "lbFull";
            lbFull.Size = new Size(127, 32);
            lbFull.TabIndex = 5;
            lbFull.Text = "Truyện full";
            lbFull.Click += pnFull_Click;
            // 
            // picFull
            // 
            picFull.Image = Properties.Resources.check;
            picFull.Location = new Point(0, 5);
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
            pnFee.Location = new Point(1715, 66);
            pnFee.Name = "pnFee";
            pnFee.Size = new Size(128, 40);
            pnFee.TabIndex = 7;
            pnFee.Click += pnFee_Click;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Font = new Font("Segoe UI", 10F);
            lbFee.Location = new Point(36, 5);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(84, 32);
            lbFee.TabIndex = 5;
            lbFee.Text = "Có phí";
            lbFee.Click += pnFee_Click;
            // 
            // picFee
            // 
            picFee.Image = Properties.Resources.check;
            picFee.Location = new Point(0, 5);
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
            pnStory.Size = new Size(185, 40);
            pnStory.TabIndex = 5;
            pnStory.Click += pnStory_Click;
            // 
            // lbStory
            // 
            lbStory.AutoSize = true;
            lbStory.Font = new Font("Segoe UI", 10F);
            lbStory.Location = new Point(36, 5);
            lbStory.Name = "lbStory";
            lbStory.Size = new Size(132, 32);
            lbStory.TabIndex = 5;
            lbStory.Text = "Truyện chữ";
            lbStory.Click += pnStory_Click;
            // 
            // picStory
            // 
            picStory.Image = Properties.Resources.check;
            picStory.Location = new Point(0, 5);
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
            pnFree.Location = new Point(1715, 20);
            pnFree.Name = "pnFree";
            pnFree.Size = new Size(153, 40);
            pnFree.TabIndex = 6;
            pnFree.Click += pnFree_Click;
            // 
            // lbFree
            // 
            lbFree.AutoSize = true;
            lbFree.Font = new Font("Segoe UI", 10F);
            lbFree.Location = new Point(36, 5);
            lbFree.Name = "lbFree";
            lbFree.Size = new Size(110, 32);
            lbFree.TabIndex = 5;
            lbFree.Text = "Miễn phí";
            lbFree.Click += pnFree_Click;
            // 
            // picFree
            // 
            picFree.Image = Properties.Resources.check;
            picFree.Location = new Point(0, 5);
            picFree.Name = "picFree";
            picFree.Size = new Size(30, 30);
            picFree.SizeMode = PictureBoxSizeMode.StretchImage;
            picFree.TabIndex = 4;
            picFree.TabStop = false;
            picFree.Click += pnFree_Click;
            // 
            // pnComic
            // 
            pnComic.Controls.Add(lbComic);
            pnComic.Controls.Add(picComic);
            pnComic.Location = new Point(1114, 20);
            pnComic.Name = "pnComic";
            pnComic.Size = new Size(185, 40);
            pnComic.TabIndex = 4;
            pnComic.Click += pnComic_Click;
            // 
            // lbComic
            // 
            lbComic.AutoSize = true;
            lbComic.Font = new Font("Segoe UI", 10F);
            lbComic.Location = new Point(36, 5);
            lbComic.Name = "lbComic";
            lbComic.Size = new Size(149, 32);
            lbComic.TabIndex = 5;
            lbComic.Text = "Truyện tranh";
            lbComic.Click += pnComic_Click;
            // 
            // picComic
            // 
            picComic.Image = Properties.Resources.check;
            picComic.Location = new Point(0, 5);
            picComic.Name = "picComic";
            picComic.Size = new Size(30, 30);
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
            cbArrange.ItemHeight = 38;
            cbArrange.Items.AddRange(new object[] { "Full", "Mới nhất", "Tác giả", "Tên truyện" });
            cbArrange.Location = new Point(580, 40);
            cbArrange.Name = "cbArrange";
            cbArrange.Size = new Size(500, 46);
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
            cbType.ItemHeight = 38;
            cbType.Items.AddRange(new object[] { "Ngôn tình", "Cổ trang", "Bách hợp", "Cung đấu", "Thể loại 5", "Thể loại 6" });
            cbType.Location = new Point(35, 40);
            cbType.Name = "cbType";
            cbType.Size = new Size(500, 46);
            cbType.TabIndex = 0;
            cbType.Tag = "";
            cbType.Text = "Thể loại";
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
            lbTheLoai6.Location = new Point(197, 110);
            lbTheLoai6.Name = "lbTheLoai6";
            lbTheLoai6.Size = new Size(140, 38);
            lbTheLoai6.TabIndex = 11;
            lbTheLoai6.Text = "Thể loại 6";
            lbTheLoai6.Click += lbTheLoai6_Click;
            lbTheLoai6.MouseLeave += lbTheLoai6_MouseLeave;
            lbTheLoai6.MouseHover += lbTheLoai6_MouseHover;
            // 
            // lbTheLoai5
            // 
            lbTheLoai5.Font = new Font("Segoe UI", 11F);
            lbTheLoai5.Location = new Point(197, 60);
            lbTheLoai5.Name = "lbTheLoai5";
            lbTheLoai5.Size = new Size(140, 38);
            lbTheLoai5.TabIndex = 10;
            lbTheLoai5.Text = "Thể loại 5";
            lbTheLoai5.Click += lbTheLoai5_Click;
            lbTheLoai5.MouseLeave += lbTheLoai5_MouseLeave;
            lbTheLoai5.MouseHover += lbTheLoai5_MouseHover;
            // 
            // lbBachHop
            // 
            lbBachHop.Font = new Font("Segoe UI", 11F);
            lbBachHop.Location = new Point(197, 10);
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
            // UCHome
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelType);
            Controls.Add(pnSearch);
            Controls.Add(pnLasted);
            Controls.Add(flowMain);
            Controls.Add(pnType);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "UCHome";
            Size = new Size(2190, 1475);
            Load += UCHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
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
        private Label lbLastedAuthor6;
        private Label lbLastedName6;
        private Label lbLastedAuthor5;
        private Label lbLastedName5;
        private Label lbLastedAuthor4;
        private Label lbLastedName4;
        private Label lbLastedAuthor3;
        private Label lbLastedName3;
        private Label lbLastedAuthor2;
        private Label lbLastedName2;
        private Label lbLastedAuthor10;
        private Label lbLastedName10;
        private Label lbLastedAuthor9;
        private Label lbLastedName9;
        private Label lbLastedAuthor8;
        private Label lbLastedName8;
        private Label lbLastedAuthor7;
        private Label lbLastedName7;
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
    }
}
