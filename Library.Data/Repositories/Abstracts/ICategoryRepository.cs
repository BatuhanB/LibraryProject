using Core.Repositories;
using Library.Model.Entities;

namespace Library.Core.Services.Repositories
{
    public interface ICategoryRepository:IAsyncRepository<Category>,IRepository<Category>
    {
    }
}
