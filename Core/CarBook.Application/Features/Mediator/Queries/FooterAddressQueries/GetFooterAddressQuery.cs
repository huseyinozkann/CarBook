using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
	public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
	{
		
	}
}

