using System;
using System.Collections.Generic;

namespace GamesStoreAPI.Entities.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
