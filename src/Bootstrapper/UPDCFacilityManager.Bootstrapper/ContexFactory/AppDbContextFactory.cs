using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UPDCFacilityManager.Modules.Auth.Core.Data;

namespace UPDCFacilityManager.Bootstrapper.ContextFactory;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.Development.json", reloadOnChange: true, optional: true)
            .AddJsonFile($"appsettings.Production.json", reloadOnChange: true, optional: true)
            // .AddUserSecrets(Assembly.GetAssembly(typeof(Program)))
            .AddEnvironmentVariables()
            .Build();

        var builder = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(config.GetConnectionString("DefaultConnection"), 
                b => b.MigrationsAssembly("UPDCFacilityManager.Modules.Auth.Core"));

        return new AppDbContext(builder.Options);
    }
}