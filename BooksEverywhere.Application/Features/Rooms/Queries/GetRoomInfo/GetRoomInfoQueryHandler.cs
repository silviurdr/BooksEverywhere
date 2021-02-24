using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Rooms.Queries.GetRoomInfo
{
    public class GetRoomInfoQueryHandler : IRequestHandler<GetRoomInfoQuery, RoomInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Room> _roomsRepository;

        public GetRoomInfoQueryHandler(IMapper mapper, IAsyncRepository<Room> roomsRepository)
        {
            _mapper = mapper;
            _roomsRepository = roomsRepository;
        }
        public async Task<RoomInfoVm> Handle(GetRoomInfoQuery request, CancellationToken cancellationToken)
        {
            var @room = await _roomsRepository.GetByIdAsync(request.Id);
            var roomInfoDto = _mapper.Map<RoomInfoVm>(@room);

            return roomInfoDto;
        }
    }
}
