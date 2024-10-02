using Library.Core.Entities;
using Library.Core.Repositories;
using Library.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Library.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDBContext _context;
        public BookRepository(LibraryDBContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Book entity)
        {
            await _context.Books.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Books.FindAsync(id);

            if (entity != null)
            {
                entity.SetAsDeleted();
                _context.Books.Update(entity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<Book>> FindAsync(Expression<Func<Book, bool>> predicate)
        {
            return await _context.Books.Where(predicate).ToListAsync();
        }
        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }
        public async Task<Book?> GetByIdAsync(int id)
        {
            return await _context.Books.FindAsync(id);
        }
        public async Task UpdateAsync(Book entity)
        {
            var book = await _context.Books.FindAsync(entity.Id);

            if (book != null)
            {
                _context.Books.Update(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
