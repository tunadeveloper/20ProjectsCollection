using _4_EntityFrameworkCodeFirstMovieProject.DataAccess.Context;
using _4_EntityFrameworkCodeFirstMovieProject.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_EntityFrameworkCodeFirstMovieProject
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        MovieContext context = new MovieContext();
        public void CategoryList()
        {
            try
            {
                dgvCategories.DataSource = context.Categories
    .Select(c => new { c.CategoryId, c.CategoryName })
    .ToList();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = txtCategoryName.Text;
                context.Categories.Add(category);
                context.SaveChanges();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCategoryId.Text);
                var values = context.Categories.Find(id);
                values.CategoryName = txtCategoryName.Text;
                context.SaveChanges();
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
            try { 
            var values = context.Categories.Where(x => x.CategoryName.Contains(txtCategoryName.Text)).ToList();
            dgvCategories.DataSource = values;
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                           "Kategori aranırken bir hata oluştu:\n" + ex.Message,
                           "Hata",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCategoryId.Text);
                var values = context.Categories.Find(id);
                context.Categories.Remove(values);
                context.SaveChanges();
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
    }
}
