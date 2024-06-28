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
            tbTitle = new TextBox();
            lbCountDes = new Label();
            label10 = new Label();
            lbCountTitle = new Label();
            label9 = new Label();
            btnCreate = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cmbType = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbDes = new RichTextBox();
            panel4 = new Panel();
            tbAuthor = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            tbPrice = new TextBox();
            panel7 = new Panel();
            tbFreeChap = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            rdTT = new RadioButton();
            rdTC = new RadioButton();
            pcBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcImage).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcBack).BeginInit();
            SuspendLayout();
            // 
            // pcImage
            // 
            pcImage.BackColor = SystemColors.ControlLight;
            pcImage.BackgroundImage = Properties.Resources.image;
            pcImage.BackgroundImageLayout = ImageLayout.Stretch;
            pcImage.Cursor = Cursors.Hand;
            pcImage.Location = new Point(290, 48);
            pcImage.Margin = new Padding(4, 4, 4, 4);
            pcImage.Name = "pcImage";
            pcImage.Size = new Size(508, 699);
            pcImage.TabIndex = 1;
            pcImage.TabStop = false;
            pcImage.WaitOnLoad = true;
            pcImage.Click += pcImage_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_addStory;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tbTitle);
            panel1.Controls.Add(lbCountDes);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lbCountTitle);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbDes);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(928, 48);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 1340);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // tbTitle
            // 
            tbTitle.BackColor = SystemColors.ButtonHighlight;
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(36, 180);
            tbTitle.Margin = new Padding(4, 4, 4, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(942, 34);
            tbTitle.TabIndex = 2;
            tbTitle.Text = "Tiêu đề truyện 1";
            tbTitle.Click += tbTitle_Click;
            tbTitle.Enter += tbTitle_Enter;
            tbTitle.Leave += tbTitle_Leave;
            // 
            // lbCountDes
            // 
            lbCountDes.AutoSize = true;
            lbCountDes.BackColor = Color.Transparent;
            lbCountDes.ForeColor = SystemColors.Highlight;
            lbCountDes.Location = new Point(873, 284);
            lbCountDes.Margin = new Padding(4, 0, 4, 0);
            lbCountDes.Name = "lbCountDes";
            lbCountDes.Size = new Size(101, 30);
            lbCountDes.TabIndex = 18;
            lbCountDes.Text = "0/1500 từ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(410, 678);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 30);
            label10.TabIndex = 17;
            // 
            // lbCountTitle
            // 
            lbCountTitle.AutoSize = true;
            lbCountTitle.BackColor = Color.Transparent;
            lbCountTitle.ForeColor = SystemColors.Highlight;
            lbCountTitle.Location = new Point(885, 132);
            lbCountTitle.Margin = new Padding(4, 0, 4, 0);
            lbCountTitle.Name = "lbCountTitle";
            lbCountTitle.Size = new Size(90, 30);
            lbCountTitle.TabIndex = 16;
            lbCountTitle.Text = "0/150 từ";
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(60, 1134);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(792, 70);
            label9.TabIndex = 15;
            label9.Text = "Hãy điền đầy đủ các thông tin có dấu (*)";
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources.bg_btnlogin;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(370, 1230);
            btnCreate.Margin = new Padding(4, 4, 4, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(315, 86);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Tạo truyện";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(634, 964);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(218, 130);
            label8.TabIndex = 13;
            label8.Text = "Để trống nếu bạn đăng truyện miễn phí";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 1053);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(272, 38);
            label7.TabIndex = 11;
            label7.Text = "Số chương miễn phí";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(60, 958);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(162, 38);
            label6.TabIndex = 9;
            label6.Text = "Giá dự kiến";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(214, 880);
            cmbType.Margin = new Padding(4, 4, 4, 4);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 40);
            cmbType.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 874);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 38);
            label5.TabIndex = 7;
            label5.Text = "Thể loại*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 688);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 38);
            label4.TabIndex = 5;
            label4.Text = "Tác giả*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 273);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 38);
            label3.TabIndex = 3;
            label3.Text = "Mô tả*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "Tiêu đề*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 45);
            label1.TabIndex = 0;
            label1.Text = "Thông tin truyện";
            label1.Click += label1_Click;
            // 
            // tbDes
            // 
            tbDes.BorderStyle = BorderStyle.None;
            tbDes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbDes.Location = new Point(36, 318);
            tbDes.Margin = new Padding(4, 4, 4, 4);
            tbDes.Name = "tbDes";
            tbDes.Size = new Size(942, 320);
            tbDes.TabIndex = 4;
            tbDes.Text = "Đây là mô tả truyên 1";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImage = Properties.Resources.bg_search;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(tbAuthor);
            panel4.Location = new Point(36, 735);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(951, 66);
            panel4.TabIndex = 20;
            // 
            // tbAuthor
            // 
            tbAuthor.BorderStyle = BorderStyle.None;
            tbAuthor.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAuthor.Location = new Point(15, 15);
            tbAuthor.Margin = new Padding(4, 4, 4, 4);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(918, 34);
            tbAuthor.TabIndex = 6;
            tbAuthor.Text = "Tác giả truyện 1";
            tbAuthor.Enter += tbAuthor_Enter;
            tbAuthor.Leave += tbAuthor_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BackgroundImage = Properties.Resources.bg_search;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(tbPrice);
            panel5.Location = new Point(264, 958);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 60);
            panel5.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.bg_search;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(-310, -3);
            panel6.Margin = new Padding(4, 4, 4, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(54, 66);
            panel6.TabIndex = 20;
            // 
            // tbPrice
            // 
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(15, 15);
            tbPrice.Margin = new Padding(4, 4, 4, 4);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(300, 32);
            tbPrice.TabIndex = 10;
            tbPrice.Text = "0";
            tbPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BackgroundImage = Properties.Resources.bg_search;
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Controls.Add(tbFreeChap);
            panel7.Location = new Point(399, 1050);
            panel7.Margin = new Padding(4, 4, 4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(102, 57);
            panel7.TabIndex = 21;
            // 
            // tbFreeChap
            // 
            tbFreeChap.BorderStyle = BorderStyle.None;
            tbFreeChap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbFreeChap.Location = new Point(10, 10);
            tbFreeChap.Margin = new Padding(4, 4, 4, 4);
            tbFreeChap.Name = "tbFreeChap";
            tbFreeChap.Size = new Size(84, 32);
            tbFreeChap.TabIndex = 12;
            tbFreeChap.Text = "0";
            tbFreeChap.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.bg_search;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(32, 166);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(951, 66);
            panel3.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.bg_itemRL;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(rdTT);
            panel2.Controls.Add(rdTC);
            panel2.Location = new Point(290, 783);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 154);
            panel2.TabIndex = 3;
            // 
            // rdTT
            // 
            rdTT.AutoSize = true;
            rdTT.BackColor = Color.Transparent;
            rdTT.Cursor = Cursors.Hand;
            rdTT.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTT.Location = new Point(51, 81);
            rdTT.Margin = new Padding(4, 4, 4, 4);
            rdTT.Name = "rdTT";
            rdTT.Size = new Size(178, 36);
            rdTT.TabIndex = 1;
            rdTT.TabStop = true;
            rdTT.Text = "Truyện tranh";
            rdTT.UseVisualStyleBackColor = false;
            // 
            // rdTC
            // 
            rdTC.AutoSize = true;
            rdTC.BackColor = Color.Transparent;
            rdTC.Cursor = Cursors.Hand;
            rdTC.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTC.Location = new Point(51, 22);
            rdTC.Margin = new Padding(4, 4, 4, 4);
            rdTC.Name = "rdTC";
            rdTC.Size = new Size(169, 40);
            rdTC.TabIndex = 0;
            rdTC.TabStop = true;
            rdTC.Text = "Truyện chữ";
            rdTC.UseVisualStyleBackColor = false;
            // 
            // pcBack
            // 
            pcBack.BackColor = Color.Transparent;
            pcBack.BackgroundImage = Properties.Resources.back2;
            pcBack.BackgroundImageLayout = ImageLayout.Stretch;
            pcBack.Cursor = Cursors.Hand;
            pcBack.Location = new Point(42, 26);
            pcBack.Margin = new Padding(4, 4, 4, 4);
            pcBack.Name = "pcBack";
            pcBack.Size = new Size(54, 52);
            pcBack.TabIndex = 4;
            pcBack.TabStop = false;
            pcBack.Click += pcBack_Click;
            // 
            // UCAddNewStory
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pcBack);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pcImage);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UCAddNewStory";
            Size = new Size(2190, 1474);
            ((System.ComponentModel.ISupportInitialize)pcImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}
