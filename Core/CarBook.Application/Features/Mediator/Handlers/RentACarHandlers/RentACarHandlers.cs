﻿using System;
using MediatR;
using CarBook.Application.Features.Mediator.Results.RentACarResults;
using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using CarBook.Application.Interfaces.RentACarInterfaces;

namespace CarBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class RentACarHandlers : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public RentACarHandlers(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationID && x.Available == true);
            var results = values.Select(y => new GetRentACarQueryResult
            {
                CarId = y.CarID,
                Brand = y.Car.Brand.Name,
                Model = y.Car.Model,
                CoverImageUrl = y.Car.CoverImageUrl
            }).ToList();
            return results;
        }
    }
}

