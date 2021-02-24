using AutoMapper;
using BooksEverywhere.Application.Features.Events;
using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookListVm>().ReverseMap();
            CreateMap<Book, BookInfoVm>().ReverseMap();
            CreateMap<Book, CreateBookCommand>().ReverseMap();

        }
    }
}
