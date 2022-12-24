namespace Cms.Core.Interfaces.Repository;
public interface IBaseRepository<T> where T : class
{
    Task<T> Get(int id);
    Task<List<T>> GetAll();
    Task<T> Add(T entity);
    Task Edit(T entity);
    Task Delete(int id);
}
