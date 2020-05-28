using System;
using System.Collections.Generic;

namespace GamesStoreAPI.BusinessLogic.DTO
{
    public class AgeRestrictionDto
    {
        public class AgeRestriction
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Img { get; set; }

            public ICollection<GameDto> Games { get; set; }
        }
    }
}
