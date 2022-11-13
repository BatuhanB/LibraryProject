using Core.Repositories;
using Library.Core.Services.Repositories;
using Library.Data.Contexts;
using Library.Model.Entities;

namespace Library.Data.Repositories.Concretes
{
    public class PublisherRepository : EfRepositoryBase<Publisher, AppDbContext>,IPublisherRepository
    {
        public PublisherRepository(AppDbContext context) : base(context)
        {
        }
    }
}
