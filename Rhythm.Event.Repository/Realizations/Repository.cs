using Rhythm.Event.Domain;
using System;
using System.Collections.Generic;

namespace Rhythm.Event.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        RhythmEventContext rythmEventContext = new RhythmEventContext();

        public ServiceResult Add(T entity)
        {
            ServiceResult serviceResult = new ServiceResult();
            rythmEventContext.Set<T>().Add(entity);
            rythmEventContext.SaveChanges();
            rythmEventContext.Entry(entity).GetDatabaseValues();
            return serviceResult;
        }

        public ServiceResult Delete(long id)
        {
            throw new NotImplementedException();
        }

        public T GetEnitity(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
