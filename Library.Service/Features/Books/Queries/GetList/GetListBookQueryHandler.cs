using AutoMapper;
using Library.Core.Services.Repositories;
using Library.Service.Features.Books.Models;
using Library.Service.Features.Books.Rules;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Library.Service.Features.Books.Queries.GetList
{
    public class GetListBookQueryHandler : IRequestHandler<GetListBookQuery, BookListModel>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly BookBusinessRules _rules;

        public GetListBookQueryHandler(IBookRepository bookRepository, IMapper mapper, BookBusinessRules rules)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _rules = rules;
        }

        public async Task<BookListModel> Handle(GetListBookQuery request, CancellationToken cancellationToken)
        {
            var listedBook = await _bookRepository.GetListAsync(index: request.PageRequest!.Page,
                                                                size: request.PageRequest.PageSize,
                                                                include: x => x.Include(x => x.Category)
                                                                .Include(x => x.Author)
                                                                .Include(x => x.BookPublishers));
            var mappedBookListModel = _mapper.Map<BookListModel>(listedBook);
            return mappedBookListModel;
        }
    }
}
