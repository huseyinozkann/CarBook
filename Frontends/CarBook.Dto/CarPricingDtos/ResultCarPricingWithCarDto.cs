﻿using System;
namespace CarBook.Dto.CarPricingDtos
{
	public class ResultCarPricingWithCarDto
	{
        public int CarId { get; set; }

        public int CarPricingID { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Amount { get; set; }

        public string CoverImageUrl { get; set; }
    }
}

