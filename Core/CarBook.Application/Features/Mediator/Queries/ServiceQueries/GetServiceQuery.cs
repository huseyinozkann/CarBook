using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.ServiceResults; 
namespace CarBook.Application.Features.Mediator.Queries.ServiceQueries
{
	public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
	{
		
	}
}

