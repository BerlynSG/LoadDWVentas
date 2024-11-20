using LoadDWVentas.Data.Entities.DWSales;
using LoadDWVentas.Data.Result;

namespace LoadDWVentas.Data.Interfaces
{
    public interface IDataServiceDwSales
    {
        /*Task<OperationResult> LoadDimCustomer();
        Task<OperationResult> LoadDimEmployee();
        Task<OperationResult> LoadDimProduct();
        Task<OperationResult> LoadDimShipper();*/

        Task<OperationResult> LoadDWH();
    }
}