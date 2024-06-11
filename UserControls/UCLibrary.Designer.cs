namespace ReadingApp.UserControls
{
    partial class UCLibrary
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
            pnLasted = new Panel();
            btnSearch = new Button();
            pnFee = new Panel();
            lbFee = new Label();
            picFee = new PictureBox();
            pnFree = new Panel();
            lbFree = new Label();
            picFree = new PictureBox();
            pnUpdating = new Panel();
            lbUpdating = new Label();
            picUpdating = new PictureBox();
            pnFull = new Panel();
            lbFull = new Label();
            picFull = new PictureBox();
            pnStory = new Panel();
            lbStory = new Label();
            picStory = new PictureBox();
            pnComic = new Panel();
            lbComic = new Label();
            picComic = new PictureBox();
            cbArrange = new ComboBox();
            cbType = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            flowMain = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pnLasted.SuspendLayout();
            pnFee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFee).BeginInit();
            pnFree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFree).BeginInit();
            pnUpdating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUpdating).BeginInit();
            pnFull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFull).BeginInit();
            pnStory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStory).BeginInit();
            pnComic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picComic).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnLasted
            // 
            pnLasted.BackgroundImage = Properties.Resources.bg_lasted;
            pnLasted.BackgroundImageLayout = ImageLayout.Stretch;
            pnLasted.Controls.Add(btnSearch);
            pnLasted.Controls.Add(pnFee);
            pnLasted.Controls.Add(pnFree);
            pnLasted.Controls.Add(pnUpdating);
            pnLasted.Controls.Add(pnFull);
            pnLasted.Controls.Add(pnStory);
            pnLasted.Controls.Add(pnComic);
            pnLasted.Controls.Add(cbArrange);
            pnLasted.Controls.Add(cbType);
            pnLasted.Controls.Add(label1);
            pnLasted.Location = new Point(1790, 140);
            pnLasted.Name = "pnLasted";
            pnLasted.Size = new Size(370, 680);
            pnLasted.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.ForestGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(70, 580);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(230, 60);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Lọc truyện";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnFee
            // 
            pnFee.Controls.Add(lbFee);
            pnFee.Controls.Add(picFee);
            pnFee.Location = new Point(50, 500);
            pnFee.Name = "pnFee";
            pnFee.Size = new Size(146, 40);
            pnFee.TabIndex = 13;
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
            // pnFree
            // 
            pnFree.Controls.Add(lbFree);
            pnFree.Controls.Add(picFree);
            pnFree.Location = new Point(50, 450);
            pnFree.Name = "pnFree";
            pnFree.Size = new Size(171, 40);
            pnFree.TabIndex = 12;
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
            // pnUpdating
            // 
            pnUpdating.Controls.Add(lbUpdating);
            pnUpdating.Controls.Add(picUpdating);
            pnUpdating.Location = new Point(50, 400);
            pnUpdating.Name = "pnUpdating";
            pnUpdating.Size = new Size(305, 40);
            pnUpdating.TabIndex = 11;
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
            pnFull.Location = new Point(50, 350);
            pnFull.Name = "pnFull";
            pnFull.Size = new Size(204, 40);
            pnFull.TabIndex = 10;
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
            // pnStory
            // 
            pnStory.Controls.Add(lbStory);
            pnStory.Controls.Add(picStory);
            pnStory.Location = new Point(50, 300);
            pnStory.Name = "pnStory";
            pnStory.Size = new Size(185, 40);
            pnStory.TabIndex = 7;
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
            // pnComic
            // 
            pnComic.Controls.Add(lbComic);
            pnComic.Controls.Add(picComic);
            pnComic.Location = new Point(50, 250);
            pnComic.Name = "pnComic";
            pnComic.Size = new Size(204, 40);
            pnComic.TabIndex = 6;
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
            cbArrange.Location = new Point(35, 170);
            cbArrange.Name = "cbArrange";
            cbArrange.Size = new Size(300, 46);
            cbArrange.Sorted = true;
            cbArrange.TabIndex = 3;
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
            cbType.Location = new Point(35, 90);
            cbType.Name = "cbType";
            cbType.Size = new Size(300, 46);
            cbType.TabIndex = 2;
            cbType.Tag = "";
            cbType.Text = "Thể loại 5";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(10, 16);
            label1.Name = "label1";
            label1.Size = new Size(350, 43);
            label1.TabIndex = 0;
            label1.Text = "Lọc truyện";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.TabIndex = 9;
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
            // flowMain
            // 
            flowMain.AutoScroll = true;
            flowMain.Location = new Point(0, 140);
            flowMain.Name = "flowMain";
            flowMain.Size = new Size(1760, 1325);
            flowMain.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_user;
            pictureBox1.Location = new Point(2060, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UCLibrary
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnLasted);
            Controls.Add(panel1);
            Controls.Add(flowMain);
            Controls.Add(pictureBox1);
            Name = "UCLibrary";
            Size = new Size(2190, 1475);
            Load += UCLibrary_Load;
            pnLasted.ResumeLayout(false);
            pnFee.ResumeLayout(false);
            pnFee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFee).EndInit();
            pnFree.ResumeLayout(false);
            pnFree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFree).EndInit();
            pnUpdating.ResumeLayout(false);
            pnUpdating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUpdating).EndInit();
            pnFull.ResumeLayout(false);
            pnFull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFull).EndInit();
            pnStory.ResumeLayout(false);
            pnStory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStory).EndInit();
            pnComic.ResumeLayout(false);
            pnComic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picComic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLasted;
        private Panel panel1;
        private TextBox txtSearch;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowMain;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cbArrange;
        private ComboBox cbType;
        private Panel pnStory;
        private Label lbStory;
        private PictureBox picStory;
        private Panel pnComic;
        private Label lbComic;
        private PictureBox picComic;
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
    }
}
