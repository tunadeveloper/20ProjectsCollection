using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_PostgreSQLToDoListProject
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localHost;port=5432;Database=ToDoListDb;user ID=postgres;Password=1234";

        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Categories";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvTasks.DataSource = dataTable;
            connection.Close();
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert Into Categories (CategoryName) Values (@categoryName)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@categoryName", txtTitle.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("kategori Eklendi");
                CategoryList();
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Categories Where CategoryId=@categoryId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@categoryId", int.Parse(txtOperationId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori Silindi");
                CategoryList();
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Categories Set CategoryName=@categoryName Where CategoryId=@categoryId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("categoryId", int.Parse(txtOperationId.Text));
                command.Parameters.AddWithValue("categoryName", txtTitle.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori Güncellendi");
                CategoryList();
            }
            connection.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Categories Where CategoryName=@categoryName";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@categoryName", txtTitle.Text);
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTasks.DataSource = dt;
                }
            }
            connection.Close();
        }
    }
}
