namespace ReadingApp.UserControls
{
    partial class UCAccount
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
            picAvat = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            txtEmail = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label5 = new Label();
            picFemale = new PictureBox();
            pnMale = new Panel();
            lbMale = new Label();
            picMale = new PictureBox();
            label4 = new Label();
            panel5 = new Panel();
            dateDob = new DateTimePicker();
            label3 = new Label();
            panel3 = new Panel();
            txtFullName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtUsername = new TextBox();
            lbType = new Label();
            panel8 = new Panel();
            btnChangePassword = new Label();
            btnUpdateAccount = new Label();
            picEditAvat = new PictureBox();
            lbInfor = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picAvat).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFemale).BeginInit();
            pnMale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMale).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEditAvat).BeginInit();
            SuspendLayout();
            // 
            // picAvat
            // 
            picAvat.Image = Properties.Resources.image_user;
            picAvat.Location = new Point(910, 120);
            picAvat.Name = "picAvat";
            picAvat.Size = new Size(370, 370);
            picAvat.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvat.TabIndex = 0;
            picAvat.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(595, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 354);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(13, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 93);
            panel4.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(5, 39);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 38);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "maianhha@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(pnMale);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(697, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(303, 93);
            panel6.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(picFemale);
            panel7.Location = new Point(162, 32);
            panel7.Name = "panel7";
            panel7.Size = new Size(98, 50);
            panel7.TabIndex = 11;
            panel7.Click += picFemale_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(34, 5);
            label5.Name = "label5";
            label5.Size = new Size(54, 38);
            label5.TabIndex = 5;
            label5.Text = "Nữ";
            label5.Click += picFemale_Click;
            // 
            // picFemale
            // 
            picFemale.Image = Properties.Resources.check;
            picFemale.Location = new Point(0, 12);
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
            pnMale.Location = new Point(3, 32);
            pnMale.Name = "pnMale";
            pnMale.Size = new Size(125, 50);
            pnMale.TabIndex = 10;
            pnMale.Click += picMale_Click;
            // 
            // lbMale
            // 
            lbMale.AutoSize = true;
            lbMale.Font = new Font("Segoe UI", 12F);
            lbMale.ForeColor = Color.Black;
            lbMale.Location = new Point(34, 5);
            lbMale.Name = "lbMale";
            lbMale.Size = new Size(76, 38);
            lbMale.TabIndex = 5;
            lbMale.Text = "Nam";
            lbMale.Click += picMale_Click;
            // 
            // picMale
            // 
            picMale.Image = Properties.Resources._checked;
            picMale.Location = new Point(0, 12);
            picMale.Name = "picMale";
            picMale.Size = new Size(30, 30);
            picMale.SizeMode = PictureBoxSizeMode.StretchImage;
            picMale.TabIndex = 4;
            picMale.TabStop = false;
            picMale.Click += picMale_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 32);
            label4.TabIndex = 6;
            label4.Text = "Giới tính";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(dateDob);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(697, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(303, 93);
            panel5.TabIndex = 10;
            // 
            // dateDob
            // 
            dateDob.Font = new Font("Segoe UI", 12F);
            dateDob.Format = DateTimePickerFormat.Short;
            dateDob.Location = new Point(0, 39);
            dateDob.Name = "dateDob";
            dateDob.Size = new Size(250, 45);
            dateDob.TabIndex = 7;
            dateDob.Value = new DateTime(2024, 6, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 6;
            label3.Text = "Ngày sinh";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(13, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 93);
            panel3.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.ForeColor = Color.Black;
            txtFullName.Location = new Point(5, 39);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 38);
            txtFullName.TabIndex = 7;
            txtFullName.Text = "Hà Mai Anh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 6;
            label1.Text = "Họ tên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lbType);
            panel2.Location = new Point(13, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 93);
            panel2.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(5, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 38);
            txtUsername.TabIndex = 7;
            txtUsername.Text = "maianhha";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbType.ForeColor = Color.Gray;
            lbType.Location = new Point(0, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(196, 32);
            lbType.TabIndex = 6;
            lbType.Text = "Tên người dùng";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(btnChangePassword);
            panel8.Controls.Add(btnUpdateAccount);
            panel8.Location = new Point(820, 980);
            panel8.Name = "panel8";
            panel8.Size = new Size(550, 170);
            panel8.TabIndex = 12;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.Transparent;
            btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Image = Properties.Resources.bg_updateAccount;
            btnChangePassword.Location = new Point(0, 100);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(550, 65);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "Thay đổi mật khẩu";
            btnChangePassword.TextAlign = ContentAlignment.MiddleCenter;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.BackColor = Color.Transparent;
            btnUpdateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdateAccount.ForeColor = Color.White;
            btnUpdateAccount.Image = Properties.Resources.bg_updateAccount;
            btnUpdateAccount.Location = new Point(0, 0);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(550, 65);
            btnUpdateAccount.TabIndex = 1;
            btnUpdateAccount.Text = "Cập nhật thông tin";
            btnUpdateAccount.TextAlign = ContentAlignment.MiddleCenter;
            btnUpdateAccount.Click += btnUpdateAccount_Click;
            // 
            // picEditAvat
            // 
            picEditAvat.BackColor = Color.WhiteSmoke;
            picEditAvat.Image = Properties.Resources.pen;
            picEditAvat.Location = new Point(1060, 436);
            picEditAvat.Name = "picEditAvat";
            picEditAvat.Size = new Size(70, 70);
            picEditAvat.SizeMode = PictureBoxSizeMode.StretchImage;
            picEditAvat.TabIndex = 14;
            picEditAvat.TabStop = false;
            picEditAvat.Click += picEditAvat_Click;
            // 
            // lbInfor
            // 
            lbInfor.BackColor = Color.Transparent;
            lbInfor.Font = new Font("Segoe UI", 8F);
            lbInfor.ForeColor = Color.Red;
            lbInfor.Location = new Point(780, 937);
            lbInfor.Name = "lbInfor";
            lbInfor.Size = new Size(640, 25);
            lbInfor.TabIndex = 17;
            lbInfor.Text = "Cập nhật thành công";
            lbInfor.TextAlign = ContentAlignment.MiddleCenter;
            lbInfor.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 1200;
            timer1.Tick += timer1_Tick;
            // 
            // UCAccount
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbInfor);
            Controls.Add(picEditAvat);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(picAvat);
            Name = "UCAccount";
            Size = new Size(2190, 1475);
            Load += UCAccount_Load;
            ((System.ComponentModel.ISupportInitialize)picAvat).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFemale).EndInit();
            pnMale.ResumeLayout(false);
            pnMale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMale).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picEditAvat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picAvat;
        private Panel panel1;
        private Panel panel2;
        private Label lbType;
        private Panel panel3;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtUsername;
        private Panel panel4;
        private TextBox txtEmail;
        private Label label2;
        private Panel panel6;
        private Label label4;
        private Panel panel5;
        private Label label3;
        private Panel panel7;
        private Label label5;
        private PictureBox picFemale;
        private Panel pnMale;
        private Label lbMale;
        private PictureBox picMale;
        private DateTimePicker dateDob;
        private Panel panel8;
        private Label btnChangePassword;
        private Label btnUpdateAccount;
        private PictureBox picEditAvat;
        private Label lbInfor;
        private System.Windows.Forms.Timer timer1;
    }
}
