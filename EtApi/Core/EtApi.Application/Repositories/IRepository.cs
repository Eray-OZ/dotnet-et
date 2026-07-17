using Microsoft.EntityFrameworkCore;
using EtApi.Domain.Entities.Common;

namespace EtApi.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }

}
