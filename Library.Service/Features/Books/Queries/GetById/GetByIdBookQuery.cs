using Library.Service.Features.Books.Dtos;
using MediatR;

namespace Library.Service.Features.Books.Queries.GetById
{
    public class GetByIdBookQuery :IRequest<BookGetByIdDto>
    {
        public Guid Id { get; set; }
    }
}
