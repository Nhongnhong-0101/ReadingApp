namespace ReadingApp.UserControls
{
    partial class UCPasswordChange
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
            btnChangePassword = new Label();
            lbType = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            picPasswordEye = new PictureBox();
            txtOldPassword = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            picNewPasswordEye = new PictureBox();
            txtNewPassword = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            panel7 = new Panel();
            picConfirmEye = new PictureBox();
            txtConfirmPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbCancle = new Label();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPasswordEye).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNewPasswordEye).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picConfirmEye).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.Transparent;
            btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Image = Properties.Resources.bg_updateAccount;
            btnChangePassword.Location = new Point(820, 1080);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(550, 65);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "Thay đổi mật khẩu";
            btnChangePassword.TextAlign = ContentAlignment.MiddleCenter;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbType.ForeColor = Color.Gray;
            lbType.Location = new Point(0, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(213, 32);
            lbType.TabIndex = 6;
            lbType.Text = "Mật khẩu hiện tại";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(lbType);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 93);
            panel2.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(picPasswordEye);
            panel5.Controls.Add(txtOldPassword);
            panel5.Location = new Point(5, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(440, 55);
            panel5.TabIndex = 9;
            // 
            // picPasswordEye
            // 
            picPasswordEye.Image = Properties.Resources.eye_slash;
            picPasswordEye.Location = new Point(390, 5);
            picPasswordEye.Name = "picPasswordEye";
            picPasswordEye.Size = new Size(40, 40);
            picPasswordEye.SizeMode = PictureBoxSizeMode.StretchImage;
            picPasswordEye.TabIndex = 8;
            picPasswordEye.TabStop = false;
            picPasswordEye.Click += picEye_Click;
            // 
            // txtOldPassword
            // 
            txtOldPassword.BackColor = Color.White;
            txtOldPassword.BorderStyle = BorderStyle.None;
            txtOldPassword.Font = new Font("Segoe UI", 12F);
            txtOldPassword.ForeColor = Color.Black;
            txtOldPassword.Location = new Point(10, 5);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.PlaceholderText = "Nhập mật khẩu";
            txtOldPassword.Size = new Size(368, 38);
            txtOldPassword.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 6;
            label1.Text = "Mật khẩu mới";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 93);
            panel3.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(picNewPasswordEye);
            panel6.Controls.Add(txtNewPassword);
            panel6.Location = new Point(5, 35);
            panel6.Name = "panel6";
            panel6.Size = new Size(440, 55);
            panel6.TabIndex = 10;
            // 
            // picNewPasswordEye
            // 
            picNewPasswordEye.Image = Properties.Resources.eye_slash;
            picNewPasswordEye.Location = new Point(390, 5);
            picNewPasswordEye.Name = "picNewPasswordEye";
            picNewPasswordEye.Size = new Size(40, 40);
            picNewPasswordEye.SizeMode = PictureBoxSizeMode.StretchImage;
            picNewPasswordEye.TabIndex = 8;
            picNewPasswordEye.TabStop = false;
            picNewPasswordEye.Click += picNewPasswordEye_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.Location = new Point(10, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.PlaceholderText = "Nhập mật khẩu";
            txtNewPassword.Size = new Size(368, 38);
            txtNewPassword.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 32);
            label2.TabIndex = 6;
            label2.Text = "Xác nhận lại mật khẩu";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 93);
            panel4.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(picConfirmEye);
            panel7.Controls.Add(txtConfirmPassword);
            panel7.Location = new Point(5, 35);
            panel7.Name = "panel7";
            panel7.Size = new Size(440, 55);
            panel7.TabIndex = 10;
            // 
            // picConfirmEye
            // 
            picConfirmEye.Image = Properties.Resources.eye_slash;
            picConfirmEye.Location = new Point(390, 5);
            picConfirmEye.Name = "picConfirmEye";
            picConfirmEye.Size = new Size(40, 40);
            picConfirmEye.SizeMode = PictureBoxSizeMode.StretchImage;
            picConfirmEye.TabIndex = 8;
            picConfirmEye.TabStop = false;
            picConfirmEye.Click += picConfirmEye_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.Location = new Point(10, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Nhập mật khẩu";
            txtConfirmPassword.Size = new Size(368, 38);
            txtConfirmPassword.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(870, 642);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 354);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_user;
            pictureBox1.Location = new Point(910, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 370);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lbCancle
            // 
            lbCancle.BackColor = Color.Transparent;
            lbCancle.Font = new Font("Segoe UI", 12F);
            lbCancle.ForeColor = Color.DarkGreen;
            lbCancle.Location = new Point(1045, 1192);
            lbCancle.Name = "lbCancle";
            lbCancle.Size = new Size(100, 38);
            lbCancle.TabIndex = 17;
            lbCancle.Text = "Hủy";
            lbCancle.TextAlign = ContentAlignment.MiddleCenter;
            lbCancle.Click += lbCancle_Click;
            // 
            // UCPasswordChange
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbCancle);
            Controls.Add(btnChangePassword);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "UCPasswordChange";
            Size = new Size(2190, 1475);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPasswordEye).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNewPasswordEye).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picConfirmEye).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label btnChangePassword;
        private Label lbType;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox picPasswordEye;
        private TextBox txtOldPassword;
        private Panel panel6;
        private PictureBox picNewPasswordEye;
        private TextBox txtNewPassword;
        private Panel panel7;
        private PictureBox picConfirmEye;
        private TextBox txtConfirmPassword;
        private Label lbCancle;
    }
}
