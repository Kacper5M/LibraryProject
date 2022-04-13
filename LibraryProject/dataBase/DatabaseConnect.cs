using LibraryProject.dataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.dataBase
{
    class DatabaseConnect : DbContext
    {
        public DbSet<books> books { get; set; }
        public DbSet<users> users { get; set; }
        public DbSet<rentals> rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=libraryBase.db");
            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}
