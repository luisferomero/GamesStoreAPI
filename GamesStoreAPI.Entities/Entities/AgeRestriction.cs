using System;
using System.Collections.Generic;

namespace GamesStoreAPI.Entities.Entities
{
    public class AgeRestriction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
