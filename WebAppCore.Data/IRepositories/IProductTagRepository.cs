using WebAppCore.Data.Entities;
using WebAppCore.Infrastructure.Interfaces;

namespace WebAppCore.Data.EF.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag, int>
    {
    }
}