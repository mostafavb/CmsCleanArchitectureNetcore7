using AutoMapper;
using Cms.Core.Domains;
using Cms.Core.Interfaces.Repository;
using Cms.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Repositories;
public class PostRepository : BaseRepository<Post>, IPostRepository
{
    private readonly CmsDbContext cmsDb;
    private readonly IMapper mapper;

    public PostRepository(CmsDbContext cmsDb, IMapper mapper) : base(cmsDb)
    {
        this.cmsDb = cmsDb;
        this.mapper = mapper;
    }
    public async Task<List<Post>> GetLatestPosts(int count=5)
    {
        try
        {
            var posts = await cmsDb.Posts
            //.OrderByDescending(o => o.CreatedDate)
            //.Take(count)
            .ToListAsync();
            return mapper.Map<List<Post>>(posts);
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
}
