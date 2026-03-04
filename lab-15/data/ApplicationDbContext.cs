using lab_15;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_15
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(a => a.AuthorId);
                entity.Property(a => a.Name).IsRequired().HasMaxLength(100);
            });


            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.HasKey(ba => new { ba.BookId, ba.AuthorId });

                entity.HasOne(ba => ba.Book)
                      .WithMany(b => b.BookAuthors)
                      .HasForeignKey(ba => ba.BookId);

                entity.HasOne(ba => ba.Author)
                      .WithMany(a => a.BookAuthors)
                      .HasForeignKey(ba => ba.AuthorId);
            });


            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(r => r.ReviewId);

                entity.HasOne(r => r.Book)
                      .WithMany(b => b.Reviews)
                      .HasForeignKey(r => r.BookId);
            });


            modelBuilder.Entity<Book>()
            .HasMany(b => b.Tags)
            .WithMany(t => t.Books);


            modelBuilder.Entity<PriceOffer>()
                .HasOne(po => po.Book)
                .WithOne(b => b.PriceOffer)
                .HasForeignKey<PriceOffer>(po => po.BookId);
        }
    }
}
