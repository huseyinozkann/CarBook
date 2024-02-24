using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.BlogResults;
namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
	public class GetLast3BlogsWithAuthorsQuery : IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
	{
		
	}
}

