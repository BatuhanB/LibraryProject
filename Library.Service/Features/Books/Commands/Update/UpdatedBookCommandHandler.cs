using AutoMapper;
using Library.Core.Services.Repositories;
using Library.Service.Features.Books.Dtos;
using Library.Service.Features.Books.Rules;
using MediatR;

namespace Library.Service.Features.Books.Commands.Update
{
    public class UpdatedBookCommandHandler : IRequestHandler<UpdateBookCommand, UpdatedBookDto>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        private readonly BookBusinessRules _rules;

        public UpdatedBookCommandHandler(IBookRepository bookRepository, IMapper mapper, BookBusinessRules rules)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _rules = rules;
        }

        public async Task<UpdatedBookDto> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            await _rules.BookShouldBeExistWhenRequested(request.Id);
            var book = await _bookRepository.GetAsync(x => x.Id == request.Id);
            var mappedBook = _mapper.Map(request, book);
            var updatedBook = await _bookRepository.UpdateAsync(mappedBook!);
            var mappedUpdatedBook = _mapper.Map<UpdatedBookDto>(updatedBook);
            return mappedUpdatedBook;
        }
    }
}
