using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.PricingResults;
namespace CarBook.Application.Features.Mediator.Queries.PricingQueries
{
	public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
	{
	
	}
}

