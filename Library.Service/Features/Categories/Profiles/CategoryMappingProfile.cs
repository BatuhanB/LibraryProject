using AutoMapper;
using Core.Paging;
using Library.Model.Entities;
using Library.Service.Features.Books.Models;
using Library.Service.Features.Categories.Dtos;
using Library.Service.Features.Categories.Models;

namespace Library.Service.Features.Categories.Profiles
{
    public class CategoryMappingProfile:Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,CreatedCategoryDto>().ReverseMap();

            CreateMap<Category,UpdatedCategoryDto>().ReverseMap();

            CreateMap<Category,DeletedCategoryDto>().ReverseMap();

            CreateMap<Category,CategoryGetByIdDto>().ReverseMap();
            CreateMap<Category,CategoryListModel>().ReverseMap();

            CreateMap<Category,CategoriesWithBooksListModel>().ReverseMap();
            CreateMap<Category,CategoriesWithBooks>().ForMember(x=>x.Books,
                                                      opt=>opt.MapFrom(x=>x.Books))
                                                      .ReverseMap();

            CreateMap<IPaginate<Category>,BookListModel>().ReverseMap();
        }
    }
}
