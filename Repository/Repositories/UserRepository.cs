using EdgarAparicio.APIAsyncRestFul.Manager.Entity.Context;
using EdgarAparicio.APIAsyncRestFul.Manager.Entity.Entities;
using EdgarAparicio.APIAsyncRestFulHostelCocos.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdgarAparicio.APIAsyncRestFulHostelCocos.Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly DbContextAPIAsyncRestFullHostelCocos context;

        public UserRepository(DbContextAPIAsyncRestFullHostelCocos context) : base (context)
        {
            this.context = context;
        }


    }
}
