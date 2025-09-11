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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=TUNA\\SQLEXPRESS;Initial Catalog=JWTProject;Integrated Security=True");

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEmployees.DataSource = dt;
            connection.Close();
        }

    }
}
