using Library.Application.ViewModel;
using MediatR;
using Library.Core.Repositories;
namespace Library.Application.Commands
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, ResultViewModel<int>>
    {
        private readonly IBookRepository _repository;
        public CreateBookCommandHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResultViewModel<int>> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = request.ToEntity();

            await _repository.AddAsync(book);

            return ResultViewModel<int>.Success(book.Id);
        }
    }
}
