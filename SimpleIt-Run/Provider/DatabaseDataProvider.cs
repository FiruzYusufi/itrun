using SimpleIt_Run.Abstractions.services;
using SimpleIt_Run.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIt_Run.Provider
{
    public abstract class DatabaseDataProvider<T> : IDataProvider<T> where T : EntityBase
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(T customer)
        {
            throw new NotImplementedException();
        }
    }
}
