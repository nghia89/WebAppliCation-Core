using System;
using System.Collections.Generic;
using System.Text;
using WebAppCore.Application.ViewModels.Product;

namespace WebAppCore.Application.Interfaces
{
    public interface IProductService : IDisposable
    {      
        List<ProductViewModel> GetAll();
    }
}
