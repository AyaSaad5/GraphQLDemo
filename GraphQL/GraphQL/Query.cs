using GraphQL.Data;
using GraphQL.Models;

namespace GraphQL.GraphQL
{
    public class Query
    {
        //implementing resolvers to fetch data => resolve requested data
        public IQueryable<Book> GetBooks([Service] LibraryContext context) => context.Books.AsQueryable();

        public IQueryable<Author> GetAuthors([Service] LibraryContext context) => context.Authors.AsQueryable();

        public IQueryable<Publisher> GetPublishers([Service] LibraryContext context) => context.Publishers.AsQueryable();

    }
}
