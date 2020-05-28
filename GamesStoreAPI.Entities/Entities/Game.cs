using System;
using System.Collections.Generic;

namespace GamesStoreAPI.Entities.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverImg { get; set; }
        public double Rating { get; set; }

        public Developer Developer { get; set; }
        public AgeRestriction AgeRestriction { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
