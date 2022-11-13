using Core.Repositories;
using Library.Core.Services.Repositories;
using Library.Data.Contexts;
using Library.Model.Entities;

namespace Library.Data.Repositories.Concretes
{
    public class CategoryRepository : EfRepositoryBase<Category, AppDbContext>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
