using AutoMapper;
using Library.Core.Services.Repositories;
using Library.Model.Entities;
using Library.Service.Features.Books.Dtos;
using Library.Service.Features.Books.Rules;
using MediatR;

namespace Library.Service.Features.Books.Commands.Create
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, CreatedBookDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly BookBusinessRules _businessRules;

        public CreateBookCommandHandler(IBookRepository bookRepository, IMapper mapper, BookBusinessRules businessRules)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<CreatedBookDto> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _businessRules.BookCanNotBeDuplicatedWhenInserted(request.Name,request.AuthorId);
            var mappedBook = _mapper.Map<Book>(request);
            var createBook = await _bookRepository.AddAsync(mappedBook);
            var createdBookDto = _mapper.Map<CreatedBookDto>(createBook);
            return createdBookDto;
        }
    }
}
