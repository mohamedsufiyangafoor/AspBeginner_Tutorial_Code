using AutoMapper;

namespace AspBeginner_Tutorial.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region,Models.DTO.Region>();
        }
    }
}
