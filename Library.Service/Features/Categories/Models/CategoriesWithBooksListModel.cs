using Core.Paging;
using Library.Service.Features.Categories.Dtos;

namespace Library.Service.Features.Categories.Models
{
    public class CategoriesWithBooksListModel : BasePageableModel
    {
        public IList<CategoriesWithBooks>? Items { get; set; }
    }
}
