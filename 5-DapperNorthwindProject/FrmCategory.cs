using _5_DapperNorthwindProject.DTOs.CategoryRepositories;
using Dapper;
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

namespace _5_DapperNorthwindProject
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=TUNA\\SQLEXPRESS;initial catalog=NorthwindDb;integrated security=true");

        public async void CategoryList()
        {
            try
            {
                string query = "Select * From Categories";
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                dgvCategories.DataSource = values.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kategoriler listelenirken bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into Categories (CategoryName, Description) Values (@p1, @p2)";
                var parameteres = new DynamicParameters();
                parameteres.Add("@p1", txtName.Text);
                parameteres.Add("@p2", txtDescription.Text);
                await connection.ExecuteAsync(query, parameteres);

                MessageBox.Show(
                    "Kategori başarıyla eklendi!",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CategoryList();
                await UpdateStatisticsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kategori eklenirken bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete From Categories Where CategoryId=@categoryId";
                var parameteres = new DynamicParameters();
                parameteres.Add("@categoryId", txtId.Text);
                await connection.ExecuteAsync(query, parameteres);

                MessageBox.Show(
                    "Kategori başarıyla silindi!",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CategoryList();
                await UpdateStatisticsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kategori silinirken bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Update Categories Set CategoryName=@categoryName, Description=@description Where CategoryId=@categoryId";
                var parameteres = new DynamicParameters();
                parameteres.Add("categoryName", txtName.Text);
                parameteres.Add("description", txtDescription.Text);
                parameteres.Add("categoryId", txtId.Text);
                await connection.ExecuteAsync(query, parameteres);

                MessageBox.Show(
                    "Kategori başarıyla güncellendi!",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CategoryList();
                await UpdateStatisticsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kategori güncellenirken bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void FrmCategory_Load(object sender, EventArgs e)
        {
            await UpdateStatisticsAsync();
        }

        private async Task UpdateStatisticsAsync()
        {
            try
            {
                int totalCategory = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Categories");
                int totalProduct = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM Products");
                int avgProductStock = await connection.ExecuteScalarAsync<int>("SELECT AVG(UnitsInStock) FROM Products");
                decimal avgProductPrice = await connection.ExecuteScalarAsync<decimal>("SELECT AVG(UnitPrice) FROM Products");
                string mostUsedCategory = await connection.ExecuteScalarAsync<string>("SELECT TOP 1 c.CategoryName FROM Categories c INNER JOIN Products p ON c.CategoryId = p.CategoryId GROUP BY c.CategoryName ORDER BY COUNT(p.ProductId) DESC");

                lblTotalCategories.Text = "Toplam Kategori Sayısı: " + totalCategory;
                lbltotalProduct.Text = "Toplam Ürün Sayısı: " + totalProduct;
                lblavgProductStock.Text = "Ortlama Ürün Sayısı: " + avgProductStock;
                lblavgProductPrice.Text = "Ortlama Ürün Fiyatı: " + avgProductPrice;
                lblmostUsedCategory.Text = "En Çok Kullanılan Kategori: " + mostUsedCategory;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstatistikler alınırken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTotalCategories.Text = "Toplam Kategori Sayısı: -";
                lblavgProductPrice.Text = "Toplam Ürün Sayısı: -";
                lblmostUsedCategory.Text = "Ortlama Ürün Sayısı: -";
                lbltotalProduct.Text = "Ortlama Ürün Fiyatı: -";
                lblmostUsedCategory.Text = "En Çok Kullanılan Kategori: -";
            }
        }
    }
}
