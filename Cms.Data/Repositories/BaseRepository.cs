using Cms.Core.Interfaces.Repository;
using Cms.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Repositories;
public class BaseRepository<T> : IBaseRepository<T> where T:class
{
    private readonly CmsDbContext cmsDb;

    public BaseRepository(CmsDbContext cmsDb)
    {
        this.cmsDb = cmsDb;
    }
    public async Task<T> Add(T entity)
    {
        await cmsDb.AddAsync(entity);
        await cmsDb.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(int id)
    {
        var entity = await Get(id);
        if (entity != null)
        {
            cmsDb.Remove(entity);
            await cmsDb.SaveChangesAsync();
        }
    }

    public async Task Edit(T entity)
    {
        cmsDb.Update(entity);
        await cmsDb.SaveChangesAsync();
    }

    public async Task<T> Get(int id) =>
        await cmsDb.Set<T>().FindAsync(id);

    public async Task<List<T>> GetAll() =>
        await cmsDb.Set<T>().ToListAsync();
   
}
