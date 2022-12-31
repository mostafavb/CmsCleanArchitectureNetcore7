using Cms.Data.Data;
using AutoMapper;
using Cms.Core.Interfaces.Repository;

namespace Cms.Data.Repositories;
public class CategoryRepository : BaseRepository<Cms.Data.Entities.Category,Cms.Core.Models.Category>, ICategoryRepository
{
    public CategoryRepository(CmsDbContext cmsDb,IMapper mapper) : base(cmsDb,mapper)
    {
    }
}
