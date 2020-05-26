using System;
using System.Collections.Generic;

namespace GamesStoreAPI.Entities.Entities
{
    public class Developer
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
