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

            //modelBuilder.Entity<Order>()
            //    .HasKey(o => o.Id);

            //modelBuilder.Entity<DispatchRider>()
            //    .HasKey(d => d.Id);

            //modelBuilder.Entity<SnailPurchase>()
            //    .HasKey(sp => sp.Id);

            //modelBuilder.Entity<Retailer>()
            //    .HasKey(r => r.Id);

            //modelBuilder.Entity<RetailSupply>()
            //    .HasKey(rs => rs.Id);

            //modelBuilder.Entity<SnailSpecification>()
            //    .HasKey(ss => ss.Id);

            //modelBuilder.Entity<SnailType>()
            //    .HasKey(st => st.Id);

            //modelBuilder.Entity<Supplier>()
            //    .HasKey(s => s.Id);

            //modelBuilder.Entity<DispatchRider>()
            //    .HasMany(o => o.Orders)
            //    .WithOne(d => d.DispatchRider)
            //    .HasForeignKey(d => d.Id);

            //modelBuilder.Entity<SnailPurchase>()
            //    .HasOne(s => s.Supplier)
            //    .WithOne(snailPurchase => snailPurchase.SnailSale)
            //    .HasForeignKey<Supplier>(snailPurchase => snailPurchase.Id);

            //modelBuilder.Entity<RetailSupply>()
            //    .HasOne(rs => rs.Retailer)
            //    .WithMany(r => r.RetailSupplies)
            //    .HasForeignKey(retailSupply => retailSupply.Id);

            //modelBuilder.Entity<SnailSpecification>()
            //    .HasOne(st => st.SnailType)
            //    .WithOne(b => b.SnailSpecification)
            //    .HasForeignKey<SnailType>(st => st.Id);

        }
    }
}
