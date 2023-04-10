#region NAMESPACES
using FluentValidation;
using Invo.izin.Yönetim.Sistemi.Application.Extensions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

#endregion

namespace Invo.izin.Yönetim.Sistemi.Application
{
    public static class ApplicationServicesRegistration
    {

        #region METHODS
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddSwaggerDocumentation();
            return services;

        }
        #endregion

    }
}
