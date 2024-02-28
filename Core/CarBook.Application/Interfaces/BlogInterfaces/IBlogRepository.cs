﻿using System;
using CarBook.Domain.Entities;
namespace CarBook.Application.Interfaces.BlogInterfaces
{
	public interface IBlogRepository
	{
		public List<Blog> GetLast3BlogsWithAuthors();

		public List<Blog> GetAllBlogsWithAuthors();
	}
}

