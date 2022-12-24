using Cms.Core.Domains;
using Cms.Core.Interfaces.Repository;
using Cms.Data.Data;

namespace Cms.Data.Repositories;
public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(CmsDbContext cmsDb) : base(cmsDb)
    {
    }
}
