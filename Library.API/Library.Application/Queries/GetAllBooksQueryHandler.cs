using Library.Application.ViewModel;
using Library.Core.Entities;
using Library.Core.Repositories;
using MediatR;

namespace Library.Application.Queries
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, ResultViewModel<List<Book>>>
    {
        private readonly IBookRepository _repository;
        public GetAllBooksQueryHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<List<Book>>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _repository.GetAllAsync();

            if (books is null)
                return ResultViewModel<List<Book>>.Error("Não foi encontrado nenhum livro");

            return ResultViewModel<List<Book>>.Success(books.ToList());
        }
    }
}
