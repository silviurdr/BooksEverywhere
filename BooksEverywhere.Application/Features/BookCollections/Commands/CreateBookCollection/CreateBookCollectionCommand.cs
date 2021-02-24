using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Commands.CreateBookCollection
{
    public class CreateBookCollectionCommand: IRequest<int>
    {
        public string Name { get; set; }
        public Room RoomLocation { get; set; }
    }
}

