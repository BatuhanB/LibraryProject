using Library.Service.Features.Books.Dtos;

namespace Library.Service.Features.Categories.Dtos
{
    public class CategoriesWithBooks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<BookDto>? Books { get; set; }
    }
}
