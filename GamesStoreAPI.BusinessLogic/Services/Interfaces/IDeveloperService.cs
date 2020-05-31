using System.Collections.Generic;
using System.Threading.Tasks;
using GamesStoreAPI.BusinessLogic.DTO;
using GamesStoreAPI.Entities.Entities;

namespace GamesStoreAPI.BusinessLogic.Services.Interfaces
{
    public interface IDeveloperService
    {
        Task<List<Developer>> GetDevelopersListAsync();
    }
}