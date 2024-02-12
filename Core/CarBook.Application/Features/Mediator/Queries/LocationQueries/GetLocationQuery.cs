using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.LocationResults;
namespace CarBook.Application.Features.Mediator.Queries.LocationQueries
{
	public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
	{
		
	}
}

