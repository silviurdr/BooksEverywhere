﻿using BooksEverywhere.Domain.Entities;
using BooksEverywhere.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.CreateLibraryUser
{
    public class CreateLibraryUserCommand: IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        public UserType UserType { get; set; }
        public Account Account { get; set; }
    }
}
