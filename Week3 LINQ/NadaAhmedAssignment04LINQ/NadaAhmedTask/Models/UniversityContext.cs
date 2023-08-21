using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NadaAhmedTask.Models
{
    internal class UniversityContext: DbContext
    {
        public UniversityContext() { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NADALAPLENOVO\\SQLEXPRESS ;Database=Uni(Migration);Trusted_Connection=True;Encrypt=False");
        }
    }
}
