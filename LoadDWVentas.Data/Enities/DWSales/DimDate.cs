using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public partial class DimDate
    {
        [Key]
        public int DateKey { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
    }
}