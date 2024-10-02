using Library.Core.Entities;
using System.Linq.Expressions;
namespace Library.Core.Repositories
{
    public interface IBookRepository
    {
        Task AddAsync(Book entity);
        Task UpdateAsync(Book entity);
        Task DeleteAsync(int id);
        Task<Book?> GetByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllAsync();
        Task<IEnumerable<Book>> FindAsync(Expression<Func<Book, bool>> predicate);
    }
}
