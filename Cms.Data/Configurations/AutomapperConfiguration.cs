using AutoMapper;

namespace Cms.Data.Configurations;
public class AutomapperConfiguration : Profile
{
    public AutomapperConfiguration()
    {
        CreateMap<Cms.Data.Entities.Post, Core.Models.Post>().ReverseMap();
        CreateMap<Cms.Data.Entities.Post, Core.DTOs.Post.PostCreateDto>().ReverseMap();
        CreateMap<Cms.Data.Entities.Category, Core.Models.Category>().ReverseMap();        
    }
}
