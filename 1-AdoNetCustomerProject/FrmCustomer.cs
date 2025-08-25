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

namespace _1_AdoNetCustomerProject
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
            ConfigureDataGridViewTheme();
        }
        private void ConfigureDataGridViewTheme()
        {
            if (dgvCustomers == null) return;

            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvCustomers, true, null);

            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.MultiSelect = false;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.GridColor = Color.FromArgb(64, 64, 64);

            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 81, 181);
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(48, 63, 159);
            dgvCustomers.ColumnHeadersHeight = 42;

            dgvCustomers.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dgvCustomers.DefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(99, 125, 255);
            dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCustomers.RowsDefaultCellStyle.Padding = new Padding(10, 6, 10, 6);
            dgvCustomers.RowTemplate.Height = 40;

            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 42, 64);
        }

        SqlConnection sqlConnection = new SqlConnection("Server=TUNA\\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True");

        private void ListCustomer()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT CustomerId, CustomerNameSurname, CustomerBalance, CustomerStatus, CityName FROM Customer INNER JOIN City ON City.CityId = Customer.CustomerCity", sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvCustomers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Müşteriler listelenirken bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListCustomer();
        }


        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * From City", sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                comboBox1.ValueMember = "CityId";
                comboBox1.DisplayMember = "CityName";
                comboBox1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Şehirler listelenirken bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(
     "INSERT INTO Customer (CustomerNameSurname, CustomerCity, CustomerBalance, CustomerStatus) " +
     "VALUES (@customerNameSurname, @customerCity, @customerBalance, @customerStatus)", sqlConnection);

                command.Parameters.AddWithValue("@customerNameSurname", txtCustomerName.Text);
                command.Parameters.AddWithValue("@customerCity", comboBox1.SelectedValue);
                command.Parameters.AddWithValue("@customerBalance", Convert.ToDecimal(txtCustomerBalance.Text));

                if (rdbActive.Checked)
                {
                    command.Parameters.AddWithValue("@customerStatus", true);
                }
                else if (rdbPassive.Checked)
                {
                    command.Parameters.AddWithValue("@customerStatus", false);
                }
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show(
                "Müşteri başarıyla eklendi!",
                "Başarılı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                ListCustomer();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                           "Müşteri eklenirken bir hata oluştu:\n" + ex.Message,
                           "Hata",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["CustomerId"].Value);

                sqlConnection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE CustomerId=@customerId", sqlConnection);
                command.Parameters.AddWithValue("@customerId", customerId);
                command.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show(
               "Müşteri başarıyla silindi!",
               "Başarılı",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

                ListCustomer();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                              "Müşteri silinirken bir hata oluştu:\n" + ex.Message,
                              "Hata",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(
     "UPDATE Customer SET CustomerNameSurname=@customerNameSurname, CustomerCity=@customerCity, CustomerBalance=@customerBalance, CustomerStatus=@customerStatus WHERE CustomerId=@customerId", sqlConnection);
                command.Parameters.AddWithValue("@customerId", txtCustomerID.Text);
                command.Parameters.AddWithValue("@customerNameSurname", txtCustomerName.Text);
                command.Parameters.AddWithValue("@customerCity", comboBox1.SelectedValue);
                command.Parameters.AddWithValue("@customerBalance", Convert.ToDecimal(txtCustomerBalance.Text));

                if (rdbActive.Checked)
                {
                    command.Parameters.AddWithValue("@customerStatus", true);
                }
                else if (rdbPassive.Checked)
                {
                    command.Parameters.AddWithValue("@customerStatus", false);
                }
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show(
                "Müşteri başarıyla güncellendi!",
                "Başarılı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                ListCustomer();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                           "Müşteri güncellenirken bir hata oluştu:\n" + ex.Message,
                           "Hata",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT CustomerId, CustomerNameSurname, CustomerBalance, CustomerStatus, CityName FROM Customer INNER JOIN City ON City.CityId = Customer.CustomerCity Where CustomerNameSurname=@customerName", sqlConnection);
                command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvCustomers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Müşteri aranırken bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
    }
}
