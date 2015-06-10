using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DBStart.Migrations;

namespace DBStart.Models
{
    public class MovieDbContext : DbContext
    {
        public IDbSet<Movie> Movies { get; set; }

        static MovieDbContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovieDbContext, Configuration>());
        }
    }
}