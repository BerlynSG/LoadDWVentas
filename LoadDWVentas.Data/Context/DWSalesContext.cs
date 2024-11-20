
using LoadDWVentas.Data.Entities.DWSales;
using Microsoft.EntityFrameworkCore;

namespace LoadDWVentas.Data.Context
{
    public class DWSalesContext : DbContext
    {
        public DWSalesContext(DbContextOptions<DWSalesContext> options) : base(options)
        {
            
        }

        // DbSets //
        #region "Db Sets"
            public DbSet<DimCustomer> DimCustomers { get; set; }
            public DbSet<DimDate> DimDates { get; set; }
            public DbSet<DimEmployee> DimEmployees { get; set; }
            public DbSet<DimProduct> DimProducts { get; set; }
            public DbSet<DimShipper> DimShippers { get; set; }

            //public DbSet<FactOrder> FactOrders { get; set; }
            //public DbSet<FactClienteAtendido> FactClientesAtendidos { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimCustomer>().HasKey(e => e.CustomerKey); // Establece la clave primaria
            modelBuilder.Entity<DimDate>().HasKey(e => e.DateKey); // Establece la clave primaria
            modelBuilder.Entity<DimEmployee>().HasKey(e => e.EmployeeKey); // Establece la clave primaria
            modelBuilder.Entity<DimProduct>().HasKey(e => e.ProductKey); // Establece la clave primaria
            modelBuilder.Entity<DimShipper>().HasKey(e => e.ShipperKey); // Establece la clave primaria
        }
    }
}