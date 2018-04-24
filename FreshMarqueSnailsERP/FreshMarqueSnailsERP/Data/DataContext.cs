using FreshMarqueSnailsERP.Models;
using Microsoft.EntityFrameworkCore;

namespace FreshMarqueSnailsERP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<DispatchRider> DispatchRiders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SnailPurchase> SnailPurchases { get; set; }
        public DbSet<SnailType> SnailTypes { get; set; }
        public DbSet<SnailSpecification> SnailSpecifications { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<RetailSupply> RetailSupplies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DispatchRider>()
                .HasMany(o => o.Orders)
                .WithOne(d => d.DispatchRider)
                .HasForeignKey(d => d.OrderId);

            modelBuilder.Entity<SnailPurchase>()
                .HasOne(s => s.Supplier)
                .WithOne(snailPurchase => snailPurchase.SnailSale)
                .HasForeignKey<Supplier>(snailPurchase => snailPurchase.SupplierId);

            modelBuilder.Entity<RetailSupply>()
                .HasOne(rs => rs.Retailer)
                .WithMany(r => r.RetailSupplies)
                .HasForeignKey(retailSupply => retailSupply.RetailSupplyId);

            modelBuilder.Entity<SnailSpecification>()
                .HasOne(st => st.SnailType)
                .WithOne(b => b.SnailSpecification)
                .HasForeignKey<SnailType>(st => st.SnailTypeId);

        }
    }
}
