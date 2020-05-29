using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamesStoreAPI.Entities.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverImg { get; set; }
        public double Rating { get; set; }

        public AgeRestriction AgeRestriction { get; set; }
        public Developer Developer { get; set; }
        public ICollection<GameCategory> GamesCategories { get; set; }
    }
}
