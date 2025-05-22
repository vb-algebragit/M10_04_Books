using BooksAdmin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BooksAdmin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Author>().HasData(
                new Author() { Id = 1, Name = "Autor1" },
                new Author() { Id = 2, Name = "Autor2" },
                new Author() { Id = 3, Name = "Autor3" },
                new Author() { Id = 4, Name = "Autor4" },
                new Author() { Id = 5, Name = "Autor5" }
                );
            builder.Entity<Publisher>().HasData(
                new Publisher() { Id = 1, Name = "Publisher1" },
                new Publisher() { Id = 2, Name = "Publisher2" },
                new Publisher() { Id = 3, Name = "Publisher3" }
                );
        }
    }
}
