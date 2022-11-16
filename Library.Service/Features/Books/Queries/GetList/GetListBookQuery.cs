using Library.Core.CrossCuttingConcerns.Requests;
using Library.Service.Features.Books.Models;
using MediatR;

namespace Library.Service.Features.Books.Queries.GetList
{
    public class GetListBookQuery:IRequest<BookListModel>
    {
        public PageRequest? PageRequest{ get; set; }
    }
}
