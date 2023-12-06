using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using System.Reflection.Metadata;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;

        // Remove Delete Cascade, because a seller does not can be removed with sales
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SalesRecord>()
                .HasOne(e => e.Seller)
                .WithMany(e => e.Sales)
                .OnDelete(DeleteBehavior.Restrict);
        }       
    }
}
