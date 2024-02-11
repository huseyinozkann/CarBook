using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace CarBook.Application.Services
{
	public static class ServiceRegistiration
	{
		public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
		}
	}
}

