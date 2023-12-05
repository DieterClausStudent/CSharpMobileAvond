using AutoMapper;
using PieShop.API.Entitites;
using PieShop.API.Models;

namespace PieShop.API.Profiles
{
    public class PieProfile : Profile
    {
        public PieProfile()
        {
            CreateMap<Pie, PieDto>().ReverseMap();
        }
    }
}
