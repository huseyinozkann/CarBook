﻿using System;
namespace CarBook.Dto.ContactDtos
{
	public class ResultContactDto
	{
        public int ContactID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime SendDate { get; set; }
    }
}

