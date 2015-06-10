using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day9Associations.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Category> Categories { get; set; }
    }
}