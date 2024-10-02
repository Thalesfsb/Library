namespace Library.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string titulo, string autor, string iSBN, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            AnoPublicacao = anoPublicacao;
        }

        public required string Titulo { get; set; }
        public required string Autor { get; set; }
        public required string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
