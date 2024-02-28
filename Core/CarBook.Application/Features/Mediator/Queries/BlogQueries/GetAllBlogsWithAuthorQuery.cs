using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.BlogResults;
namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
	public class GetAllBlogsWithAuthorQuery : IRequest<List<GetAllBlogsWithAuthorQueryResult>>
	{
		
	}
}

