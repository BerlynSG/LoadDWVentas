using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public partial class FactOrder
    {

        [Key]
        public int OrderID { get; set; }
        public int CustomerKey { get; set; }
        public int EmployeeKey { get; set; }
        public int ProductKey { get; set; }
        public int DateKey { get; set; }
        public int ShipperKey { get; set; }
        public string? Country { get; set; }
        public decimal? Sells { get; set; }
        public int SellsQuantity { get; set; }
    }
}