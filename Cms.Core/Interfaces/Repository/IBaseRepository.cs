using Cms.Core.Models;

namespace Cms.Core.Interfaces.Repository;
public interface IBaseRepository<TModel> 
{
    Task<TModel> Get(int id);
    Task<List<TModel>> GetAll();
    Task<TModel> Add<TDto>(TDto modelDto);
    Task Edit(TModel modelDto);
    Task Delete(int id);
}
