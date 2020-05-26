using System;
using System.Collections.Generic;

namespace GamesStoreAPI.Entities.Entities
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
