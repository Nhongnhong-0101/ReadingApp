using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadingApp.Services;

namespace ReadingApp.UserControls
{
    public partial class UCForgotPassword : UserControl
    {
        public EventHandler loadUCLogIn;
        public UCForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Contains('@'))
            {
                lbInfor.Text = "Vui lòng nhập đúng định dạng email!";
                lbInfor.Visible = true;
                return;
            }

            if (!UserServices.emailExist(txtEmail.Text))
            {
                lbInfor.Text = "Email không tồn tại. Vui lòng nhập đúng email!";
                lbInfor.Visible = true;
                return;
            }

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress("21520003@gm.uit.edu.vn");
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "22.03.2018");
                smtp.Host = "smtp.gmail.com";

                mail.To.Add(new MailAddress(txtEmail.Text));
                mail.IsBodyHtml = true;
                mail.Subject = "KHÔI PHỤC MẬT KHẨU READINGAPP";
                mail.Body = "Mật khẩu của bạn là: " + UserServices.getPassword(txtEmail.Text);

                smtp.Send(mail);
                lbInfor.Text = "Vui lòng kiểm tra email và đăng nhập lại!";
                lbInfor.Visible = true;
                timer1.Start();
            }
            catch (Exception ex) { }
        }

        private void lbCancle_Click(object sender, EventArgs e)
        {
            loadUCLogIn?.Invoke(this, EventArgs.Empty);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadUCLogIn?.Invoke(this, EventArgs.Empty);
            timer1.Stop();
        }
    }
}
