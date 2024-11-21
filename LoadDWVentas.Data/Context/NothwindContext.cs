
using LoadDWVentas.Data.Entities.Northwind;
using Microsoft.EntityFrameworkCore;

namespace LoadDWVentas.Data.Context
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {
            
        }

        // DbSets //
        #region "Db Sets"
            public DbSet<Category> Categories { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Employee> Employees { get; set; }
            //public DbSet<Order> Orders { get; set; }
            //public DbSet<OrderDetail> OrderDetails { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Shipper> Shippers { get; set; }
            public DbSet<VWSales> VWSales { get; set; }
            public DbSet<VWCustomersServed> VWCustomersServed { get; set; }

        #endregion
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.UnitPrice)
                .HasPrecision(18, 2); // 18 dígitos en total, 2 después del punto decimal
            modelBuilder.Entity<VWSales>(entity => 
            {
                entity.HasNoKey().ToView("VWSales");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");
                entity.Property(e => e.CompanyName)
                    .IsRequired().HasMaxLength(40);
                entity.Property(e => e.CustomerId)
                    .IsRequired().HasMaxLength(5)
                    .IsFixedLength().HasMaxLength(40);
                entity.Property(e => e.CompanyName)
                    .IsRequired().HasMaxLength(40);
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                entity.Property(e => e.EmployeeName).IsRequired().HasMaxLength(31);
                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
                entity.Property(e => e.Sells).HasColumnType("money");
            });
            
            modelBuilder.Entity<VWCustomersServed>(entity => 
            {
                entity.HasNoKey().ToView("VWCustomersServed");

                entity.Property(e => e.EmployeeID).HasColumnName("EmployeeID");
                entity.Property(e => e.EmployeeName).IsRequired().HasMaxLength(31);
            });
        }

    }
}