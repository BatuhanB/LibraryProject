using Core.Repositories;
using Library.Core.Services.Repositories;
using Library.Data.Contexts;
using Library.Model.Entities;

namespace Library.Data.Repositories.Concretes
{
    public class BookPublisherRepository : EfRepositoryBase<BookPublisher, AppDbContext>,IBookPublisherRepository
    {
        public BookPublisherRepository(AppDbContext context) : base(context)
        {
        }
    }
}
