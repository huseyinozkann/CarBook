using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.TagCloudResults;
namespace CarBook.Application.Features.Mediator.Queries.TagCloudQueries
{
	public class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
	{
		public int Id { get; set; }

        public GetTagCloudByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}

