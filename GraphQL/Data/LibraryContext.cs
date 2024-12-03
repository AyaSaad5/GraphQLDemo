using GraphQL.Models;

namespace GraphQL.Data
{
    public class LibraryContext
    {
        //In-Memory Data store
        public List<Book> Books { get; set; } = new();
        public List<Author> Authors { get; set; } = new();
        public List<Publisher> Publishers { get; set; } = new();
        public LibraryContext()
        {
            //Seeding data
            var author1 = new Author { Id = 1, Name = "Author Aya"};
            var author2 = new Author { Id = 2, Name = "Author Taha" };

            var publisher = new Publisher { Id = 2, Name = "Publisher Mohamed" };

            Books.AddRange(new[]
            {
                new Book { Id = 1, Title = "Harry Pottter", Author = author1, AuthorId = author1.Id, Publisher = publisher, PublisherId = publisher.Id},
                new Book { Id = 2, Title = "Mugglles", Author = author2, AuthorId = author2.Id, Publisher = publisher, PublisherId = publisher.Id}
            });

            Authors.AddRange(new[] {author1, author2 });

            Publishers.AddRange(new[] { publisher });

        }
    }
}
