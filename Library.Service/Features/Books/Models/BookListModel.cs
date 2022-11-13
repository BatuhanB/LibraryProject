using Core.Paging;
using Library.Service.Features.Books.Dtos;

namespace Library.Service.Features.Books.Models
{
    public class BookListModel : BasePageableModel
    {
        public IList<BookListDto>? Items { get; set; }
    }
}
