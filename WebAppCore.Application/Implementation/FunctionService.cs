using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppCore.Application.Interfaces;
using WebAppCore.Application.ViewModels.System;
using WebAppCore.Data.IRepositories;

namespace WebAppCore.Application.Implementation
{
    public class FunctionService : IFunctionService
    {
        IFunctionRepository _IFunctionRepository;
        public FunctionService(IFunctionRepository IFunctionRepository)
        {
            _IFunctionRepository = IFunctionRepository; 
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<FunctionViewModel>> GetAll()
        {
           return _IFunctionRepository.FindAll().ProjectTo<FunctionViewModel>().ToListAsync();
        }

        public List<FunctionViewModel> GetAllByPermission(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
