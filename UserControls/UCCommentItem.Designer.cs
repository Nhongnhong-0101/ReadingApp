namespace ReadingApp.UserControls
{
    partial class UCCommentItem
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
            picStar5 = new PictureBox();
            picStar4 = new PictureBox();
            picStar3 = new PictureBox();
            picStar2 = new PictureBox();
            picStar1 = new PictureBox();
            picAvat = new PictureBox();
            txtComment = new RichTextBox();
            lbUserName = new Label();
            lbTime = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(picStar5);
            panel1.Controls.Add(picStar4);
            panel1.Controls.Add(picStar3);
            panel1.Controls.Add(picStar2);
            panel1.Controls.Add(picStar1);
            panel1.Location = new Point(106, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 29);
            panel1.TabIndex = 17;
            // 
            // picStar5
            // 
            picStar5.BackColor = Color.Transparent;
            picStar5.Image = Properties.Resources.star_gray;
            picStar5.Location = new Point(135, 0);
            picStar5.Name = "picStar5";
            picStar5.Size = new Size(27, 27);
            picStar5.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar5.TabIndex = 7;
            picStar5.TabStop = false;
            // 
            // picStar4
            // 
            picStar4.BackColor = Color.Transparent;
            picStar4.Image = Properties.Resources.star_gray;
            picStar4.Location = new Point(102, 0);
            picStar4.Name = "picStar4";
            picStar4.Size = new Size(27, 27);
            picStar4.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar4.TabIndex = 6;
            picStar4.TabStop = false;
            // 
            // picStar3
            // 
            picStar3.BackColor = Color.Transparent;
            picStar3.Image = Properties.Resources.star_gray;
            picStar3.Location = new Point(69, 0);
            picStar3.Name = "picStar3";
            picStar3.Size = new Size(27, 27);
            picStar3.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar3.TabIndex = 5;
            picStar3.TabStop = false;
            // 
            // picStar2
            // 
            picStar2.BackColor = Color.Transparent;
            picStar2.Image = Properties.Resources.star_gray;
            picStar2.Location = new Point(36, 0);
            picStar2.Name = "picStar2";
            picStar2.Size = new Size(27, 27);
            picStar2.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar2.TabIndex = 4;
            picStar2.TabStop = false;
            // 
            // picStar1
            // 
            picStar1.BackColor = Color.Transparent;
            picStar1.Image = Properties.Resources.star_gray;
            picStar1.Location = new Point(3, 0);
            picStar1.Name = "picStar1";
            picStar1.Size = new Size(27, 27);
            picStar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar1.TabIndex = 3;
            picStar1.TabStop = false;
            // 
            // picAvat
            // 
            picAvat.BackColor = Color.Transparent;
            picAvat.Image = Properties.Resources.avat_default;
            picAvat.Location = new Point(0, 0);
            picAvat.Name = "picAvat";
            picAvat.Size = new Size(100, 100);
            picAvat.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvat.TabIndex = 16;
            picAvat.TabStop = false;
            // 
            // txtComment
            // 
            txtComment.BackColor = Color.White;
            txtComment.BorderStyle = BorderStyle.None;
            txtComment.Location = new Point(109, 65);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(513, 71);
            txtComment.TabIndex = 18;
            txtComment.Text = "comment nè ";
            // 
            // lbUserName
            // 
            lbUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUserName.ForeColor = Color.Black;
            lbUserName.Location = new Point(106, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(529, 36);
            lbUserName.TabIndex = 19;
            lbUserName.Text = "Nhớ mãi không quên";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.ForeColor = Color.Gray;
            lbTime.Location = new Point(295, 32);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(117, 30);
            lbTime.TabIndex = 20;
            lbTime.Text = "13/06/2024";
            // 
            // UCCommentItem
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbTime);
            Controls.Add(lbUserName);
            Controls.Add(txtComment);
            Controls.Add(panel1);
            Controls.Add(picAvat);
            Name = "UCCommentItem";
            Size = new Size(635, 146);
            Load += UCCommentItem_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picStar5;
        private PictureBox picStar4;
        private PictureBox picStar3;
        private PictureBox picStar2;
        private PictureBox picStar1;
        private PictureBox picAvat;
        private RichTextBox txtComment;
        private Label lbUserName;
        private Label lbTime;
    }
}
