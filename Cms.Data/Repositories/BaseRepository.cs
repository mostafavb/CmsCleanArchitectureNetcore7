using AutoMapper;
using Cms.Core.Interfaces.Repository;
using Cms.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Repositories;
public class BaseRepository<TEntity, TModel> : IBaseRepository<TModel> where TModel :class where TEntity : class
{
    private readonly CmsDbContext cmsDb;
    private readonly IMapper mapper;

    public BaseRepository(CmsDbContext cmsDb,IMapper mapper)
    {
        this.cmsDb = cmsDb;
        this.mapper = mapper;
    }
    public async Task<TModel> Add<TDto>(TDto addDto)
    {
        var entity = mapper.Map<TEntity>(addDto);
        await cmsDb.AddAsync(entity);
        await cmsDb.SaveChangesAsync();
        return mapper.Map<TModel>(entity); ;
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

    public async Task Edit(TModel entityDto)
    {
        var entity = mapper.Map<TEntity>(entityDto);
        cmsDb.Update(entity);
        await cmsDb.SaveChangesAsync();
    }

    public async Task<TModel> Get(int id)
    {
        var entity = await cmsDb.Set<TEntity>().FindAsync(id);
        return mapper.Map<TModel>(entity);
    }

    public async Task<List<TModel>> GetAll()
    {
        var entities = await cmsDb.Set<TEntity>().ToListAsync();
        return mapper.Map<List<TModel>>(entities);
    }
   
}
