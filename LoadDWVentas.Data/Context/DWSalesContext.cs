
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

            public DbSet<FactOrder> FactOrders { get; set; }
            //public DbSet<FactClienteAtendido> FactClientesAtendidos { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FactOrder>()
                .Property(p => p.Sells)
                .HasPrecision(18, 2); // 18 dígitos en total, 2 después del punto decimal
        }
    }
}