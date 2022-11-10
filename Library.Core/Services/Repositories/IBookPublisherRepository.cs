using Core.Repositories;
using Library.Model.Entities;

namespace Library.Core.Services.Repositories
{
    public interface IBookPublisherRepository:IAsyncRepository<BookPublisher>,IRepository<BookPublisher>
    {
    }
}
