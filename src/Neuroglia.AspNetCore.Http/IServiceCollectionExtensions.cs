using Microsoft.Extensions.DependencyInjection;

namespace Neuroglia.AspNetCore.Http
{

    /// <summary>
    /// Defines extensions for <see cref="IServiceCollection"/>s
    /// </summary>
    public static class IServiceCollectionExtensions
    {

        /// <summary>
        /// Adds Istio header propagation
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to configure</param>
        /// <returns>The configured <see cref="IServiceCollection"/></returns>
        public static IServiceCollection AddIstioHeadersPropagation(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddTransient<IIstioHeadersAccessor, IstioHeadersAccessor>();
            services.AddTransient<IstioHeadersPropagationDelegatingHandler>();
            services.AddTransient<IstioHeadersPropagationMessageHandlerBuilderFilter>();
            return services;
        }

    }

}
