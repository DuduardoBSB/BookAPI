using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            var created = this.Database.EnsureCreated();

            if (created)
            {
                this.Books.Add(new Book { Name = "Harry Potter and the Sorcerer's Stone" });
                this.Books.Add(new Book { Name = "Harry Potter and the Chamber of Secrets" });
                this.Books.Add(new Book { Name = "Harry Potter and the Prisoner of Azkaban" });
                this.Books.Add(new Book { Name = "Harry Potter and the Goblet of Fire" });
                this.Books.Add(new Book { Name = "Harry Potter and the Order of the Phoenix" });
                this.Books.Add(new Book { Name = "Harry Potter and the Half-Blood Prince" });
                this.Books.Add(new Book { Name = "Harry Potter and the Deathly Hallows" });
                this.Books.Add(new Book { Name = "Docker Book" });

                this.SaveChanges();
            }
        }

        public DbSet<Book> Books { get; set; } = null!;
    }
}