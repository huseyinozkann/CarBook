﻿using System;
using MediatR;
using CarBook.Application.Features.Mediator.Commands.AuthorCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
	{
		private readonly IRepository<Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            });
        }
    }
}

