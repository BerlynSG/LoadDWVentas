using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public partial class DimEmployee
    {

        [Key]
        public int EmployeeKey { get; set; }
        public int EmployeeID { get; set; }
        public string? FullName { get; set; }
    }
}