﻿using System;
namespace CarBook.Application.Features.Mediator.Results.BlogResults
{
	public class GetBlogByIdQueryResult
	{
        public int BlogID { get; set; }

        public string Title { get; set; }

        public string AuthorID { get; set; }

        public string CoverImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CategoryID { get; set; }
    }
}

