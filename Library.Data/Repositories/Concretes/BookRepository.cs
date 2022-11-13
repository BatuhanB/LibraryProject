using Core.Repositories;
using Library.Core.Services.Repositories;
using Library.Data.Contexts;
using Library.Model.Entities;

namespace Library.Data.Repositories.Concretes
{
    public class BookRepository : EfRepositoryBase<Book, AppDbContext>,IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }
    }
}
