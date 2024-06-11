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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStoryDetails));
            lbIsFull = new Label();
            picImage = new PictureBox();
            lbName = new Label();
            pnTitle = new Panel();
            pnStar = new Panel();
            label9 = new Label();
            picStar = new PictureBox();
            panel2 = new Panel();
            lbType = new Label();
            label10 = new Label();
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
            flowChapter = new FlowLayoutPanel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnTitle.SuspendLayout();
            pnStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbIsFull
            // 
            lbIsFull.AutoSize = true;
            lbIsFull.BackColor = Color.Green;
            lbIsFull.Font = new Font("Segoe UI", 10F);
            lbIsFull.ForeColor = Color.White;
            lbIsFull.Location = new Point(136, 81);
            lbIsFull.Name = "lbIsFull";
            lbIsFull.Padding = new Padding(10, 2, 10, 2);
            lbIsFull.Size = new Size(190, 36);
            lbIsFull.TabIndex = 15;
            lbIsFull.Text = "Đang cập nhật";
            lbIsFull.TextAlign = ContentAlignment.MiddleCenter;
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
            lbName.Size = new Size(1615, 50);
            lbName.TabIndex = 12;
            lbName.Text = "Nhớ mãi không quên";
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(pnStar);
            pnTitle.Controls.Add(lbName);
            pnTitle.Location = new Point(530, 60);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(1618, 95);
            pnTitle.TabIndex = 14;
            // 
            // pnStar
            // 
            pnStar.Controls.Add(label9);
            pnStar.Controls.Add(picStar);
            pnStar.Location = new Point(21, 52);
            pnStar.Name = "pnStar";
            pnStar.Size = new Size(102, 40);
            pnStar.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(42, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 36);
            label9.TabIndex = 4;
            label9.Text = "3.5";
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
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lbLastUpdate);
            panel2.Controls.Add(lbCreatedAt);
            panel2.Controls.Add(lbNumberChapter);
            panel2.Controls.Add(lbIsFull);
            panel2.Controls.Add(lbAuthor);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(555, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(1593, 593);
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
            // label10
            // 
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(0, 297);
            label10.Name = "label10";
            label10.Size = new Size(1590, 273);
            label10.TabIndex = 19;
            label10.Text = resources.GetString("label10.Text");
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
            lbNumberChapter.Location = new Point(141, 117);
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
            // flowChapter
            // 
            flowChapter.AutoScroll = true;
            flowChapter.FlowDirection = FlowDirection.TopDown;
            flowChapter.Location = new Point(50, 800);
            flowChapter.Name = "flowChapter";
            flowChapter.Size = new Size(2098, 650);
            flowChapter.TabIndex = 16;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(50, 756);
            label7.Name = "label7";
            label7.Size = new Size(365, 44);
            label7.TabIndex = 14;
            label7.Text = "DANH SÁCH CHƯƠNG";
            // 
            // UCStoryDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label7);
            Controls.Add(flowChapter);
            Controls.Add(picImage);
            Controls.Add(panel2);
            Controls.Add(pnTitle);
            Name = "UCStoryDetails";
            Size = new Size(2190, 1475);
            Load += UCStoryDetails_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnTitle.ResumeLayout(false);
            pnStar.ResumeLayout(false);
            pnStar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbName;
        private Label lbIsFull;
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
        private Label label10;
        private Label label9;
        private Label lbType;
        private FlowLayoutPanel flowChapter;
        private Label label7;
    }
}
