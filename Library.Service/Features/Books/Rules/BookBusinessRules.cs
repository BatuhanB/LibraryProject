using Library.Core.CrossCuttingConcerns.Exceptions;
using Library.Core.Services.Repositories;
using Library.Service.Features.Books.Constants;

namespace Library.Service.Features.Books.Rules
{
    public class BookBusinessRules
    {
        private readonly IBookRepository _repository;

        public BookBusinessRules(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task BookCanNotBeDuplicatedWhenInserted(string name, Guid authorId)
        {
            var result = await _repository.GetListAsync(x => x.Name == name && x.AuthorId == authorId);
            if (result.Items.Any()) throw new BusinessException(BookMessages.BOOK_ALREADY_EXISTS);
        }

        public async Task BookShouldBeExistWhenRequested(Guid id)
        {
            var result = await _repository.GetListAsync(x => x.Id == id);
            if (result is null) throw new BusinessException(BookMessages.BOOK_ALREADY_EXISTS);
        }
    }
}
