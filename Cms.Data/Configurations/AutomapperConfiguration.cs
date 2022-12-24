using AutoMapper;

namespace Cms.Data.Configurations;
public class AutomapperConfiguration : Profile
{
    public AutomapperConfiguration()
    {
        CreateMap<Cms.Data.Entities.Post, Core.Domains.Post>().ReverseMap();
    }
}
