using LoadDWVentas.Data.Context;
using LoadDWVentas.Data.Interfaces;
using LoadDWVentas.Data.Sercices;
using LoadDWVentas.WorkerService;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
        /*var builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddHostedService<Worker>();

        var host = builder.Build();
        host.Run();*/
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddDbContextPool<NorthwindContext>(options => options.UseSqlServer(hostContext.Configuration.GetConnectionString("Northwind")));

                services.AddDbContextPool<DWSalesContext>(options => options.UseSqlServer(hostContext.Configuration.GetConnectionString("DWSales")));

                services.AddScoped<IDataServiceDwSales, DataServiceDwSales>();

                services.AddHostedService<Worker>();
            });
        
}
