using AutoMapper;
using CoffeeReviewBackend.Models;

namespace CoffeeReviewBackend.Dto
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            CreateMap<Coffee, CoffeeDto>()
                .ForMember(dest => dest.BrandDto,
                opt => opt.MapFrom(src => src.Brand));

            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.UserDto,
                opt => opt.MapFrom(src => src.User))
                .ForMember(dest => dest.CoffeeDto, 
                opt => opt.MapFrom(src => src.Coffee));

            CreateMap<User, UserDto>();
            CreateMap<Brand, BrandDto>();

        }

    }
}
