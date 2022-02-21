using placeMarket.api.Models;
using Microsoft.EntityFrameworkCore;

namespace placeMarket.api.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<ExternalLogin> ExternalLogins { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRol> UserRols { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserRol>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRols)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserRol>()
                .HasOne(ur => ur.Course)
                .WithMany(u => u.UserRols)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Category>()
                .HasOne(c => c.FatherCategory)
                .WithMany(cC => cC.ChildrenCategories)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}