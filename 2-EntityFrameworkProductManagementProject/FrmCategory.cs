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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        DbProductManagementEntities5 db = new DbProductManagementEntities5();

        void CategoryList()
        {
            try
            {
                dgvCategories.DataSource = db.Category.Select(x => new
                {
                    x.CategoryId, x.CategoryName
                })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler listelenirken bir hata oluştu!: " + ex.Message);

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = txtCategoryName.Text;
                db.Category.Add(category);
                db.SaveChanges();
                MessageBox.Show(
                   "Kategori başarıyla eklendi!",
                   "Başarılı",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                CategoryList();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtCategoryId.Text);
                var value = db.Category.Find(id);
                db.Category.Remove(value);
                db.SaveChanges();
                MessageBox.Show(
                 "Kategori başarıyla silindi!",
                 "Başarılı",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                CategoryList();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtCategoryId.Text);
                var value = db.Category.Find(id);
                value.CategoryName = txtCategoryName.Text;
                db.SaveChanges();
                MessageBox.Show(
                 "Kategori başarıyla güncellendi!",
                 "Başarılı",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                CategoryList();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var values = db.Category.Where(p => p.CategoryName == txtCategoryName.Text).Select(x => new
                {
                    x.CategoryId,
                    x.CategoryName
                }).ToList();
                dgvCategories.DataSource = values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori aranırken bir hata oluştu!: " + ex.Message);
            }
        }

    }
}
