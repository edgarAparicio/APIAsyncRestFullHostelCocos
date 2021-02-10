using EdgarAparicio.APIAsyncRestFul.Manager.Entity.Context;
using EdgarAparicio.APIAsyncRestFulHostelCocos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.APIAsyncRestFulHostelCocos.Repository.Repositories
{
    public class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : class
    {
        private readonly DbContextAPIAsyncRestFullHostelCocos _context;

        public BaseRepository(DbContextAPIAsyncRestFullHostelCocos context)
        {
            this._context = context;
        }
        public async Task<List<TypeEntity>> GetAsync()
        {
            var ListEntity = await _context.Set<TypeEntity>().ToListAsync();
            return ListEntity;
        }
    }
}
