using SimpleIt_Run.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIt_Run.Abstractions.services
{
    public interface IDataProvider<T> where T : EntityBase
    {
        void Add(T entity);
        void Delete(T entity);
        T GetById(long id);
        void Update(T customer);
    }
}
