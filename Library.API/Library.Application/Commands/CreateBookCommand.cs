using Library.Application.ViewModel;
using MediatR;
using Library.Core.Repositories;
using Library.Core.Entities;
namespace Library.Application.Commands
{
    public class CreateBookCommand : IRequest<ResultViewModel<int>>
    {
        public CreateBookCommand(string title, string author, string genere, string isbn, int publicationYear)
        {
            Title = title;
            Author = author;
            Genere = genere;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genere { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }

        public Book ToEntity()
            => new(Title, Author, Genere, ISBN, PublicationYear);
    }

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
