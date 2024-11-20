using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public partial class DimCustomer
    {
        [Key]
        public int CustomerKey { get; set; }
        public string CustomerID { get; set; }
        public string? CompanyName { get; set; }
    }
}