using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppCore.Application.Interfaces;
using WebAppCore.Application.ViewModels.Product;
using WebAppCore.Data.IRepositories;

namespace WebAppCore.Application.Implementation
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x=>x.ProductCategory).ProjectTo<ProductViewModel>().ToList();
        }
    }
}
