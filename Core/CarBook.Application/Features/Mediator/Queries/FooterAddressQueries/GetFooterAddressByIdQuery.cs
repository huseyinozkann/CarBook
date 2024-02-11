using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
	public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
	{
		public int Id { get; set; }

		public GetFooterAddressByIdQuery(int id)
		{
			Id = id;
		}
	}
}

