using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EntityFrameworkCodeFirstMovieProject.DataAccess.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public int MovieDuration { get; set; }
        public string MovieDescription { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
