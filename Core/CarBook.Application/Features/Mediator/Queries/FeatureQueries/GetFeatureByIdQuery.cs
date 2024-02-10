using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
namespace CarBook.Application.Features.Mediator.Queries.FeatureQueries
{
	public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
	{
		public int Id { get; set; }

		public GetFeatureByIdQuery(int id)
		{
			Id = id;
		}
	}
}

