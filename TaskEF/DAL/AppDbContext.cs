using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEF.Models;

namespace TaskEF.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=WINDOWS-DPJDVHL\\SQLEXPRESS;database=Week9Task1;trusted_connection=true;integrated security=true;encrypt=false");
        }

        public DbSet<Student> Students { get; set; }
    }
}
