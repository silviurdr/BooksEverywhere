using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Room> _roomsRepository;

        public CreateRoomCommandHandler(IMapper mapper, IAsyncRepository<Room> roomsRepository)
        {
            _mapper = mapper;
            _roomsRepository = roomsRepository;
        }
        public async Task<int> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateRoomValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @room = _mapper.Map<Room>(request);
            await _roomsRepository.AddAsync(@room);

            return @room.Id;
        }
    }
}
