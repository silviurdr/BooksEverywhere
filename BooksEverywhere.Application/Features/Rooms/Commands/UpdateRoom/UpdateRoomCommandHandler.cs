using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Room> _roomRepository;

        public UpdateRoomCommandHandler(IMapper mapper, IAsyncRepository<Room> roomRepository)
        {
            _mapper = mapper;
            _roomRepository = roomRepository;
        }
        public async Task<Unit> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var roomToUpdate = await _roomRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, roomToUpdate, typeof(UpdateRoomCommand), typeof(Room));

            await _roomRepository.UpdateAsync(roomToUpdate);

            return Unit.Value;
        }
    }
}
