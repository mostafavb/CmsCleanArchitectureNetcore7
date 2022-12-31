
using Cms.Core.Models;

namespace Cms.Core.Interfaces.Repository;
public interface IPostRepository : IBaseRepository<Post> //<TEntity, TModel> : IBaseRepository<TEntity, TModel> where TEntity : class where TModel : class
{
    Task<List<Post>> GetLatestPosts(int count);   
}
