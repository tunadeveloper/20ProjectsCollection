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
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }
        MovieContext context = new MovieContext();
        private void MovieList()
        {
            try
            {
                dgvMovies.DataSource = context.Movies
                            .Include("Category")
                            .Select(m => new
                            {
                                m.MovieId,
                                m.MovieTitle,
                                m.MovieDuration,
                                m.MovieDescription,
                                m.CreatedDate,
                                CategoryName = m.Category.CategoryName
                            })
                                   .ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(
                           "Filmler listelenirken bir hata oluştu:\n" + ex.Message,
                           "Hata",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            MovieList();
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
            cboCategory.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Movie movie = new Movie();
                movie.MovieTitle = txtMovieName.Text;
                movie.MovieDuration = Convert.ToInt32(txtDuration.Text);
                movie.MovieDescription = rtbDescription.Text;
                movie.CategoryId = (int)cboCategory.SelectedValue;
                movie.CreatedDate = DateTime.Parse(mskWatchDate.Text);
                if (cboCategory.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir kategori seçin!");
                    return;
                }

                movie.CategoryId = (int)cboCategory.SelectedValue;

                context.Movies.Add(movie);
                context.SaveChanges();
                MessageBox.Show(
                    "Film başarıyla eklendi!",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                MovieList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                           "Film eklenirken bir hata oluştu:\n" + ex.Message,
                           "Hata",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int movieId = Convert.ToInt32(dgvMovies.CurrentRow.Cells["MovieId"].Value);
                var movie = context.Movies.Find(movieId);
                context.Movies.Remove(movie);
                context.SaveChanges();
                MessageBox.Show("Film başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film silinirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int movieId = Convert.ToInt32(dgvMovies.CurrentRow.Cells["MovieId"].Value);
                var movie = context.Movies.Find(movieId);

                movie.MovieTitle = txtMovieName.Text;
                movie.MovieDuration = Convert.ToInt32(txtDuration.Text);
                movie.MovieDescription = rtbDescription.Text;
                movie.CategoryId = (int)cboCategory.SelectedValue;
                movie.CreatedDate = DateTime.Parse(mskWatchDate.Text);

                context.SaveChanges();
                MessageBox.Show("Film başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MovieList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film güncellenirken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtMovieName.Text.Trim();

                var result = context.Movies
                    .Include("Category")
                    .Where(m => m.MovieTitle.Contains(searchTerm))
                    .Select(m => new
                    {
                        m.MovieId,
                        m.MovieTitle,
                        m.MovieDuration,
                        m.MovieDescription,
                        m.CreatedDate,
                        CategoryName = m.Category.CategoryName
                    })
                    .ToList();

                dgvMovies.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film aranırken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
