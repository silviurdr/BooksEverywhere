using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Commands.UpdateBookCollection
{
    public class UpdateBookCollectionCommand: IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Room RoomLocation { get; set; }
    }
}
