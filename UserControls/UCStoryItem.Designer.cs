namespace ReadingApp.UserControls
{
    partial class UCStoryItem
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
            picImage = new PictureBox();
            pnStar = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picHomeTab = new PictureBox();
            pictureBox5 = new PictureBox();
            lbIsFull = new Label();
            lbName = new Label();
            lbAuthor = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHomeTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.Image = Properties.Resources.temp_image_story;
            picImage.Location = new Point(35, 0);
            picImage.Name = "picImage";
            picImage.Size = new Size(390, 530);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            // 
            // pnStar
            // 
            pnStar.Controls.Add(pictureBox4);
            pnStar.Controls.Add(pictureBox3);
            pnStar.Controls.Add(pictureBox2);
            pnStar.Controls.Add(pictureBox1);
            pnStar.Controls.Add(picHomeTab);
            pnStar.Location = new Point(35, 532);
            pnStar.Name = "pnStar";
            pnStar.Size = new Size(220, 40);
            pnStar.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.star;
            pictureBox4.Location = new Point(180, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.star;
            pictureBox3.Location = new Point(135, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.star;
            pictureBox2.Location = new Point(90, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.star;
            pictureBox1.Location = new Point(45, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // picHomeTab
            // 
            picHomeTab.BackColor = Color.Transparent;
            picHomeTab.Image = Properties.Resources.star;
            picHomeTab.Location = new Point(0, 0);
            picHomeTab.Name = "picHomeTab";
            picHomeTab.Size = new Size(40, 40);
            picHomeTab.SizeMode = PictureBoxSizeMode.StretchImage;
            picHomeTab.TabIndex = 3;
            picHomeTab.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.cost;
            pictureBox5.Location = new Point(385, 532);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // lbIsFull
            // 
            lbIsFull.BackColor = Color.Green;
            lbIsFull.Font = new Font("Segoe UI", 11F);
            lbIsFull.ForeColor = Color.White;
            lbIsFull.Location = new Point(35, 0);
            lbIsFull.Name = "lbIsFull";
            lbIsFull.Size = new Size(80, 40);
            lbIsFull.TabIndex = 5;
            lbIsFull.Text = "Full";
            lbIsFull.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbName.Location = new Point(35, 575);
            lbName.Name = "lbName";
            lbName.Size = new Size(390, 40);
            lbName.TabIndex = 6;
            lbName.Text = "Nhớ mãi không quên";
            // 
            // lbAuthor
            // 
            lbAuthor.Font = new Font("Segoe UI", 10F);
            lbAuthor.ForeColor = Color.Gray;
            lbAuthor.Location = new Point(40, 615);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(385, 30);
            lbAuthor.TabIndex = 7;
            lbAuthor.Text = "Thiên Hạ Thủy";
            // 
            // UCStoryItem
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lbAuthor);
            Controls.Add(lbName);
            Controls.Add(lbIsFull);
            Controls.Add(pictureBox5);
            Controls.Add(pnStar);
            Controls.Add(picImage);
            Name = "UCStoryItem";
            Size = new Size(425, 658);
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnStar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHomeTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImage;
        private Panel pnStar;
        private PictureBox picHomeTab;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Label lbIsFull;
        private Label lbName;
        private Label lbAuthor;
    }
}
