using AutoMapper;

namespace Cms.Core.Configurations;
public class AutomapperConfiguration : Profile
{
    public AutomapperConfiguration()
    {
        CreateMap<DTOs.Post.PostCreateDto, Models.Post>().ReverseMap();
        CreateMap<DTOs.Post.PostEditDto, Models.Post>().ReverseMap();        
    }
}
