using Microsoft.EntityFrameworkCore;

namespace FirstProject.Context
{
    public class ApplicationDbContext : DbContext
    {
        //TODO put entity dbSet property
        //public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO apply entity configuration here
            //modelBuilder.ApplyConfiguration<entityConfig>(entityConfiguration); 
        }
    }
}
