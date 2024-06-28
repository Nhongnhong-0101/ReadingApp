namespace ReadingApp.UserControls
{
    partial class UCSignUp
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
            panel9 = new Panel();
            panel13 = new Panel();
            txtEmail = new TextBox();
            label4 = new Label();
            lbCancle = new Label();
            panel11 = new Panel();
            panel12 = new Panel();
            picConfirmEye = new PictureBox();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            panel10 = new Panel();
            pnFemale = new Panel();
            lbFee = new Label();
            picFemale = new PictureBox();
            pnMale = new Panel();
            lbMale = new Label();
            picMale = new PictureBox();
            label5 = new Label();
            panel8 = new Panel();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            picEye = new PictureBox();
            txtPassword = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            txtFullName = new TextBox();
            label2 = new Label();
            btnSignUp = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtUsername = new TextBox();
            lbType = new Label();
            label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel13.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picConfirmEye).BeginInit();
            panel10.SuspendLayout();
            pnFemale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFemale).BeginInit();
            pnMale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMale).BeginInit();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg_login;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lbInfor);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(lbCancle);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnSignUp);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label);
            panel1.Location = new Point(955, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 1001);
            panel1.TabIndex = 1;
            // 
            // lbInfor
            // 
            lbInfor.BackColor = Color.Transparent;
            lbInfor.Font = new Font("Segoe UI", 8F);
            lbInfor.ForeColor = Color.Red;
            lbInfor.Location = new Point(1, 810);
            lbInfor.Name = "lbInfor";
            lbInfor.Size = new Size(640, 25);
            lbInfor.TabIndex = 16;
            lbInfor.Text = "Đăng ký không thành công!";
            lbInfor.TextAlign = ContentAlignment.MiddleCenter;
            lbInfor.Visible = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(panel13);
            panel9.Controls.Add(label4);
            panel9.Location = new Point(0, 337);
            panel9.Name = "panel9";
            panel9.Size = new Size(640, 116);
            panel9.TabIndex = 10;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(txtEmail);
            panel13.Location = new Point(50, 40);
            panel13.Name = "panel13";
            panel13.Size = new Size(530, 55);
            panel13.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(10, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Nhập email";
            txtEmail.Size = new Size(510, 38);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(50, 1);
            label4.Name = "label4";
            label4.Size = new Size(81, 36);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // lbCancle
            // 
            lbCancle.BackColor = Color.Transparent;
            lbCancle.Font = new Font("Segoe UI", 12F);
            lbCancle.ForeColor = Color.DarkGreen;
            lbCancle.Location = new Point(276, 922);
            lbCancle.Name = "lbCancle";
            lbCancle.Size = new Size(100, 38);
            lbCancle.TabIndex = 14;
            lbCancle.Text = "Hủy";
            lbCancle.TextAlign = ContentAlignment.MiddleCenter;
            lbCancle.Click += lbCancle_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(label6);
            panel11.Location = new Point(1, 691);
            panel11.Name = "panel11";
            panel11.Size = new Size(640, 116);
            panel11.TabIndex = 10;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(picConfirmEye);
            panel12.Controls.Add(txtConfirmPassword);
            panel12.Location = new Point(50, 44);
            panel12.Name = "panel12";
            panel12.Size = new Size(530, 55);
            panel12.TabIndex = 8;
            // 
            // picConfirmEye
            // 
            picConfirmEye.Image = Properties.Resources.eye_slash;
            picConfirmEye.Location = new Point(485, 6);
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
            txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu";
            txtConfirmPassword.Size = new Size(469, 38);
            txtConfirmPassword.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(50, 5);
            label6.Name = "label6";
            label6.Size = new Size(250, 36);
            label6.TabIndex = 6;
            label6.Text = "Xác nhận mật khẩu";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(pnFemale);
            panel10.Controls.Add(pnMale);
            panel10.Controls.Add(label5);
            panel10.Location = new Point(338, 455);
            panel10.Name = "panel10";
            panel10.Size = new Size(280, 116);
            panel10.TabIndex = 13;
            // 
            // pnFemale
            // 
            pnFemale.Controls.Add(lbFee);
            pnFemale.Controls.Add(picFemale);
            pnFemale.Location = new Point(145, 44);
            pnFemale.Name = "pnFemale";
            pnFemale.Size = new Size(97, 40);
            pnFemale.TabIndex = 9;
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Font = new Font("Segoe UI", 10F);
            lbFee.ForeColor = Color.Black;
            lbFee.Location = new Point(36, 5);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(46, 32);
            lbFee.TabIndex = 5;
            lbFee.Text = "Nữ";
            // 
            // picFemale
            // 
            picFemale.Image = Properties.Resources.check;
            picFemale.Location = new Point(0, 5);
            picFemale.Name = "picFemale";
            picFemale.Size = new Size(30, 30);
            picFemale.SizeMode = PictureBoxSizeMode.StretchImage;
            picFemale.TabIndex = 4;
            picFemale.TabStop = false;
            picFemale.Click += picFemale_Click;
            // 
            // pnMale
            // 
            pnMale.Controls.Add(lbMale);
            pnMale.Controls.Add(picMale);
            pnMale.Location = new Point(20, 44);
            pnMale.Name = "pnMale";
            pnMale.Size = new Size(119, 40);
            pnMale.TabIndex = 8;
            // 
            // lbMale
            // 
            lbMale.AutoSize = true;
            lbMale.Font = new Font("Segoe UI", 10F);
            lbMale.ForeColor = Color.Black;
            lbMale.Location = new Point(36, 5);
            lbMale.Name = "lbMale";
            lbMale.Size = new Size(65, 32);
            lbMale.TabIndex = 5;
            lbMale.Text = "Nam";
            // 
            // picMale
            // 
            picMale.Image = Properties.Resources._checked;
            picMale.Location = new Point(0, 5);
            picMale.Name = "picMale";
            picMale.Size = new Size(30, 30);
            picMale.SizeMode = PictureBoxSizeMode.StretchImage;
            picMale.TabIndex = 4;
            picMale.TabStop = false;
            picMale.Click += picMale_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(20, 1);
            label5.Name = "label5";
            label5.Size = new Size(119, 36);
            label5.TabIndex = 6;
            label5.Text = "Giới tính";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(dateTimePicker);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(1, 455);
            panel8.Name = "panel8";
            panel8.Size = new Size(331, 116);
            panel8.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 12F);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(50, 40);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 45);
            dateTimePicker.TabIndex = 2;
            dateTimePicker.Value = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(50, 1);
            label3.Name = "label3";
            label3.Size = new Size(137, 36);
            label3.TabIndex = 6;
            label3.Text = "Ngày sinh";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(1, 573);
            panel4.Name = "panel4";
            panel4.Size = new Size(640, 116);
            panel4.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
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
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(10, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Nhập mật khẩu";
            txtPassword.Size = new Size(469, 38);
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
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(0, 219);
            panel6.Name = "panel6";
            panel6.Size = new Size(640, 116);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txtFullName);
            panel7.Location = new Point(50, 40);
            panel7.Name = "panel7";
            panel7.Size = new Size(530, 55);
            panel7.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(10, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Nhập họ tên";
            txtFullName.Size = new Size(510, 38);
            txtFullName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(50, 1);
            label2.Name = "label2";
            label2.Size = new Size(98, 36);
            label2.TabIndex = 6;
            label2.Text = "Họ tên";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Image = Properties.Resources.bg_btnlogin;
            btnSignUp.Location = new Point(151, 839);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(350, 65);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.TextAlign = ContentAlignment.MiddleCenter;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbType);
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 116);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtUsername);
            panel3.Location = new Point(50, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 55);
            panel3.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(10, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Nhập tên đăng nhập";
            txtUsername.Size = new Size(510, 38);
            txtUsername.TabIndex = 7;
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
            // label
            // 
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label.ForeColor = Color.Black;
            label.Location = new Point(0, 30);
            label.Name = "label";
            label.Size = new Size(640, 55);
            label.TabIndex = 4;
            label.Text = "ĐĂNG KÝ";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // UCSignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 236, 208);
            Controls.Add(panel1);
            Name = "UCSignUp";
            Size = new Size(2560, 1500);
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picConfirmEye).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            pnFemale.ResumeLayout(false);
            pnFemale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFemale).EndInit();
            pnMale.ResumeLayout(false);
            pnMale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMale).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEye).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label btnSignUp;
        private Panel panel4;
        private Panel panel5;
        private PictureBox picEye;
        private TextBox txtPassword;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtUsername;
        private Label lbType;
        private Label label;
        private Panel panel8;
        private Label label3;
        private Panel panel6;
        private Panel panel7;
        private TextBox txtFullName;
        private Label label2;
        private Panel panel10;
        private Label label5;
        private Panel pnFemale;
        private Label lbFee;
        private PictureBox picFemale;
        private Panel pnMale;
        private Label lbMale;
        private PictureBox picMale;
        private Panel panel11;
        private Panel panel12;
        private PictureBox picConfirmEye;
        private TextBox txtConfirmPassword;
        private Label label6;
        private Label lbCancle;
        private DateTimePicker dateTimePicker;
        private Panel panel9;
        private Panel panel13;
        private TextBox txtEmail;
        private Label label4;
        private Label lbInfor;
        private System.Windows.Forms.Timer timer1;
    }
}
