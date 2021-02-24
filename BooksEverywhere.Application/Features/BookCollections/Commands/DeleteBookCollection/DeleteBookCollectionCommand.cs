using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Commands.DeleteBookCollection
{
    public class DeleteBookCollectionCommand: IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Room RoomLocation { get; set; }
    }
}
