using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Rooms.Queries.GetRoomsList
{
    public class GetRoomsListQueryHandler : IRequestHandler<GetRoomsListQuery, List<RoomsListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Room> _roomsRepository;

        public GetRoomsListQueryHandler(IMapper mapper, IAsyncRepository<Room> roomsRepository)
        {
            _mapper = mapper;
            _roomsRepository = roomsRepository;
        }
        public async Task<List<RoomsListVm>> Handle(GetRoomsListQuery request, CancellationToken cancellationToken)
        {
            var allRooms = await _roomsRepository.ListAllAsync();

            return _mapper.Map<List<RoomsListVm>>(allRooms);

        }
    }
}
