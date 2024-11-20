using System.ComponentModel.DataAnnotations;

namespace LoadDWVentas.Data.Entities.DWSales
{
    public class DimProduct
    {
        [Key]
        public int ProductKey { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}