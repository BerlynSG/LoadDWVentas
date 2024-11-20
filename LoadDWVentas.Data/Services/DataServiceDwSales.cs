
using LoadDWVentas.Data.Context;
using LoadDWVentas.Data.Entities.DWSales;
using LoadDWVentas.Data.Interfaces;
using LoadDWVentas.Data.Result;

namespace LoadDWVentas.Data.Sercices
{
    public class DataServiceDwSales : IDataServiceDwSales
    {
        private readonly NorthwindContext _northwindContext;
        private readonly DWSalesContext _dwSalesContext;

        public DataServiceDwSales(NorthwindContext northwindContext, DWSalesContext dwSalesContext)
        {
            _northwindContext = northwindContext;
            _dwSalesContext = dwSalesContext;
        }

        public async Task<OperationResult> LoadDimCustomer()
        {
            OperationResult result = new OperationResult();
            
            try
            {
                //Obtenemos todos los empleados
                var customers = _northwindContext.Customers.Select(cus => new DimCustomer() {
                    CustomerID = cus.CustomerID,
                    CompanyName = cus.CompanyName,
                }).ToList();

                //Insertamos en la dimensión
                await _dwSalesContext.DimCustomers.AddRangeAsync(customers);
                await _dwSalesContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error al cargar la dimensión Customer {ex.Message}";
            }

            return result;
        }

        public async Task<OperationResult> LoadDimEmployee()
        {
            OperationResult result = new OperationResult();
            
            try
            {
                //Obtenemos todos los empleados
                var employees = _northwindContext.Employees.Select(emp => new DimEmployee() {
                    EmployeeKey = emp.EmployeeID,
                    FullName = string.Concat(emp.FirstName, " ", emp.LastName)
                }).ToList();

                //Insertamos en la dimensión
                await _dwSalesContext.DimEmployees.AddRangeAsync(employees);
                await _dwSalesContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error al cargar la dimensión Employee {ex.Message}";
            }

            return result;
        }

        public async Task<OperationResult> LoadDimProduct()
        {
            OperationResult result = new OperationResult();

            try
            {
                //Obtenemos todos los productos
                var products = (from product in _northwindContext.Products
                join category in _northwindContext.Categories on product.CategoryID equals category.CategoryID
                select new DimProduct() {
                    ProductId = product.ProductID,
                    ProductName = product.ProductName,
                    CategoryId = category.CategoryID,
                    CategoryName = category.CategoryName
                }).ToList();

                //Insertamos en la dimensión
                await _dwSalesContext.DimProducts.AddRangeAsync(products);
                await _dwSalesContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error al cargar la dimensión Product. {ex.Message}";
            }

            return result;
        }

        public async Task<OperationResult> LoadDimShipper()
        {
            OperationResult result = new OperationResult();
            
            try
            {
                //Obtenemos todos los empleados
                var shippers = _northwindContext.Shippers.Select(emp => new DimShipper() {
                    ShipperKey = emp.ShipperID,
                    ShipperName = emp.CompanyName
                }).ToList();

                //Insertamos en la dimensión
                await _dwSalesContext.DimShippers.AddRangeAsync(shippers);
                await _dwSalesContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error al cargar la dimensión Shipper {ex.Message}";
            }

            return result;
        }
    }
}