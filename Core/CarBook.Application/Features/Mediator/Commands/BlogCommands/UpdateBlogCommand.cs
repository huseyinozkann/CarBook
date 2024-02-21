﻿using System;
using MediatR;
namespace CarBook.Application.Features.Mediator.Commands.BlogCommands
{
	public class UpdateBlogCommand : IRequest
	{
        public int BlogID { get; set; }

        public string Title { get; set; }

        public int AuthorID { get; set; }

        public string CoverImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CategoryID { get; set; }
    }
}

