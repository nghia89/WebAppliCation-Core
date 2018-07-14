using WebAppCore.Data.Entities;
using WebAppCore.Infrastructure.Interfaces;

namespace WebAppCore.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
    }
}