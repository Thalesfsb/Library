using Library.Core.Entities;
using Library.Core.Repositories;
using Library.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repositories
{
    public class RepositoryBook : IRepositoryBase<Book>
    {
        private readonly LibraryDBContext _dbContext;
        public RepositoryBook(LibraryDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<int> DeleteAsync(int id, Book entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Book>> GetAllAsync()
        {
            var books = await _dbContext.Books.ToListAsync();
            return books;
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> PostAsync(Book entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(int id, Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
