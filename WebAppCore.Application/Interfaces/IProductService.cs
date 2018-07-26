using System;
using System.Collections.Generic;
using WebAppCore.Application.ViewModels.Product;
using WebAppCore.Utilities.Dtos;

namespace WebAppCore.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

        ProductViewModel Add(ProductViewModel productVm);

        void Update(ProductViewModel product);

        void Delete(int id);

        ProductViewModel GetById(int id);

        void ImportExcel(string filePath, int categoryId);

        void Save();
    }
}