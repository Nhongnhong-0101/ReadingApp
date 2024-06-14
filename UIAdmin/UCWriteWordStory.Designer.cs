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
            btnNew = new Button();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(265, 72);
            tbTitle.Multiline = true;
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(463, 27);
            tbTitle.TabIndex = 0;
            tbTitle.Text = "Tiêu đề của chương";
            tbTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // rtbContent
            // 
            rtbContent.BorderStyle = BorderStyle.FixedSingle;
            rtbContent.Location = new Point(21, 141);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(960, 586);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            rtbContent.TextChanged += rtbContent_TextChanged;
            // 
            // lbCountWord
            // 
            lbCountWord.AutoSize = true;
            lbCountWord.ForeColor = SystemColors.Highlight;
            lbCountWord.Location = new Point(24, 103);
            lbCountWord.Name = "lbCountWord";
            lbCountWord.Size = new Size(72, 20);
            lbCountWord.TabIndex = 2;
            lbCountWord.Text = "0/ 500 Từ";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(451, 748);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 35);
            btnSave.TabIndex = 3;
            btnSave.Text = "Đăng tải";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbNumChapter
            // 
            lbNumChapter.AutoSize = true;
            lbNumChapter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumChapter.Location = new Point(24, 18);
            lbNumChapter.Name = "lbNumChapter";
            lbNumChapter.Size = new Size(125, 28);
            lbNumChapter.TabIndex = 4;
            lbNumChapter.Text = "Chương số 1";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(880, 101);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(101, 34);
            btnNew.TabIndex = 11;
            btnNew.Text = "Chương mới";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // UCWriteWordStory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNew);
            Controls.Add(lbNumChapter);
            Controls.Add(btnSave);
            Controls.Add(lbCountWord);
            Controls.Add(rtbContent);
            Controls.Add(tbTitle);
            Name = "UCWriteWordStory";
            Size = new Size(1000, 800);
            Load += UCWriteWordStory_Load;
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
        private Button btnNew;
    }
}
