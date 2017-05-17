using System.Collections.Generic;

namespace Rhythm.Event.Repository
{
    public interface IRepository<T>
    {
        ServiceResult Add(T entity);
        ServiceResult Delete(long id);
        IEnumerable<T> GetEntities();
        T GetEnitity(long id);
    }
}
