using EtApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EtApi.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EtApiDbContext>
{
    public EtApiDbContext CreateDbContext(string[] arg)
    {



        var connectionString = Configuration.ConnectionString;

        DbContextOptionsBuilder<EtApiDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        return new(dbContextOptionsBuilder.Options);
    }
}
