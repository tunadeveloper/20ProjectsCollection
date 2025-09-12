using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_MailRegisterProject
{
    public partial class FrmMailConfirm : Form
    {
        public FrmMailConfirm()
        {
            InitializeComponent();
        }
        public string email;
        MailRegisterEntities context = new MailRegisterEntities();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var value = context.Users.Where(x => x.Email == txtEmail.Text).Select(y => y.ConfirmCode).FirstOrDefault();

            if (txtCode.Text == value.ToString())
            {
                var value2 = context.Users.Where(x => x.Email == txtEmail.Text).FirstOrDefault();
                value2.IsConfirm = true;
                context.SaveChanges();
                MessageBox.Show(
    "Tebrikler! Hesabınız başarıyla aktifleştirildi.\nArtık uygulamayı kullanabilirsiniz.",
    "Aktivasyon Başarılı",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
            }
            else
            {
                MessageBox.Show(
     "Girilen aktivasyon kodu geçersiz.\nLütfen doğru kodu girdiğinizden emin olun ve tekrar deneyin.",
     "Hatalı Kod",
     MessageBoxButtons.OK,
     MessageBoxIcon.Error
 );
            }
        }

        private void FrmMailConfirm_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
        }
    }
}
