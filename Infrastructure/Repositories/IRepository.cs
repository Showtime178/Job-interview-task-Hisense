using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        void Create(T entity);

        T? GetItemById(string id);

        IEnumerable<T> GetAll();

        bool Update(string id, T updated);

        bool Delete(string id);
    }
}
