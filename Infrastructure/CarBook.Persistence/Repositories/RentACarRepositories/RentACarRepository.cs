﻿using System;
using System.Linq.Expressions;
using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using CarBook.Application.Features.Mediator.Queries.RentACarQueries;

namespace CarBook.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(y => y.Brand).ToListAsync();
            return values;
        }
    }
}

