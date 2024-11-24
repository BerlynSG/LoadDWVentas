using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public partial class FactCustomersServed
    {
        [Key]
        public int CustomersServedKey { get; set; }
        public int EmployeeKey { get; set; }
        public int? CustomerQuantity { get; set; }
    }
}