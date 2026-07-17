using EtApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EtApi.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EtApiDbContext>
{
    public EtApiDbContext CreateDbContext(string[] arg)
    {

        var connectionString = "server=localhost;port=3306;database=EtApiDb;user=root;password=;";

        DbContextOptionsBuilder<EtApiDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        return new(dbContextOptionsBuilder.Options);
    }
}
