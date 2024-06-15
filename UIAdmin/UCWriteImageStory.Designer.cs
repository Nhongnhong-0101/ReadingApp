namespace ReadingApp.UIAdmin
{
    partial class UCWriteImageStory
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
            lbNumChapter = new Label();
            tbTitle = new TextBox();
            lbCountWord = new Label();
            pnImages = new Panel();
            btnAddImage = new Button();
            btnSave = new Button();
            btnNew = new Button();
            SuspendLayout();
            // 
            // lbNumChapter
            // 
            lbNumChapter.AutoSize = true;
            lbNumChapter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumChapter.Location = new Point(24, 18);
            lbNumChapter.Name = "lbNumChapter";
            lbNumChapter.Size = new Size(125, 28);
            lbNumChapter.TabIndex = 5;
            lbNumChapter.Text = "Chương số 1";
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(268, 56);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(463, 24);
            tbTitle.TabIndex = 6;
            tbTitle.Text = "Tiêu đề của chương";
            tbTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // lbCountWord
            // 
            lbCountWord.AutoSize = true;
            lbCountWord.ForeColor = SystemColors.Highlight;
            lbCountWord.Location = new Point(24, 101);
            lbCountWord.Name = "lbCountWord";
            lbCountWord.Size = new Size(71, 20);
            lbCountWord.TabIndex = 7;
            lbCountWord.Text = "0/30 hình";
            // 
            // pnImages
            // 
            pnImages.AutoScroll = true;
            pnImages.BackColor = SystemColors.AppWorkspace;
            pnImages.Location = new Point(80, 133);
            pnImages.Name = "pnImages";
            pnImages.Padding = new Padding(0, 20, 0, 20);
            pnImages.Size = new Size(850, 590);
            pnImages.TabIndex = 8;
            // 
            // btnAddImage
            // 
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Location = new Point(305, 742);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(94, 29);
            btnAddImage.TabIndex = 2;
            btnAddImage.Text = "Thêm hình";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(579, 742);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Đăng tải";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(829, 87);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(101, 34);
            btnNew.TabIndex = 10;
            btnNew.Text = "Chương mới";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // UCWriteImageStory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(btnAddImage);
            Controls.Add(pnImages);
            Controls.Add(lbCountWord);
            Controls.Add(tbTitle);
            Controls.Add(lbNumChapter);
            Name = "UCWriteImageStory";
            Size = new Size(1000, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumChapter;
        private TextBox tbTitle;
        private Label lbCountWord;
        private Panel pnImages;
        private Button btnAddImage;
        private Button btnSave;
        private Button btnNew;
    }
}
