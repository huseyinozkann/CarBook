﻿using System;
using MediatR;
namespace CarBook.Application.Features.Mediator.Commands.CarFeatureCommands
{
	public class UpdateCarFeatureAvailableChangeToTrueCommand : IRequest
	{
        public int Id { get; set; }

        public UpdateCarFeatureAvailableChangeToTrueCommand(int id)
        {
            Id = id;
        }
    }
}

