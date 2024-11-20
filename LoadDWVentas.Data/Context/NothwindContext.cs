
using LoadDWVentas.Data.Entities.Northwind;
using Microsoft.EntityFrameworkCore;

namespace LoadDWVentas.Data.Context
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {
            
        }

        // DbSets //
        #region "Db Sets"
            public DbSet<Category> Categories { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderDetail> OrderDetails { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Shipper> Shippers { get; set; }
        #endregion
    }
}