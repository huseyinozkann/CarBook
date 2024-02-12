using System;
using MediatR;
using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
	public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
	{
		private readonly IRepository<Location> _repository;

        public CreateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Location
            {
                name = request.name
            });
        }
    }
}

