using Core.Repositories;
using Library.Model.Entities;

namespace Library.Core.Services.Repositories
{
    public interface IPublisherRepository:IAsyncRepository<Publisher>,IRepository<Publisher>
    {
    }
}
