using System;
using System.Collections.Generic;
using System.Text;
using WebAppCore.Data.Entities;
using WebAppCore.Infrastructure.Interfaces;

namespace WebAppCore.Data.EF.Repositories
{
    public interface ITagRepository: IRepository<Tag,string>
    {
    }
}
