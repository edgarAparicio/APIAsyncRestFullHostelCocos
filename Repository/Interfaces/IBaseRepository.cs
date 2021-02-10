using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.APIAsyncRestFulHostelCocos.Repository.Interfaces
{
    public interface IBaseRepository<TypeEntity>
    {
        Task<List<TypeEntity>> GetAsync();
    }
}
