using System;
using System.Collections.Generic;
using System.Text;
using WebAppCore.Data.Entities;
using WebAppCore.Infrastructure.Interfaces;

namespace WebAppCore.Data.IRepositories
{
    public interface IProductRepository: IRepository<Product,int>
    {
    }
}
