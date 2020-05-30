using AutoMapper;
using GamesStoreAPI.BusinessLogic.DTO;
using GamesStoreAPI.Entities.Entities;

namespace GamesStoreAPI.BusinessLogic.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AgeRestriction, AgeRestrictionDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Developer, DeveloperDto>().ReverseMap();
            CreateMap<Game, GameDto>().ReverseMap();
        }
    }
}