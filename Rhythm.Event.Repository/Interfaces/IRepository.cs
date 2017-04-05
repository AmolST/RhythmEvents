﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhythm.Event.Repository.Interfaces
{
    public interface IRepository
    {
        IEnumerable<T> GetEntities<T>();
        T GetEnitity<T, TU>(TU id);
    }
}