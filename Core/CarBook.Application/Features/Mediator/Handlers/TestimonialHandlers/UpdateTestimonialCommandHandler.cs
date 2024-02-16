﻿using System;
using MediatR;
using CarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
	public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
	{
		private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TestimonialID);
            values.Name = request.Name;
            values.Comment = request.Comment;
            values.Title = request.Title;
            values.ImageUrl = request.ImageUrl; 
            await _repository.UpdateAsync(values);
        }
    }
}

