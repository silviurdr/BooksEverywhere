using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Rooms.Commands.DeleteRoom
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand>
    {
        private readonly IAsyncRepository<Room> _roomRepository;

        public DeleteRoomCommandHandler(IAsyncRepository<Room> roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task<Unit> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            var roomToDelete = await _roomRepository.GetByIdAsync(request.Id);
            await _roomRepository.DeleteAsync(roomToDelete);

            return Unit.Value;
        }
    }
}
