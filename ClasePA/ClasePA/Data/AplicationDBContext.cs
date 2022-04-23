using ClasePA.Models;
using Microsoft.EntityFrameworkCore;

namespace ClasePA.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options)
           : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }  

        public DbSet<Enrrollements> Enrrollements { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        }
         

    }
}
