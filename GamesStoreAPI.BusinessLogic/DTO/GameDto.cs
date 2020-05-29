using System;
using System.Collections.Generic;

namespace GamesStoreAPI.BusinessLogic.DTO
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverImg { get; set; }
        public double Rating { get; set; }

        public DeveloperDto Developer { get; set; }
        public AgeRestrictionDto AgeRestriction { get; set; }
        public ICollection<CategoryDto> Categories { get; set; }
    }
}
