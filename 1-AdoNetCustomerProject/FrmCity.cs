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
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
            ConfigureDataGridViewTheme();
        }
        private void ConfigureDataGridViewTheme()
        {
            if (dgvCities == null) return;

            typeof(DataGridView)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvCities, true, null);

            dgvCities.EnableHeadersVisualStyles = false;
            dgvCities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCities.MultiSelect = false;
            dgvCities.RowHeadersVisible = false;
            dgvCities.AllowUserToResizeRows = false;
            dgvCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCities.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCities.BorderStyle = BorderStyle.None;
            dgvCities.GridColor = Color.FromArgb(64, 64, 64);

            dgvCities.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 81, 181);
            dgvCities.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCities.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvCities.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(48, 63, 159);
            dgvCities.ColumnHeadersHeight = 42;

            dgvCities.DefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
            dgvCities.DefaultCellStyle.ForeColor = Color.White;
            dgvCities.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvCities.DefaultCellStyle.SelectionBackColor = Color.FromArgb(99, 125, 255);
            dgvCities.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCities.RowsDefaultCellStyle.Padding = new Padding(10, 6, 10, 6);
            dgvCities.RowTemplate.Height = 40;

            dgvCities.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 42, 64);
        }

        SqlConnection sqlConnection = new SqlConnection("Server=TUNA\\SQLEXPRESS;Initial Catalog=DbCustomer;Integrated Security=True");

        private void ListCities()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM City", sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvCities.DataSource = dataTable;
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

        private void btnList_Click(object sender, EventArgs e)
        {
            ListCities();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("Insert into City (CityName,CityCountry) values (@cityName,@cityCountry)", sqlConnection);
                command.Parameters.AddWithValue("@cityName", txtCityName.Text);
                command.Parameters.AddWithValue("@cityCountry", txtCountryName.Text);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show(
                "Şehir başarıyla eklendi!",
                "Başarılı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                ListCities();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                           "Şehir eklenirken bir hata oluştu:\n" + ex.Message,
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
                int cityId = Convert.ToInt32(dgvCities.CurrentRow.Cells["CityId"].Value);

                sqlConnection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM City WHERE CityId=@cityId", sqlConnection);
                command.Parameters.AddWithValue("@cityId", cityId);
                command.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show(
               "Şehir başarıyla silindi!",
               "Başarılı",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

                ListCities();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                              "Şehir silinirken bir hata oluştu:\n" + ex.Message,
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
                    "UPDATE City SET CityName=@cityName, CityCountry=@cityCountry WHERE CityId=@cityId",
                    sqlConnection);
                command.Parameters.AddWithValue("@cityName", txtCityName.Text);
                command.Parameters.AddWithValue("@cityCountry", txtCountryName.Text);
                command.Parameters.AddWithValue("@cityId", txtCityID.Text);
                int affectedRows = command.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show(
              "Şehir başarıyla güncellendi!",
              "Başarılı",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);

                ListCities();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehir güncellenirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlCommand command = new SqlCommand("SELECT * FROM City WHERE CityName=@cityName", sqlConnection);
                command.Parameters.AddWithValue("@cityName", txtCityName.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvCities.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehir aranırken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                    sqlConnection.Close();
            }
        }
    }
}
