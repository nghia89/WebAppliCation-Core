using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAppCore.Application.ViewModels.System;

namespace WebAppCore.Application.Interfaces
{
   public interface IFunctionService:IDisposable  
    {
        Task<List<FunctionViewModel>> GetAll();

        List<FunctionViewModel> GetAllByPermission(Guid userId);
    }
}
