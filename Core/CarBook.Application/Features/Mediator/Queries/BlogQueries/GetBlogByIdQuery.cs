using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.BlogResults;
namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
	public class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
	{
		public int Id { get; set; }

        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }
    }
}

