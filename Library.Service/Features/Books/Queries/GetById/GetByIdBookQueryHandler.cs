using AutoMapper;
using Library.Core.Services.Repositories;
using Library.Service.Features.Books.Dtos;
using Library.Service.Features.Books.Rules;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Library.Service.Features.Books.Queries.GetById
{
    public class GetByIdBookQueryHandler : IRequestHandler<GetByIdBookQuery, BookGetByIdDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly BookBusinessRules _rules;

        public GetByIdBookQueryHandler(IBookRepository bookRepository, IMapper mapper, BookBusinessRules rules)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _rules = rules;
        }

        public async Task<BookGetByIdDto> Handle(GetByIdBookQuery request, CancellationToken cancellationToken)
        {
            await _rules.BookShouldBeExistWhenRequested(request.Id);
            var book = await _bookRepository.GetAsync(x=>x.Id == request.Id ,include:x=>
                                                      x.Include(x=>x.Category)
                                                      .Include(x=>x.Author)
                                                      .Include(x=>x.BookPublishers));
            var mappedBook = _mapper.Map<BookGetByIdDto>(book); 
            return mappedBook;
        }
    }
}
