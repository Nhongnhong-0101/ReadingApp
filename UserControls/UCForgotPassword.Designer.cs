namespace ReadingApp.UserControls
{
    partial class UCForgotPassword
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lbInfor = new Label();
            lbCancle = new Label();
            label4 = new Label();
            btnSend = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtEmail = new TextBox();
            lbType = new Label();
            lbAccountTab = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_login;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbInfor);
            panel1.Controls.Add(lbCancle);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbAccountTab);
            panel1.Location = new Point(980, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 433);
            panel1.TabIndex = 1;
            // 
            // lbInfor
            // 
            lbInfor.BackColor = Color.Transparent;
            lbInfor.Font = new Font("Segoe UI", 8F);
            lbInfor.ForeColor = Color.Red;
            lbInfor.Location = new Point(-3, 291);
            lbInfor.Name = "lbInfor";
            lbInfor.Size = new Size(640, 25);
            lbInfor.TabIndex = 17;
            lbInfor.Text = "Đăng ký không thành công!";
            lbInfor.TextAlign = ContentAlignment.MiddleCenter;
            lbInfor.Visible = false;
            // 
            // lbCancle
            // 
            lbCancle.AutoSize = true;
            lbCancle.BackColor = Color.Transparent;
            lbCancle.Font = new Font("Segoe UI", 12F);
            lbCancle.ForeColor = Color.DarkGreen;
            lbCancle.Location = new Point(532, 333);
            lbCancle.Name = "lbCancle";
            lbCancle.Size = new Size(67, 38);
            lbCancle.TabIndex = 11;
            lbCancle.Text = "Hủy";
            lbCancle.Click += lbCancle_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(50, 89);
            label4.Name = "label4";
            label4.Size = new Size(577, 79);
            label4.TabIndex = 10;
            label4.Text = "Mật khẩu mới sẽ được gửi đến email của bạn. Vui lòng nhập email!";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Transparent;
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Image = Properties.Resources.bg_btnlogin;
            btnSend.Location = new Point(150, 320);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(350, 65);
            btnSend.TabIndex = 0;
            btnSend.Text = "Gửi mật khẩu";
            btnSend.TextAlign = ContentAlignment.MiddleCenter;
            btnSend.Click += btnSend_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbType);
            panel2.Location = new Point(0, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 116);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(103, 216, 108);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(50, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 55);
            panel3.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(103, 216, 108);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(10, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Nhập email";
            txtEmail.Size = new Size(510, 41);
            txtEmail.TabIndex = 7;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbType.ForeColor = Color.DarkGreen;
            lbType.Location = new Point(50, 1);
            lbType.Name = "lbType";
            lbType.Size = new Size(81, 36);
            lbType.TabIndex = 6;
            lbType.Text = "Email";
            // 
            // lbAccountTab
            // 
            lbAccountTab.BackColor = Color.Transparent;
            lbAccountTab.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbAccountTab.ForeColor = Color.Black;
            lbAccountTab.Location = new Point(0, 30);
            lbAccountTab.Name = "lbAccountTab";
            lbAccountTab.Size = new Size(640, 55);
            lbAccountTab.TabIndex = 4;
            lbAccountTab.Text = "QUÊN MẬT KHẨU";
            lbAccountTab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // UCForgotPassword
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 236, 208);
            Controls.Add(panel1);
            Name = "UCForgotPassword";
            Size = new Size(2560, 1500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbCancle;
        private Label label4;
        private Label btnSend;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtEmail;
        private Label lbType;
        private Label lbAccountTab;
        private Label lbInfor;
        private System.Windows.Forms.Timer timer1;
    }
}
