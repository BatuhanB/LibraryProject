using Core.Paging;
using Library.Service.Features.Categories.Dtos;

namespace Library.Service.Features.Categories.Models
{
    public class CategoryListModel:BasePageableModel
    {
        public IList<CategoryGetListDto>? Items { get; set; }
    }
}
