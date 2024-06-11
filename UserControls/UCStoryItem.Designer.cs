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
            label1 = new Label();
            picStar = new PictureBox();
            pictureBox5 = new PictureBox();
            lbIsFull = new Label();
            lbName = new Label();
            lbAuthor = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            pnStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.Image = Properties.Resources.temp_image_story;
            picImage.Location = new Point(33, 0);
            picImage.Name = "picImage";
            picImage.Size = new Size(390, 530);
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            picImage.Click += UCStoryItem_Click;
            // 
            // pnStar
            // 
            pnStar.Controls.Add(label1);
            pnStar.Controls.Add(picStar);
            pnStar.Location = new Point(33, 532);
            pnStar.Name = "pnStar";
            pnStar.Size = new Size(102, 40);
            pnStar.TabIndex = 1;
            pnStar.Click += UCStoryItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(42, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 36);
            label1.TabIndex = 4;
            label1.Text = "3.5";
            label1.Click += UCStoryItem_Click;
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
            picStar.Click += UCStoryItem_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.cost;
            pictureBox5.Location = new Point(141, 532);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += UCStoryItem_Click;
            // 
            // lbIsFull
            // 
            lbIsFull.BackColor = Color.Green;
            lbIsFull.Font = new Font("Segoe UI", 11F);
            lbIsFull.ForeColor = Color.White;
            lbIsFull.Location = new Point(33, 0);
            lbIsFull.Name = "lbIsFull";
            lbIsFull.Size = new Size(80, 40);
            lbIsFull.TabIndex = 5;
            lbIsFull.Text = "Full";
            lbIsFull.TextAlign = ContentAlignment.MiddleCenter;
            lbIsFull.Click += UCStoryItem_Click;
            // 
            // lbName
            // 
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbName.Location = new Point(33, 575);
            lbName.Name = "lbName";
            lbName.Size = new Size(390, 40);
            lbName.TabIndex = 6;
            lbName.Text = "Nhớ mãi không quên";
            lbName.Click += UCStoryItem_Click;
            // 
            // lbAuthor
            // 
            lbAuthor.Font = new Font("Segoe UI", 10F);
            lbAuthor.ForeColor = Color.Gray;
            lbAuthor.Location = new Point(38, 615);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(385, 30);
            lbAuthor.TabIndex = 7;
            lbAuthor.Text = "Thiên Hạ Thủy";
            lbAuthor.Click += UCStoryItem_Click;
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
            Size = new Size(423, 658);
            Click += UCStoryItem_Click;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            pnStar.ResumeLayout(false);
            pnStar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImage;
        private Panel pnStar;
        private PictureBox picStar;
        private PictureBox pictureBox5;
        private Label lbIsFull;
        private Label lbName;
        private Label lbAuthor;
        private Label label1;
    }
}
