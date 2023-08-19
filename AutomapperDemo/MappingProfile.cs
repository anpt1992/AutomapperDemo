using AutoMapper;

namespace AutomapperDemo;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Source, Destination>()
            .ForMember(dest => dest.Property9, opt => opt.MapFrom(src => src));

        CreateMap<Source, Property9[]>()
            .ConvertUsing<ArrayConverter>();
    }
}
