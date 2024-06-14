namespace ReadingApp.UserControls
{
    partial class UCReadingListItem
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
            panel1 = new Panel();
            picTick = new PictureBox();
            txtName = new TextBox();
            picMore = new PictureBox();
            pnMore = new Panel();
            picCancle = new PictureBox();
            picEdit = new PictureBox();
            picDelete = new PictureBox();
            lbCount = new Label();
            lbUpdating = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMore).BeginInit();
            pnMore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCancle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDelete).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(226, 239, 226);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(picTick);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(picMore);
            panel1.Controls.Add(pnMore);
            panel1.Controls.Add(lbCount);
            panel1.Controls.Add(lbUpdating);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 100);
            panel1.TabIndex = 0;
            panel1.Click += UCReadingListItem_Click;
            // 
            // picTick
            // 
            picTick.Image = Properties.Resources.style_fill_50;
            picTick.Location = new Point(603, 22);
            picTick.Name = "picTick";
            picTick.Size = new Size(50, 50);
            picTick.SizeMode = PictureBoxSizeMode.StretchImage;
            picTick.TabIndex = 13;
            picTick.TabStop = false;
            picTick.Visible = false;
            picTick.Click += picTick_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(226, 239, 226);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(17, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(455, 41);
            txtName.TabIndex = 12;
            txtName.Text = "hug";
            txtName.Click += UCReadingListItem_Click;
            // 
            // picMore
            // 
            picMore.Image = Properties.Resources.style_sharp_50;
            picMore.Location = new Point(614, 22);
            picMore.Name = "picMore";
            picMore.Size = new Size(50, 50);
            picMore.SizeMode = PictureBoxSizeMode.StretchImage;
            picMore.TabIndex = 11;
            picMore.TabStop = false;
            picMore.Click += picMore_Click;
            // 
            // pnMore
            // 
            pnMore.Controls.Add(picCancle);
            pnMore.Controls.Add(picEdit);
            pnMore.Controls.Add(picDelete);
            pnMore.Location = new Point(478, 10);
            pnMore.Name = "pnMore";
            pnMore.Size = new Size(168, 75);
            pnMore.TabIndex = 8;
            pnMore.Visible = false;
            pnMore.Click += UCReadingListItem_Click;
            // 
            // picCancle
            // 
            picCancle.Image = Properties.Resources.style_fill_cancle;
            picCancle.Location = new Point(115, 12);
            picCancle.Name = "picCancle";
            picCancle.Size = new Size(50, 50);
            picCancle.SizeMode = PictureBoxSizeMode.StretchImage;
            picCancle.TabIndex = 11;
            picCancle.TabStop = false;
            picCancle.Click += picCancle_Click;
            // 
            // picEdit
            // 
            picEdit.Image = Properties.Resources.pen_50;
            picEdit.Location = new Point(3, 12);
            picEdit.Name = "picEdit";
            picEdit.Size = new Size(50, 50);
            picEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            picEdit.TabIndex = 10;
            picEdit.TabStop = false;
            picEdit.Click += picEdit_Click;
            // 
            // picDelete
            // 
            picDelete.Image = Properties.Resources.trash_50;
            picDelete.Location = new Point(59, 12);
            picDelete.Name = "picDelete";
            picDelete.Size = new Size(50, 50);
            picDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            picDelete.TabIndex = 9;
            picDelete.TabStop = false;
            picDelete.Click += picDelete_Click;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 9F);
            lbCount.ForeColor = Color.Gray;
            lbCount.Location = new Point(114, 55);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(24, 30);
            lbCount.TabIndex = 7;
            lbCount.Text = "2";
            lbCount.Click += UCReadingListItem_Click;
            // 
            // lbUpdating
            // 
            lbUpdating.AutoSize = true;
            lbUpdating.Font = new Font("Segoe UI", 9F);
            lbUpdating.ForeColor = Color.Gray;
            lbUpdating.Location = new Point(15, 55);
            lbUpdating.Name = "lbUpdating";
            lbUpdating.Size = new Size(112, 30);
            lbUpdating.TabIndex = 6;
            lbUpdating.Text = "Số truyện: ";
            lbUpdating.Click += UCReadingListItem_Click;
            // 
            // UCReadingListItem
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "UCReadingListItem";
            Size = new Size(670, 120);
            Load += UCReadingListItem_Load;
            Click += UCReadingListItem_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTick).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMore).EndInit();
            pnMore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCancle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Label lbReadlingListName;
        private Label lbUpdating;
        private Panel pnMore;
        private Label lbCount;
        private PictureBox picEdit;
        private PictureBox picDelete;
        private PictureBox picMore;
        public TextBox txtName;
        private PictureBox picTick;
        private PictureBox picCancle;
    }
}
