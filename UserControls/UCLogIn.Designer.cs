namespace ReadingApp.UserControls
{
    partial class UCLogIn
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
            lbUnsuccess = new Label();
            lbSignUp = new Label();
            label4 = new Label();
            btnLogIn = new Label();
            panel4 = new Panel();
            lbEmptyEmailPass = new Label();
            lbForgotPassword = new Label();
            panel5 = new Panel();
            picEye = new PictureBox();
            txtPassword = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtEmail = new TextBox();
            lbType = new Label();
            lbAccountTab = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_login;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbUnsuccess);
            panel1.Controls.Add(lbSignUp);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbAccountTab);
            panel1.Location = new Point(653, 233);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 451);
            panel1.TabIndex = 0;
            // 
            // lbUnsuccess
            // 
            lbUnsuccess.BackColor = Color.Transparent;
            lbUnsuccess.Font = new Font("Segoe UI", 8F);
            lbUnsuccess.ForeColor = Color.Red;
            lbUnsuccess.Location = new Point(0, 275);
            lbUnsuccess.Margin = new Padding(2, 0, 2, 0);
            lbUnsuccess.Name = "lbUnsuccess";
            lbUnsuccess.Size = new Size(427, 17);
            lbUnsuccess.TabIndex = 12;
            lbUnsuccess.Text = "Đăng nhập không thành công!";
            lbUnsuccess.TextAlign = ContentAlignment.MiddleCenter;
            lbUnsuccess.Visible = false;
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.BackColor = Color.Transparent;
            lbSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            lbSignUp.ForeColor = Color.DarkGreen;
            lbSignUp.Location = new Point(270, 369);
            lbSignUp.Margin = new Padding(2, 0, 2, 0);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(84, 28);
            lbSignUp.TabIndex = 11;
            lbSignUp.Text = "Đăng ký";
            lbSignUp.Click += lbSignUp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(88, 370);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 25);
            label4.TabIndex = 10;
            label4.Text = "Bạn chưa có tài khoản?";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Image = Properties.Resources.bg_btnlogin;
            btnLogIn.Location = new Point(100, 300);
            btnLogIn.Margin = new Padding(2, 0, 2, 0);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(233, 43);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Đăng nhập";
            btnLogIn.TextAlign = ContentAlignment.MiddleCenter;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(lbEmptyEmailPass);
            panel4.Controls.Add(lbForgotPassword);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 181);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(427, 87);
            panel4.TabIndex = 9;
            // 
            // lbEmptyEmailPass
            // 
            lbEmptyEmailPass.AutoSize = true;
            lbEmptyEmailPass.Font = new Font("Segoe UI", 8F);
            lbEmptyEmailPass.ForeColor = Color.Red;
            lbEmptyEmailPass.Location = new Point(33, 66);
            lbEmptyEmailPass.Margin = new Padding(2, 0, 2, 0);
            lbEmptyEmailPass.Name = "lbEmptyEmailPass";
            lbEmptyEmailPass.Size = new Size(215, 19);
            lbEmptyEmailPass.TabIndex = 11;
            lbEmptyEmailPass.Text = "Vui lòng nhập email và mật khẩu!";
            lbEmptyEmailPass.Visible = false;
            // 
            // lbForgotPassword
            // 
            lbForgotPassword.AutoSize = true;
            lbForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            lbForgotPassword.ForeColor = Color.DarkGreen;
            lbForgotPassword.Location = new Point(271, 6);
            lbForgotPassword.Margin = new Padding(2, 0, 2, 0);
            lbForgotPassword.Name = "lbForgotPassword";
            lbForgotPassword.Size = new Size(129, 23);
            lbForgotPassword.TabIndex = 9;
            lbForgotPassword.Text = "Quên mật khẩu";
            lbForgotPassword.Click += lbForgotPassword_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGreen;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(picEye);
            panel5.Controls.Add(txtPassword);
            panel5.Location = new Point(33, 29);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 37);
            panel5.TabIndex = 8;
            // 
            // picEye
            // 
            picEye.Image = Properties.Resources.eye_slash;
            picEye.Location = new Point(323, 4);
            picEye.Margin = new Padding(2, 2, 2, 2);
            picEye.Name = "picEye";
            picEye.Size = new Size(27, 27);
            picEye.SizeMode = PictureBoxSizeMode.StretchImage;
            picEye.TabIndex = 8;
            picEye.TabStop = false;
            picEye.Click += picEye_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(142, 238, 145);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(7, 3);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.MaxLength = 8;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Nhập mật khẩu";
            txtPassword.Size = new Size(313, 29);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "12345678";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(33, 3);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 6;
            label1.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbType);
            panel2.Location = new Point(0, 95);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 83);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(103, 216, 108);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(33, 27);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 37);
            panel3.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(103, 216, 108);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(7, 3);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Nhập tên đăng nhập";
            txtEmail.Size = new Size(340, 29);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Admin";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbType.ForeColor = Color.DarkGreen;
            lbType.Location = new Point(33, 1);
            lbType.Margin = new Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(144, 25);
            lbType.TabIndex = 6;
            lbType.Text = "Tên đăng nhập";
            // 
            // lbAccountTab
            // 
            lbAccountTab.BackColor = Color.Transparent;
            lbAccountTab.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lbAccountTab.ForeColor = Color.Black;
            lbAccountTab.Location = new Point(0, 20);
            lbAccountTab.Margin = new Padding(2, 0, 2, 0);
            lbAccountTab.Name = "lbAccountTab";
            lbAccountTab.Size = new Size(427, 37);
            lbAccountTab.TabIndex = 4;
            lbAccountTab.Text = "ĐĂNG NHẬP";
            lbAccountTab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // UCLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 236, 208);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCLogIn";
            Size = new Size(1707, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbAccountTab;
        private Panel panel2;
        private Label lbType;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtPassword;
        private Label label1;
        private Panel panel3;
        private TextBox txtEmail;
        private Label lbForgotPassword;
        private PictureBox picEye;
        private Label lbSignUp;
        private Label label4;
        private Label btnLogIn;
        private Label lbEmptyEmailPass;
        private Label lbUnsuccess;
        private System.Windows.Forms.Timer timer1;
    }
}
