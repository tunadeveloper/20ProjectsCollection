using _12_JSONWebTokenProject.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_JSONWebTokenProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server=TUNA\\SQLEXPRESS;Initial Catalog=JWTProject;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            TokenGenerator tokenGenerator = new TokenGenerator();
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE UserName=@username AND UserPassword=@userPassword", connection);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@userPassword", txtPassword.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Kullanıcı adı boş olamaz");
                    return;
                }
                string token = tokenGenerator.GenerateJSONWebToken2(txtUsername.Text);
                FrmEmployee employee = new FrmEmployee();
                employee.token = token;
                employee.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
            connection.Close();
        }
    }
}
