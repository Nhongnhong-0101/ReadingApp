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
            panel1 = new Panel();
            lbSignUp = new Label();
            label4 = new Label();
            btnLogIn = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtEmail = new TextBox();
            lbType = new Label();
            lbAccountTab = new Label();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbAccountTab);
            panel1.Location = new Point(980, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 433);
            panel1.TabIndex = 1;
            // 
            // lbSignUp
            // 
            lbSignUp.AutoSize = true;
            lbSignUp.BackColor = Color.Transparent;
            lbSignUp.Font = new Font("Segoe UI", 12F);
            lbSignUp.ForeColor = Color.DarkGreen;
            lbSignUp.Location = new Point(532, 333);
            lbSignUp.Name = "lbSignUp";
            lbSignUp.Size = new Size(67, 38);
            lbSignUp.TabIndex = 11;
            lbSignUp.Text = "Hủy";
            lbSignUp.Click += lbSignUp_Click;
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
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Image = Properties.Resources.bg_btnlogin;
            btnLogIn.Location = new Point(150, 320);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(350, 65);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Gửi mật khẩu";
            btnLogIn.TextAlign = ContentAlignment.MiddleCenter;
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
        private Label lbSignUp;
        private Label label4;
        private Label btnLogIn;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtEmail;
        private Label lbType;
        private Label lbAccountTab;
    }
}
