using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
namespace CarBook.Application.Features.Mediator.Queries.FeatureQueries
{
	public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {
		
	}
}

