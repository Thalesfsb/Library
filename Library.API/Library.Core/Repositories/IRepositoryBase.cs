using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<int> PostAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IList<T>> GetAllAsync();
        Task<int> DeleteAsync(int id, T entity);
        Task<int> UpdateAsync(int id, T entity);
    }
}
