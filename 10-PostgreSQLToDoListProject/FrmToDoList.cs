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
    public partial class FrmToDoList : Form
    {
        public FrmToDoList()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localHost;port=5432;Database=ToDoListDb;user ID=postgres;Password=1234";
        void ToDoList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From todolists";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvTasks.DataSource = dataTable;
            connection.Close();
        }

        void CategoryList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From categories";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = dataTable;
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToDoList();
            CategoryList();
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string status = rdoCompleted.Checked ? "1" : "0";

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Insert Into todolists (Title, Priority, Description, Status, CategoryId) values (@title, @priority, @description, @status, @categoryId)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", txtTitle.Text);
                command.Parameters.AddWithValue("@priority", txtPriority.Text);
                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@status", NpgsqlTypes.NpgsqlDbType.Bit, status);
                command.Parameters.AddWithValue("@categoryId", int.Parse(cmbCategory.SelectedValue.ToString()));
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılacak işlem eklendi");
                ToDoList();
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From todolists Where ToDoListId=@toDoListId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@toDoListId", int.Parse(txtOperationId.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("İşlem Silindi");
                ToDoList();
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = rdoCompleted.Checked ? "1" : "0";
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update ToDoLists Set Title=@title, Description=@description, Status=@status Priority=@priority, CategoryId=@categoryId Where ToDoListId=@toDoListId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("toDoListId", int.Parse(txtOperationId.Text));
                command.Parameters.AddWithValue("title", txtTitle.Text);
                command.Parameters.AddWithValue("description", txtDescription.Text);
                command.Parameters.AddWithValue("@status", NpgsqlTypes.NpgsqlDbType.Bit, status);
                command.Parameters.AddWithValue("priority", txtPriority.Text);
                command.Parameters.AddWithValue("categoryId", int.Parse(cmbCategory.SelectedValue.ToString()));
                command.ExecuteNonQuery();
                MessageBox.Show("Kategori Güncellendi");
                CategoryList();
            }
            connection.Close();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From todolists Where Status='1'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvTasks.DataSource = dataTable;
            connection.Close();
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From todolists Where Status='0'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvTasks.DataSource = dataTable;
            connection.Close();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select ToDoListsId,Title,Description,Status,Priority,CategoryName from todolists inner join categories on todolists.CategoryId=categories.CategoryId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvTasks.DataSource = dataTable;
            connection.Close();
        }
    }
}
