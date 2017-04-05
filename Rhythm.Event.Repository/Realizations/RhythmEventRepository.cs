using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhythm.Event.Repository.Interfaces;

namespace Rhythm.Event.Repository.Realizations
{
    public class RhythmEventRepository : IRhythmEventRepository
    {
        public IEnumerable<T> GetEntities<T>()
        {
            throw new NotImplementedException();
        }

        public T GetEnitity<T, TU>(TU id)
        {
            throw new NotImplementedException();
        }
    }
}
