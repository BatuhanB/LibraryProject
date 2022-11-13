using Core.Repositories;
using Library.Core.Services.Repositories;
using Library.Data.Contexts;
using Library.Model.Entities;

namespace Library.Data.Repositories.Concretes
{
    public class AdressRepository : EfRepositoryBase<Adress, AppDbContext>,IAdressRepository
    {
        public AdressRepository(AppDbContext context) : base(context)
        {
        }
    }
}
