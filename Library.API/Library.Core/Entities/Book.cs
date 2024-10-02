namespace Library.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book()
        {
            
        }
        public Book(string titulo, string autor, string genre, string isbn, int publicationYear)
        {
            Title = titulo;
            Author = autor;
            Genre = genre;
            ISBN = isbn;
            PublicationYear = publicationYear;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
    }
}
