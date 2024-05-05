﻿using System;
using CarBook.Domain.Entities;
using System.Linq.Expressions;
namespace CarBook.Application.Interfaces.RentACarInterfaces
{
	public interface IRentACarRepository
	{
		List<RentACar> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);
	}
}

