using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.TagCloudResults;
namespace CarBook.Application.Features.Mediator.Queries.TagCloudQueries
{
	public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
	{
		
	}
}

