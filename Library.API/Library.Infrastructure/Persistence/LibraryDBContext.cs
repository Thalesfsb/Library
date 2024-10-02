using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Library.Infrastructure.Persistence
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configura chave primaria do livro
            builder.Entity<Book>()
                .HasKey(b => b.Id);



            base.OnModelCreating(builder);
        }
    }
}
