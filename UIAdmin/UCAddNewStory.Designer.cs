namespace ReadingApp.UIAdmin
{
    partial class UCAddNewStory
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
            pcImage = new PictureBox();
            panel1 = new Panel();
            lbCountDes = new Label();
            label10 = new Label();
            lbCountTitle = new Label();
            label9 = new Label();
            btnCreate = new Button();
            label8 = new Label();
            tbFreeChap = new TextBox();
            label7 = new Label();
            tbPrice = new TextBox();
            label6 = new Label();
            cmbType = new ComboBox();
            label5 = new Label();
            tbAuthor = new TextBox();
            label4 = new Label();
            tbDes = new RichTextBox();
            label3 = new Label();
            tbTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            rdTT = new RadioButton();
            rdTC = new RadioButton();
            pcBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcImage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBack).BeginInit();
            SuspendLayout();
            // 
            // pcImage
            // 
            pcImage.BackColor = SystemColors.ControlLight;
            pcImage.BackgroundImage = Properties.Resources.image;
            pcImage.BackgroundImageLayout = ImageLayout.Zoom;
            pcImage.Cursor = Cursors.Hand;
            pcImage.Location = new Point(51, 77);
            pcImage.Name = "pcImage";
            pcImage.Size = new Size(300, 420);
            pcImage.TabIndex = 1;
            pcImage.TabStop = false;
            pcImage.WaitOnLoad = true;
            pcImage.Click += pcImage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbCountDes);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lbCountTitle);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tbFreeChap);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbPrice);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbAuthor);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbDes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(395, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 728);
            panel1.TabIndex = 2;
            // 
            // lbCountDes
            // 
            lbCountDes.AutoSize = true;
            lbCountDes.ForeColor = SystemColors.Highlight;
            lbCountDes.Location = new Point(484, 165);
            lbCountDes.Name = "lbCountDes";
            lbCountDes.Size = new Size(65, 20);
            lbCountDes.TabIndex = 18;
            lbCountDes.Text = "0/500 từ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(254, 354);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 17;
            // 
            // lbCountTitle
            // 
            lbCountTitle.AutoSize = true;
            lbCountTitle.ForeColor = SystemColors.Highlight;
            lbCountTitle.Location = new Point(489, 88);
            lbCountTitle.Name = "lbCountTitle";
            lbCountTitle.Size = new Size(65, 20);
            lbCountTitle.TabIndex = 16;
            lbCountTitle.Text = "0/150 từ";
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(21, 607);
            label9.Name = "label9";
            label9.Size = new Size(528, 47);
            label9.TabIndex = 15;
            label9.Text = "Hãy điền đầy đủ các thông tin có dấu (*)";
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources.bg_btnlogin;
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(187, 657);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(210, 57);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Tạo truyện";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(404, 494);
            label8.Name = "label8";
            label8.Size = new Size(145, 87);
            label8.TabIndex = 13;
            label8.Text = "Để trống nếu bạn đăng truyện miễn phí";
            // 
            // tbFreeChap
            // 
            tbFreeChap.BorderStyle = BorderStyle.None;
            tbFreeChap.Location = new Point(247, 541);
            tbFreeChap.Name = "tbFreeChap";
            tbFreeChap.Size = new Size(56, 20);
            tbFreeChap.TabIndex = 12;
            tbFreeChap.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 540);
            label7.Name = "label7";
            label7.Size = new Size(197, 28);
            label7.TabIndex = 11;
            label7.Text = "Số chương miễn phí";
            // 
            // tbPrice
            // 
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Location = new Point(168, 494);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(202, 20);
            tbPrice.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 490);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 9;
            label6.Text = "Giá dự kiến";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(124, 438);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(168, 28);
            cmbType.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 434);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 7;
            label5.Text = "Thể loại  *";
            // 
            // tbAuthor
            // 
            tbAuthor.BorderStyle = BorderStyle.None;
            tbAuthor.Location = new Point(24, 392);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(525, 20);
            tbAuthor.TabIndex = 6;
            tbAuthor.Text = "Tác giả truyện 1";
            tbAuthor.Enter += tbAuthor_Enter;
            tbAuthor.Leave += tbAuthor_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 361);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 5;
            label4.Text = "Tác giả *";
            // 
            // tbDes
            // 
            tbDes.BorderStyle = BorderStyle.None;
            tbDes.Location = new Point(21, 189);
            tbDes.Name = "tbDes";
            tbDes.Size = new Size(528, 148);
            tbDes.TabIndex = 4;
            tbDes.Text = "Đây là mô tả truyên 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 158);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 3;
            label3.Text = "Mô tả *";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(21, 111);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(533, 27);
            tbTitle.TabIndex = 2;
            tbTitle.Text = "Tiêu đề truyện 1";
            tbTitle.Click += tbTitle_Click;
            tbTitle.Enter += tbTitle_Enter;
            tbTitle.Leave += tbTitle_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Tiêu đề *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin truyện";
            // 
            // panel2
            // 
            panel2.Controls.Add(rdTT);
            panel2.Controls.Add(rdTC);
            panel2.Location = new Point(45, 524);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 125);
            panel2.TabIndex = 3;
            // 
            // rdTT
            // 
            rdTT.AutoSize = true;
            rdTT.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTT.Location = new Point(34, 65);
            rdTT.Name = "rdTT";
            rdTT.Size = new Size(129, 27);
            rdTT.TabIndex = 1;
            rdTT.TabStop = true;
            rdTT.Text = "Truyện tranh";
            rdTT.UseVisualStyleBackColor = true;
            // 
            // rdTC
            // 
            rdTC.AutoSize = true;
            rdTC.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTC.Location = new Point(34, 26);
            rdTC.Name = "rdTC";
            rdTC.Size = new Size(124, 29);
            rdTC.TabIndex = 0;
            rdTC.TabStop = true;
            rdTC.Text = "Truyện chữ";
            rdTC.UseVisualStyleBackColor = true;
            // 
            // pcBack
            // 
            pcBack.BackColor = SystemColors.ActiveCaption;
            pcBack.BackgroundImageLayout = ImageLayout.Stretch;
            pcBack.Location = new Point(28, 17);
            pcBack.Name = "pcBack";
            pcBack.Size = new Size(36, 35);
            pcBack.TabIndex = 4;
            pcBack.TabStop = false;
            pcBack.Click += pcBack_Click;
            // 
            // UCAddNewStory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pcBack);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pcImage);
            Name = "UCAddNewStory";
            Size = new Size(1000, 800);
            ((System.ComponentModel.ISupportInitialize)pcImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcBack).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcImage;
        private Panel panel1;
        private TextBox tbAuthor;
        private Label label4;
        private RichTextBox tbDes;
        private Label label3;
        private TextBox tbTitle;
        private Label label2;
        private Label label1;
        private ComboBox cmbType;
        private Label label5;
        private Label label7;
        private TextBox tbPrice;
        private Label label6;
        private Label label8;
        private TextBox tbFreeChap;
        private Button btnCreate;
        private Label label9;
        private Panel panel2;
        private RadioButton rdTT;
        private RadioButton rdTC;
        private PictureBox pcBack;
        private Label lbCountTitle;
        private Label lbCountDes;
        private Label label10;
    }
}
