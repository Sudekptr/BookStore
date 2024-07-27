using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        // Constructor ve diğer kodlar

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Book ve Seller arasındaki ilişkiyi tanımlayın
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Seller)
                .WithMany(s => s.Books)
                .HasForeignKey(b => b.SellerId);
        }
    }
}


