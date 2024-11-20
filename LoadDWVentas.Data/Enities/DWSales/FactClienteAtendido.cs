using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public partial class FactClienteAtendido
    {
        [Key]
        public int CustomerKey { get; set; }
        public int EmployeeKey { get; set; }
        public decimal? Sells { get; set; }
        public int? OrdersQuantity { get; set; }
    }
}