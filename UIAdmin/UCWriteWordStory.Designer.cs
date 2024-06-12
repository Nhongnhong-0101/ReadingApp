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
            label1 = new Label();
            btnSave = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(265, 72);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(463, 24);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(24, 103);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "0/ 500 Từ";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 18);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 4;
            label2.Text = "Chương số 1";
            // 
            // UCWriteWordStory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(rtbContent);
            Controls.Add(tbTitle);
            Name = "UCWriteWordStory";
            Size = new Size(1000, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitle;
        private RichTextBox rtbContent;
        private Label label1;
        private Button btnSave;
        private Label label2;
    }
}
