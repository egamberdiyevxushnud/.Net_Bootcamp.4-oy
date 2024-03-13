using MediatR;
using Medium.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Medium.Application
{
    public static class DependenyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }

    }
}
