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
            panel1 = new Panel();
            lbSignUp = new Label();
            label4 = new Label();
            btnLogIn = new Label();
            panel4 = new Panel();
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
            panel1.Controls.Add(lbSignUp);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbAccountTab);
            panel1.Location = new Point(980, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 677);
            panel1.TabIndex = 0;
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.BackColor = Color.Transparent;
            lbSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            lbSignUp.ForeColor = Color.DarkGreen;
            lbSignUp.Location = new Point(405, 553);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(119, 38);
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
            label4.Location = new Point(132, 555);
            label4.Name = "label4";
            label4.Size = new Size(279, 36);
            label4.TabIndex = 10;
            label4.Text = "Bạn chưa có tài khoản?";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Image = Properties.Resources.bg_btnlogin;
            btnLogIn.Location = new Point(150, 450);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(350, 65);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Đăng nhập";
            btnLogIn.TextAlign = ContentAlignment.MiddleCenter;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(lbForgotPassword);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(640, 116);
            panel4.TabIndex = 9;
            // 
            // lbForgotPassword
            // 
            lbForgotPassword.AutoSize = true;
            lbForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            lbForgotPassword.ForeColor = Color.DarkGreen;
            lbForgotPassword.Location = new Point(407, 9);
            lbForgotPassword.Name = "lbForgotPassword";
            lbForgotPassword.Size = new Size(180, 32);
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
            panel5.Location = new Point(50, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(530, 55);
            panel5.TabIndex = 8;
            // 
            // picEye
            // 
            picEye.Image = Properties.Resources.eye_slash;
            picEye.Location = new Point(485, 6);
            picEye.Name = "picEye";
            picEye.Size = new Size(40, 40);
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
            txtPassword.Location = new Point(10, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Nhập mật khẩu";
            txtPassword.Size = new Size(469, 41);
            txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(50, 5);
            label1.Name = "label1";
            label1.Size = new Size(132, 36);
            label1.TabIndex = 6;
            label1.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbType);
            panel2.Location = new Point(0, 142);
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
            txtEmail.PlaceholderText = "Nhập tên đăng nhập";
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
            lbType.Size = new Size(196, 36);
            lbType.TabIndex = 6;
            lbType.Text = "Tên đăng nhập";
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
            lbAccountTab.Text = "ĐĂNG NHẬP";
            lbAccountTab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCLogIn
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 236, 208);
            Controls.Add(panel1);
            Name = "UCLogIn";
            Size = new Size(2560, 1500);
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
    }
}
