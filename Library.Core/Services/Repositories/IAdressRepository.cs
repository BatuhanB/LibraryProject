using Core.Repositories;
using Library.Model.Entities;

namespace Library.Core.Services.Repositories
{
    public interface IAdressRepository:IAsyncRepository<Adress>,IRepository<Adress>
    {
    }
}
