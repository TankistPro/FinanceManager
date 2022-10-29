using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Infrastructure.Interfaces
{
    internal interface IBaseRepository<T>
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRageAsync(List<T> entities);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        T GetById(int id);
    }
}
