using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.BlogResults;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
	public class GetBlogByAuthorIdQuery : IRequest<List<GetBlogByAuthorIdQueryResult>>
	{
		public int Id { get; set; }

        public GetBlogByAuthorIdQuery(int id)
        {
            Id = id;
        }
    }
}

