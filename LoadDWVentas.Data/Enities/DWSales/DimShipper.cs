using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public partial class DimShipper
    {
        [Key]
        public int ShipperKey { get; set; }
        public int ShipperID { get; set; }
        public string? CompanyName { get; set; }
    }
}