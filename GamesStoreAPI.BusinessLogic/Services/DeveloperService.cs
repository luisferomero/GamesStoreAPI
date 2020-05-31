using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GamesStoreAPI.BusinessLogic.DTO;
using GamesStoreAPI.BusinessLogic.Services.Interfaces;
using GamesStoreAPI.Data.Contexts;
using GamesStoreAPI.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamesStoreAPI.BusinessLogic.Services
{
    public class DeveloperService : IDeveloperService
    {
        public GamesStoreContext Context { get; }

        public DeveloperService(GamesStoreContext context)
        {
            Context = context;
        }

        public async Task<List<Developer>> GetDevelopersListAsync()
        {
            return await Context.Developers.ToListAsync();
        }
    }
}