using System.Data.Entity;
using Kelasi.Model;

namespace Kelasi.Repository.Repositories
{
    public class Kelasi : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages { get; set;}
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Videos { get; set; }

        public Kelasi()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Kelasi>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // inherited table types
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Author>().ToTable("Users_Authors");
        }
    }
}
