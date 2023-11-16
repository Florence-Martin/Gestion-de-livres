using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessModel.Author;
using BusinessModel.Books;
using DataEntity;

namespace BusinessMapper
{
    public class BusinessMapper : Profile
    {
        public BusinessMapper()
        {
            CreateMap<CreateBookDto, Book>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => new Author { Name = src.AuthorName }))
                .ReverseMap();


            CreateMap<Book, ReadBookDto>()
                .IncludeBase<Book, CreateBookDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
                .ReverseMap();

            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.BookTitles, opt => opt.MapFrom(src => src.Books.Select(b => b.Title).ToList())); 
        }

    }
}
