using Library.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Library.Data.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Publisher> Publishers{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Adress> Adresses{ get; set; }
        public DbSet<BookPublisher> BookPublishers{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
