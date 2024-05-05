using System;
using System.Linq.Expressions;
using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories.RentACarRepositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<RentACar> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
        {
            var values = _context.RentACars.Where(filter) ;
            return values.ToList();
        }
    }
}

