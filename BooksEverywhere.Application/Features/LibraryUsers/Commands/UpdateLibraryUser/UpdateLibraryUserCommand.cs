using BooksEverywhere.Domain.Entities;
using BooksEverywhere.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.UpdateLibraryUser
{
    public class UpdateLibraryUserCommand: IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
