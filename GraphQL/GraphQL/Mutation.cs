using GraphQL.Data;
using GraphQL.Models;

namespace GraphQL.GraphQL
{
    public class Mutation
    {
        public Book AddBook(string title, int authorId, int publisherId, [Service] LibraryContext context)
        {
            var book = new Book 
            {
                Id = context.Books.Count() + 1,
                Title = title,
                AuthorId = authorId,
                PublisherId = publisherId,
            };
            context.Books.Add(book);
            return book;
        }

        public Author AddAuthor(string name, [Service] LibraryContext context)
        {
            var author = new Author { Id = context.Authors.Count() + 1, Name = name };
            context.Authors.Add(author);
            return author;
        }

        public Publisher AddPublisher(string name, [Service] LibraryContext context)
        {
            var publisher = new Publisher { Id = context.Publishers.Count() + 1, Name = name };
            context.Publishers.Add(publisher);
            return publisher;
        }
    }
}
