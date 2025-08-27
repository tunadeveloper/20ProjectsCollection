using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_EntityFrameworkProductManagementProject
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        DbProductManagementEntities5 db = new DbProductManagementEntities5();
        void ProductList()
        {
            try
            {
                var values = db.Product
                    .Join(db.Category,
                    product => product.CategoryId,
                    category => category.CategoryId,
                    (product, category) => new
                    {
                       ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        ProductStock = product.ProductStock,
                        ProductPrice = product.ProductPrice,
                        CategoryName = category.CategoryName,
                        CategoryId = product.CategoryId
                    })
                    .ToList();

                dgvProducts.DataSource = values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler listelenirken bir hata oluştu!: " + ex.Message);
            }
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.ProductName = txtProductName.Text;
                product.ProductStock = short.Parse(txtProductStock.Text);
                product.ProductPrice = decimal.Parse(txtProductPrice.Text);
                product.CategoryId = int.Parse(cboProductCategory.SelectedValue.ToString());
                db.Product.Add(product);
                db.SaveChanges();
                MessageBox.Show(
                   "Ürün başarıyla eklendi!",
                   "Başarılı",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                ProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                           "Ürün eklenirken bir hata oluştu:\n" + ex.Message,
                           "Hata",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var values = db.Product.Find(int.Parse(txtProductId.Text));
                db.Product.Remove(values);
                db.SaveChanges();
                MessageBox.Show(
                   "Ürün başarıyla silindi!",
                   "Başarılı",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                ProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                           "Ürün silinirken bir hata oluştu:\n" + ex.Message,
                           "Hata",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var values = db.Product.Find(int.Parse(txtProductId.Text));
                values.ProductName = txtProductName.Text;
                values.ProductStock = short.Parse(txtProductStock.Text);
                values.ProductPrice = decimal.Parse(txtProductPrice.Text);
                values.CategoryId = int.Parse(cboProductCategory.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün güncellenirken bir hata oluştu!: " + ex.Message);
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                var values = db.Category.ToList();
                cboProductCategory.DisplayMember = "CategoryName";
                cboProductCategory.ValueMember = "CategoryId";
                cboProductCategory.DataSource = values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler yüklenirken bir hata oluştu!: " + ex.Message);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var values = db.Product
                    .Where(p => p.ProductName == txtProductName.Text)
                    .Join(db.Category,
                    product => product.CategoryId,
                    category => category.CategoryId,
                    (product, category) => new
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        ProductStock = product.ProductStock,
                        ProductPrice = product.ProductPrice,
                        CategoryName = category.CategoryName,
                        CategoryId = product.CategoryId
                    })
                    .ToList();

                dgvProducts.DataSource = values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün aranırken bir hata oluştu!: " + ex.Message);
            }
        }
    }
}
