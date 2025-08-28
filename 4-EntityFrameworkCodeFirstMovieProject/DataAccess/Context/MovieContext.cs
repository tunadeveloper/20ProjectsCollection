using _4_EntityFrameworkCodeFirstMovieProject.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EntityFrameworkCodeFirstMovieProject.DataAccess.Context
{
    public class MovieContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
