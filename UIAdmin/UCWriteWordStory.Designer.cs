namespace ReadingApp.UIAdmin
{
    partial class UCWriteWordStory
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
            tbTitle = new TextBox();
            rtbContent = new RichTextBox();
            lbCountWord = new Label();
            btnSave = new Button();
            lbNumChapter = new Label();
            pcBack = new PictureBox();
            tbStt = new TextBox();
            btnDel = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pcBack).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(21, 10);
            tbTitle.Multiline = true;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(603, 40);
            tbTitle.TabIndex = 0;
            tbTitle.Text = "Tiêu đề của chương";
            tbTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // rtbContent
            // 
            rtbContent.BorderStyle = BorderStyle.FixedSingle;
            rtbContent.Location = new Point(21, 118);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(1415, 774);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            rtbContent.TextChanged += rtbContent_TextChanged;
            // 
            // lbCountWord
            // 
            lbCountWord.AutoSize = true;
            lbCountWord.ForeColor = SystemColors.Highlight;
            lbCountWord.Location = new Point(24, 80);
            lbCountWord.Name = "lbCountWord";
            lbCountWord.Size = new Size(80, 20);
            lbCountWord.TabIndex = 2;
            lbCountWord.Text = "0/ 3000 Từ";
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.bg_btnlogin;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(706, 914);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 45);
            btnSave.TabIndex = 3;
            btnSave.Text = "Đăng tải";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbNumChapter
            // 
            lbNumChapter.AutoSize = true;
            lbNumChapter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumChapter.Location = new Point(95, 16);
            lbNumChapter.Name = "lbNumChapter";
            lbNumChapter.Size = new Size(126, 28);
            lbNumChapter.TabIndex = 4;
            lbNumChapter.Text = "Chương số* ";
            // 
            // pcBack
            // 
            pcBack.BackgroundImage = Properties.Resources.icons8_back_64;
            pcBack.BackgroundImageLayout = ImageLayout.Stretch;
            pcBack.Location = new Point(24, 16);
            pcBack.Name = "pcBack";
            pcBack.Size = new Size(35, 35);
            pcBack.TabIndex = 12;
            pcBack.TabStop = false;
            pcBack.Click += pictureBox1_Click;
            // 
            // tbStt
            // 
            tbStt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbStt.Location = new Point(227, 16);
            tbStt.Name = "tbStt";
            tbStt.Size = new Size(55, 31);
            tbStt.TabIndex = 13;
            // 
            // btnDel
            // 
            btnDel.BackgroundImage = Properties.Resources.bg_search;
            btnDel.BackgroundImageLayout = ImageLayout.Stretch;
            btnDel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(1342, 65);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 40);
            btnDel.TabIndex = 14;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_search;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tbTitle);
            panel1.Location = new Point(422, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 53);
            panel1.TabIndex = 15;
            // 
            // UCWriteWordStory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnDel);
            Controls.Add(tbStt);
            Controls.Add(pcBack);
            Controls.Add(lbNumChapter);
            Controls.Add(btnSave);
            Controls.Add(lbCountWord);
            Controls.Add(rtbContent);
            Name = "UCWriteWordStory";
            Size = new Size(1460, 983);
            Load += UCWriteWordStory_Load;
            ((System.ComponentModel.ISupportInitialize)pcBack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitle;
        private RichTextBox rtbContent;
        private Label label1;
        private Button btnSave;
        private Label lbNumChapter;
        private Label lbCountWord;
        private PictureBox pcBack;
        private TextBox tbStt;
        private Button btnDel;
        private Panel panel1;
    }
}
