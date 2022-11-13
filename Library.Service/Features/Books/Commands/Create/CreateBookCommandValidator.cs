using FluentValidation;
using Library.Model.Entities;

namespace Library.Service.Features.Books.Commands.Create
{
    public class CreateBookCommandValidator: AbstractValidator<Book>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.Name).MinimumLength(2);
            RuleFor(x=>x.Name).MaximumLength(60);
            RuleFor(x=>x.Title).NotEmpty();
            RuleFor(x=>x.Title).MinimumLength(2);
            RuleFor(x=>x.Title).MaximumLength(25);
            RuleFor(x=>x.Description).NotEmpty();
            RuleFor(x=>x.Description).MinimumLength(10);
            RuleFor(x=>x.Description).MaximumLength(255);
            RuleFor(x=>x.PublishDate).NotEmpty();
            RuleFor(x=>x.AuthorId).NotEmpty();
            RuleFor(x=>x.CategoryId).NotEmpty();
        }
    }
}
