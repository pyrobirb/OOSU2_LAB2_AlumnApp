using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contexts
{
    public class AlumniKontaktContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OOSU2Lab2TestProject;Trusted_Connection=True;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Alumn> Alumner { get; set; }
    }
}
