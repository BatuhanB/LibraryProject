using AutoMapper;
using Library.Core.Services.Repositories;
using Library.Service.Features.Books.Dtos;
using Library.Service.Features.Books.Rules;
using MediatR;

namespace Library.Service.Features.Books.Commands.Delete
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, DeletedBookDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly BookBusinessRules _rules;

        public DeleteBookCommandHandler(IBookRepository bookRepository, IMapper mapper, BookBusinessRules rules)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _rules = rules;
        }

        public async Task<DeletedBookDto> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            await _rules.BookShouldBeExistWhenRequested(request.Id);
            var mappedBook = await _bookRepository.GetAsync(x=>x.Id == request.Id);
            var deletedBook = _bookRepository.Delete(mappedBook!);
            var mappedDeletedBook = _mapper.Map<DeletedBookDto>(deletedBook);
            return mappedDeletedBook;
        }
    }
}
