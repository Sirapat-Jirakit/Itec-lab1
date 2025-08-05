using itec_lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace itec_lab1.Data
{
    public class ItecStockDbContext (DbContextOptions<ItecStockDbContext> options) : DbContext(options)
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Officers> Officers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Officers - Categories (CreatedBy)
            modelBuilder.Entity<Categories>()
                .HasOne(c => c.CreatedBy)
                .WithMany(o => o.CategoryCreatedBy)
                .HasForeignKey(c => c.CategoryCreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Officers - Categories (UpdatedBy)
            modelBuilder.Entity<Categories>()
                .HasOne(c => c.UpdatedBy)
                .WithMany(o => o.CategoryUpdatedBy)
                .HasForeignKey(c => c.CategoryUpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Officers - Products (CreatedBy)
            modelBuilder.Entity<Products>()
                .HasOne(p => p.CreatedBy)
                .WithMany(o => o.ProductCreatedBy)
                .HasForeignKey(p => p.ProductCreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Officers - Products (UpdatedBy)
            modelBuilder.Entity<Products>()
                .HasOne(p => p.UpdatedBy)
                .WithMany(o => o.ProductUpdatedBy)
                .HasForeignKey(p => p.ProductUpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
