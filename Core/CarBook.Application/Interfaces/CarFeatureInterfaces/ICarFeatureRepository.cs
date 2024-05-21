using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarFeatureInterfaces
{
	public interface ICarFeatureRepository
	{
        List<CarFeature> GetCarFeaturesByCarID(int carID);
    }
}

