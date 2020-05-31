using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GamesStoreAPI.BusinessLogic.DTO;
using GamesStoreAPI.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class DevelopersController : ControllerBase
    {
        public IDeveloperService DeveloperService { get; }
        public IMapper Mapper { get; }

        public DevelopersController(IDeveloperService developerService, IMapper mapper)
        {
            DeveloperService = developerService;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeveloperDto>>> GetDeveloperslist()
        {
            var developers = await DeveloperService.GetDevelopersListAsync();
            return Ok(Mapper.Map<List<DeveloperDto>>(developers));
        }
    }
}