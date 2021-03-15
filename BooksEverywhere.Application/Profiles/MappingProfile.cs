using AutoMapper;
using BooksEverywhere.Application.Features.BookCollections.Commands.CreateBookCollection;
using BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionList;
using BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionsList;
using BooksEverywhere.Application.Features.BookLends.Commands.CreateBookLend;
using BooksEverywhere.Application.Features.BookLends.Commands.UpdateBookLend;
using BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendInfo;
using BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendsList;
using BooksEverywhere.Application.Features.Books.Commands;
using BooksEverywhere.Application.Features.Books.Commands.UpdateBook;
using BooksEverywhere.Application.Features.Events;
using BooksEverywhere.Application.Features.Libraries.Commands.CreateLibrary;
using BooksEverywhere.Application.Features.Libraries.Commands.UpdateLibrary;
using BooksEverywhere.Application.Features.Libraries.Queries.GetLibraryInfo;
using BooksEverywhere.Application.Features.LibraryUsers.Commands.CreateLibraryUser;
using BooksEverywhere.Application.Features.LibraryUsers.Commands.UpdateLibraryUser;
using BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUserInfo;
using BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUsersList;
using BooksEverywhere.Application.Features.Rooms.Commands.CreateRoom;
using BooksEverywhere.Application.Features.Rooms.Queries.GetRoomInfo;
using BooksEverywhere.Application.Features.Rooms.Queries.GetRoomsList;
using BooksEverywhere.Application.Features.Stacks.Commands.CreateStack;
using BooksEverywhere.Application.Features.Stacks.Queries.GetStackInfo;
using BooksEverywhere.Application.Features.Stacks.Queries.GetStacksList;
using BooksEverywhere.Application.Features.Subjects.Commands.CreateSubject;
using BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectInfo;
using BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectsList;
using BooksEverywhere.Application.Features.Subsidiaries.Commands.CreateSubsidiary;
using BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiariesList;
using BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiaryInfo;
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
            CreateMap<Book, UpdateBookCommand>().ReverseMap();

            CreateMap<BookCollection, BookCollectionListVm>().ReverseMap();
            CreateMap<Book, BookCollectionInfoVm>().ReverseMap();
            CreateMap<BookCollection, CreateBookCollectionCommand>().ReverseMap();

            CreateMap<BookLend, BookLendListVm>().ReverseMap();
            CreateMap<BookLend, BookLendInfoVm>().ReverseMap();
            CreateMap<BookLend, CreateBookLendCommand>().ReverseMap();
            CreateMap<BookLend, UpdateBookLendCommand>().ReverseMap();

            CreateMap<Library, LibraryInfoVm>().ReverseMap();
            CreateMap<Library, CreateLibraryCommand>().ReverseMap();
            CreateMap<Library, UpdateLibraryCommand>().ReverseMap();

            CreateMap<LibraryUser, LibraryUsersListVm>().ReverseMap();
            CreateMap<LibraryUser, LibraryUserInfoVm>().ReverseMap();
            CreateMap<LibraryUser, CreateLibraryUserCommand>().ReverseMap();
            CreateMap<LibraryUser, UpdateLibraryUserCommand>().ReverseMap();

            CreateMap<Room, RoomsListVm>().ReverseMap();
            CreateMap<Room, RoomInfoVm>().ReverseMap();
            CreateMap<Room, CreateRoomCommand>().ReverseMap();

            CreateMap<Stack, StacksListVm>().ReverseMap();
            CreateMap<Stack, StackInfoVm>().ReverseMap();
            CreateMap<Stack, CreateStackCommand>().ReverseMap();

            CreateMap<Subject, SubjectsListVm>().ReverseMap();
            CreateMap<Subject, SubjectInfoVm>().ReverseMap();
            CreateMap<Subject, CreateSubjectCommand>().ReverseMap();

            CreateMap<Subsidiary, SubsidiariesListVm>().ReverseMap();
            CreateMap<Subsidiary, SubsidiaryInfoVm>().ReverseMap();
            CreateMap<Subsidiary, CreateSubsidiaryCommand>().ReverseMap();
        }
    }
}
