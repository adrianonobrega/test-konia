using Exercicio01.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {

                   services.AddDbContext<MyContext>(options =>
                   {
                       var DatabaseString = "Data Source=DESKTOP-3CD12TB\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=False";
                       options.UseSqlServer(DatabaseString);
                   });
               }).UseConsoleLifetime();

        var host = builder.Build();
    }
}