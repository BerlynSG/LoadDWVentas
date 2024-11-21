namespace LoadDWVentas.Data.Entities.Northwind
{
    public partial class VWSales
    {
        public int OrderId { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int ShipperId { get; set; }
        public string? CompanyName { get; set; }
        public string? Country { get; set; }
        public int? DateKey { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal? Sells { get; set; }
        public int? SellsQuantity { get; set; }
    }
}