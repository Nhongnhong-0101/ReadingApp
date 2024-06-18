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
            pcImage.Location = new Point(193, 32);
            pcImage.Name = "pcImage";
            pcImage.Size = new Size(339, 466);
            pcImage.TabIndex = 1;
            pcImage.TabStop = false;
            pcImage.WaitOnLoad = true;
            pcImage.Click += pcImage_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_itemRL;
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
            panel1.Location = new Point(619, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 894);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // tbTitle
            // 
            tbTitle.BackColor = SystemColors.ButtonHighlight;
            tbTitle.BorderStyle = BorderStyle.None;
            tbTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(24, 120);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(628, 24);
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
            lbCountDes.Location = new Point(582, 189);
            lbCountDes.Name = "lbCountDes";
            lbCountDes.Size = new Size(73, 20);
            lbCountDes.TabIndex = 18;
            lbCountDes.Text = "0/1500 từ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(273, 452);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 17;
            // 
            // lbCountTitle
            // 
            lbCountTitle.AutoSize = true;
            lbCountTitle.BackColor = Color.Transparent;
            lbCountTitle.ForeColor = SystemColors.Highlight;
            lbCountTitle.Location = new Point(590, 88);
            lbCountTitle.Name = "lbCountTitle";
            lbCountTitle.Size = new Size(65, 20);
            lbCountTitle.TabIndex = 16;
            lbCountTitle.Text = "0/150 từ";
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(40, 756);
            label9.Name = "label9";
            label9.Size = new Size(528, 47);
            label9.TabIndex = 15;
            label9.Text = "Hãy điền đầy đủ các thông tin có dấu (*)";
            // 
            // btnCreate
            // 
            btnCreate.BackgroundImage = Properties.Resources.bg_btnlogin;
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = SystemColors.ControlLightLight;
            btnCreate.Location = new Point(247, 820);
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
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(423, 643);
            label8.Name = "label8";
            label8.Size = new Size(145, 87);
            label8.TabIndex = 13;
            label8.Text = "Để trống nếu bạn đăng truyện miễn phí";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 702);
            label7.Name = "label7";
            label7.Size = new Size(197, 28);
            label7.TabIndex = 11;
            label7.Text = "Số chương miễn phí";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 639);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 9;
            label6.Text = "Giá dự kiến";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(143, 587);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(168, 31);
            cmbType.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 583);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 7;
            label5.Text = "Thể loại*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 459);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 5;
            label4.Text = "Tác giả*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 182);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 3;
            label3.Text = "Mô tả*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Tiêu đề*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin truyện";
            label1.Click += label1_Click;
            // 
            // tbDes
            // 
            tbDes.BorderStyle = BorderStyle.None;
            tbDes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbDes.Location = new Point(24, 212);
            tbDes.Name = "tbDes";
            tbDes.Size = new Size(628, 213);
            tbDes.TabIndex = 4;
            tbDes.Text = "Đây là mô tả truyên 1";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.bg_search;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(tbAuthor);
            panel4.Location = new Point(24, 490);
            panel4.Name = "panel4";
            panel4.Size = new Size(634, 44);
            panel4.TabIndex = 20;
            // 
            // tbAuthor
            // 
            tbAuthor.BorderStyle = BorderStyle.None;
            tbAuthor.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAuthor.Location = new Point(10, 10);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(612, 24);
            tbAuthor.TabIndex = 6;
            tbAuthor.Text = "Tác giả truyện 1";
            tbAuthor.Enter += tbAuthor_Enter;
            tbAuthor.Leave += tbAuthor_Leave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.bg_search;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(tbPrice);
            panel5.Location = new Point(176, 639);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 40);
            panel5.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.bg_search;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(-207, -2);
            panel6.Name = "panel6";
            panel6.Size = new Size(36, 44);
            panel6.TabIndex = 20;
            // 
            // tbPrice
            // 
            tbPrice.BorderStyle = BorderStyle.None;
            tbPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPrice.Location = new Point(10, 10);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(200, 23);
            tbPrice.TabIndex = 10;
            tbPrice.Text = "0";
            tbPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.bg_search;
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Controls.Add(tbFreeChap);
            panel7.Location = new Point(266, 700);
            panel7.Name = "panel7";
            panel7.Size = new Size(68, 38);
            panel7.TabIndex = 21;
            // 
            // tbFreeChap
            // 
            tbFreeChap.BorderStyle = BorderStyle.None;
            tbFreeChap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbFreeChap.Location = new Point(7, 7);
            tbFreeChap.Name = "tbFreeChap";
            tbFreeChap.Size = new Size(56, 23);
            tbFreeChap.TabIndex = 12;
            tbFreeChap.Text = "0";
            tbFreeChap.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.bg_search;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(21, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 44);
            panel3.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.bg_itemRL;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(rdTT);
            panel2.Controls.Add(rdTC);
            panel2.Location = new Point(193, 522);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 103);
            panel2.TabIndex = 3;
            // 
            // rdTT
            // 
            rdTT.AutoSize = true;
            rdTT.BackColor = Color.Transparent;
            rdTT.Cursor = Cursors.Hand;
            rdTT.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdTT.Location = new Point(34, 54);
            rdTT.Name = "rdTT";
            rdTT.Size = new Size(129, 27);
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
            rdTC.Location = new Point(34, 15);
            rdTC.Name = "rdTC";
            rdTC.Size = new Size(124, 29);
            rdTC.TabIndex = 0;
            rdTC.TabStop = true;
            rdTC.Text = "Truyện chữ";
            rdTC.UseVisualStyleBackColor = false;
            // 
            // pcBack
            // 
            pcBack.BackColor = Color.Transparent;
            pcBack.BackgroundImage = Properties.Resources.icons8_back_64;
            pcBack.BackgroundImageLayout = ImageLayout.Stretch;
            pcBack.Cursor = Cursors.Hand;
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
            Size = new Size(1460, 983);
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
