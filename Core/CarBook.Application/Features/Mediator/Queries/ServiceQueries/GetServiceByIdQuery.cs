﻿using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.ServiceResults;
namespace CarBook.Application.Features.Mediator.Queries.ServiceQueries
{
	public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
	{
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }

    }
}

