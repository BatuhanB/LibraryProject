using AutoMapper;
using Core.Paging;
using Library.Model.Entities;
using Library.Service.Features.Books.Commands.Create;
using Library.Service.Features.Books.Commands.Delete;
using Library.Service.Features.Books.Commands.Update;
using Library.Service.Features.Books.Dtos;
using Library.Service.Features.Books.Models;

namespace Library.Service.Features.Books.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book,CreatedBookDto>().ReverseMap();
            CreateMap<Book,CreateBookCommand>().ReverseMap();

            CreateMap<Book,UpdatedBookDto>().ReverseMap();
            CreateMap<Book,UpdateBookCommand>().ReverseMap();

            CreateMap<Book,BookGetByIdDto>().ReverseMap();
            CreateMap<Book,BookListDto>().ForMember(x=>x.AuthorId,opt=>opt.MapFrom(x=>x.Author!.Id))
                                         .ForMember(x=>x.CategoryId,opt=>opt.MapFrom(x=>x.Category.Id))
                                         .ReverseMap();

            CreateMap<Book,DeletedBookDto>().ReverseMap();
            CreateMap<Book,DeleteBookCommand>().ReverseMap();

            CreateMap<IPaginate<Book>,BookListModel>().ReverseMap();
        }
    }
}
