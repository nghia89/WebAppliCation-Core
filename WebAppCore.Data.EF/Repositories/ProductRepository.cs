using WebAppCore.Data.Entities;
using WebAppCore.Data.IRepositories;

namespace WebAppCore.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}