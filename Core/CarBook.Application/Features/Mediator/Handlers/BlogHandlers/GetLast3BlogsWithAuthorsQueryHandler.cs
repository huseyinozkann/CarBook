using System;
using MediatR;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {

        public Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}

