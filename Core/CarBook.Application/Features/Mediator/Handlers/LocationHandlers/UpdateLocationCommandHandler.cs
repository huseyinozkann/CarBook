using System;
using MediatR;
using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
	public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
	{
		private readonly IRepository<Location> _repository;

        public UpdateLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.LocationID);
            values.name = request.name;
            await _repository.UpdateAsync(values);
        }
    }
}

