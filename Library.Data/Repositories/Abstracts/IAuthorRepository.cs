using Core.Repositories;
using Library.Model.Entities;

namespace Library.Core.Services.Repositories
{
    public interface IAuthorRepository:IAsyncRepository<Author>,IRepository<Author>
    {
    }
}
