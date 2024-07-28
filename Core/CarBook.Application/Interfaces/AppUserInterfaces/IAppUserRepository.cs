using System;
using CarBook.Domain.Entities;
using System.Linq.Expressions;

namespace CarBook.Application.Interfaces.AppUserInterfaces
{
	public interface IAppUserRepository
	{
        Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter);
    }
}

