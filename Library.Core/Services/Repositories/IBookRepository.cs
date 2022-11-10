using Core.Repositories;
using Library.Model.Entities;

namespace Library.Core.Services.Repositories
{
    public interface IBookRepository:IAsyncRepository<Book>,IRepository<Book>
    {
    }
}
