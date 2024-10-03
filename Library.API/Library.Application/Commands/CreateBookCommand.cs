using Library.Application.ViewModel;
using MediatR;
using Library.Core.Entities;
namespace Library.Application.Commands
{
    public class CreateBookCommand : IRequest<ResultViewModel<int>>
    {
        public CreateBookCommand(string title, string author, string genre, string isbn, int publicationYear)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public Book ToEntity()
            => new(Title, Author, Genre, ISBN, PublicationYear);
    }
}
