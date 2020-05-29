using System;
namespace GamesStoreAPI.Entities.Entities
{
    /// <summary>
    /// Join table for many to many relationship
    /// </summary>
    public class GameCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int GameId { get; set; }
        public Game IGamed { get; set; }
    }
}
