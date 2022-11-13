using Library.Service.Features.Books.Dtos;
using MediatR;

namespace Library.Service.Features.Books.Commands.Delete
{
    public class DeleteBookCommand:IRequest<DeletedBookDto>
    {
        public Guid Id { get; set; }
    }
}
