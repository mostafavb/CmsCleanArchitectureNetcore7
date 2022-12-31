using AutoMapper;
using Cms.Core.Interfaces.Repository;
using Cms.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Repositories;
public class PostRepository : BaseRepository<Cms.Data.Entities.Post, Cms.Core.Models.Post>, IPostRepository
{
    private readonly CmsDbContext cmsDb;
    private readonly IMapper mapper;

    public PostRepository(CmsDbContext cmsDb, IMapper mapper) : base(cmsDb,mapper)
    {
        this.cmsDb = cmsDb;
        this.mapper = mapper;
    }
    public async Task<List<Cms.Core.Models.Post>> GetLatestPosts(int count=5)
    {
        try
        {
            var posts = await cmsDb.Posts
            .OrderByDescending(o => o.CreatedDate)
            .Take(count)
            .ToListAsync();
            return mapper.Map<List<Cms.Core.Models.Post>>(posts);
        }
        catch (Exception)
        {
            throw;
        }

    }
}
