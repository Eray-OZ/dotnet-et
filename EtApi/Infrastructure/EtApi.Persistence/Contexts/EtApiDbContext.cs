using EtApi.Domain.Entities;
using EtApi.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;


namespace EtApi.Persistence.Contexts;

public class EtApiDbContext : DbContext
{
    public EtApiDbContext(DbContextOptions<EtApiDbContext> options) : base(options){}


    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }



    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker
        .Entries<BaseEntity>();


        foreach (var data in datas)
        {
            var _ = data.State switch
            {
                EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now
            };
        }


        return await base.SaveChangesAsync(cancellationToken);
    }


}
