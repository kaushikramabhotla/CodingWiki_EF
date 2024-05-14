using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingWiki_Models.Models;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        public DbSet<Fluent_BookDetail> BookDetails_Fluent { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-1UMKQN7;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fluent_BookDetail>().ToTable("Fluent_BookDetails");
            modelBuilder.Entity<Fluent_BookDetail>().Property(u=>u.NumberOfChapters).HasColumnName("NoOfChapters");

            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.AuthorId, u.BookId });
            var BookList = new Book[]
            {
                new Book{BookId = 1, Title = "A", ISBN = "123", Price = 10, Publisher_Id = 1},
                new Book{BookId = 2, Title = "B", ISBN = "133", Price = 11, Publisher_Id = 1},
                new Book{BookId = 3, Title = "C", ISBN = "143", Price = 12, Publisher_Id = 2},
                new Book{BookId = 4, Title = "D", ISBN = "153", Price = 13, Publisher_Id = 3}
            };

            var PublisherList = new Publisher[]
            {
                new Publisher{Publisher_Id = 1, Name = "Pub 1 Jimmy", Location = "Chicago"},
                new Publisher{Publisher_Id = 2, Name = "Pub 2 John", Location = "New York"},
                new Publisher{Publisher_Id = 3, Name = "Pub 3 Ben", Location = "Hawaii"}
            };
            modelBuilder.Entity<Publisher>().HasData(PublisherList);
            modelBuilder.Entity<Book>().HasData(BookList);

            
        }
    }
}
