﻿using System;
namespace CarBook.Dto.CarDescriptionDtos
{
	public class ResultCarDescriptionByCarIdDto
	{
        public int CarDescriptionID { get; set; }

        public int CarID { get; set; }

        public string Details { get; set; }
    }
}

