using System;
using System.Collections.Generic;

namespace GamesStoreAPI.BusinessLogic.DTO
{
    public class DeveloperDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<GameDto> Games { get; set; }
    }
}
