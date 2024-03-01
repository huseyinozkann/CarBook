using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.TagCloudResults;
namespace CarBook.Application.Features.Mediator.Queries.TagCloudQueries
{
	public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResult>
	{
		public int Id { get; set; }

        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }
    }
}

