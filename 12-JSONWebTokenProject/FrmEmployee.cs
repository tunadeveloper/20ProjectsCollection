using _12_JSONWebTokenProject.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_JSONWebTokenProject
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        public string token;
        SqlConnection connection = new SqlConnection("Server=TUNA\\SQLEXPRESS;Initial Catalog=JWTProject;Integrated Security=True");

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            TokenValidator tokenValidator = new TokenValidator();
            var principal = tokenValidator.ValidateJwtToken(token);

            if (principal != null)
            {
                var subClaim = principal.FindFirst("username")
                ?? principal.FindFirst(JwtRegisteredClaimNames.Sub)
                ?? principal.FindFirst(ClaimTypes.NameIdentifier);

                if (subClaim != null)
                {
                    string username = subClaim.Value;
                    MessageBox.Show("Hoşgeldiniz: " + username);
                }
                else
                {
                    MessageBox.Show("Token içinde username bilgisi yok!");
                }

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvEmployees.DataSource = dt;
                connection.Close();
            }
            else
            {
                MessageBox.Show("Geçersiz Token");
            }
        }

    }
}
