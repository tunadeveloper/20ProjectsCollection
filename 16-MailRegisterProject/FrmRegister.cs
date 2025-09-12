using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _16_MailRegisterProject
{
    public partial class FrmRegister : Form
    {
        MailRegisterEntities context = new MailRegisterEntities();

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int confirmCode = random.Next(100000, 1000000);

            Users user = new Users
            {
                Email = txtEmail.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                UserPassword = txtPassword.Text,
                IsConfirm = false,
                ConfirmCode = confirmCode.ToString()
            };

            context.Users.Add(user);
            context.SaveChanges();

            MimeMessage mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("AdminRegister", "tunabusiness25@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("User", txtEmail.Text));
            mimeMessage.Subject = "Email Konfirmasyon Kodu";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = $@"
<html>
<body style='font-family:Arial,sans-serif;'>
    <h2 style='color:#4A148C;'>Merhaba {txtFirstName.Text},</h2>
    <p>Uygulamamıza kaydınızı tamamlamak için aşağıdaki aktivasyon kodunu kullanabilirsiniz:</p>
    <h1 style='color:#FF5722;'>{confirmCode}</h1>
    <p>Lütfen kodu uygulamada ilgili alana girerek hesabınızı aktif hale getirin.</p>
    <p style='font-size:smaller;color:gray;'>Eğer bu işlemi siz yapmadıysanız, lütfen bu maili dikkate almayın.</p>
    <p>Teşekkürler,<br/><strong>Tunahan Cengiz</strong></p>
</body>
</html>
";

            mimeMessage.Body = bodyBuilder.ToMessageBody();


            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate("tunabusiness25@gmail.com", "yxefmhsoszmxvibu");
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);
            }

            MessageBox.Show(
    $"Merhaba {txtFirstName.Text},\n\n" +
    "E-posta adresinize doğrulama kodu gönderildi. " +
    "Lütfen gelen maildeki kodu uygulamadaki ilgili alana girerek hesabınızı aktif edin.",
    "Doğrulama Kodu Gönderildi",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
            FrmMailConfirm frm = new FrmMailConfirm
            {
                email = txtEmail.Text
            };
            frm.Show();
        }
    }
}
