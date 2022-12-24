using Cms.Core.Domains;

namespace Cms.Core.Interfaces.Repository;
public interface IPostRepository : IBaseRepository<Post>
{
    Task<List<Post>> GetLatestPosts(int count);
}
