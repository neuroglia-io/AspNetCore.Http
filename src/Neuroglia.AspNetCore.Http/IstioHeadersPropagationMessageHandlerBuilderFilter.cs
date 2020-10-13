using Microsoft.Extensions.Http;
using System;
using System.Net.Http;

namespace Neuroglia.AspNetCore.Http
{

    /// <summary>
    /// Represents an <see cref="IHttpMessageHandlerBuilderFilter"/> used to configure an <see cref="HttpMessageHandlerBuilder"/> to propagate Istio headers
    /// </summary>
    public class IstioHeadersPropagationMessageHandlerBuilderFilter 
        : IHttpMessageHandlerBuilderFilter
    {

        /// <summary>
        /// Initializes a new <see cref="IstioHeadersPropagationMessageHandlerBuilderFilter"/>
        /// </summary>
        /// <param name="istioHeadersPropagationDelegatingHandler">The <see cref="DelegatingHandler"/> used to propagate Istio headers</param>
        public IstioHeadersPropagationMessageHandlerBuilderFilter(IstioHeadersPropagationDelegatingHandler istioHeadersPropagationDelegatingHandler)
        {
            this.IstioHeadersPropagationDelegatingHandler = istioHeadersPropagationDelegatingHandler;
        }

        /// <summary>
        /// Gets the <see cref="DelegatingHandler"/> used to propagate Istio headers
        /// </summary>
        protected IstioHeadersPropagationDelegatingHandler IstioHeadersPropagationDelegatingHandler { get; }

        /// <inheritdoc/>
        public Action<HttpMessageHandlerBuilder> Configure(Action<HttpMessageHandlerBuilder> next)
        {
            if (next == null)
                throw new ArgumentNullException(nameof(next));
            return (builder) =>
            {
                next(builder);
                builder.AdditionalHandlers.Add(this.IstioHeadersPropagationDelegatingHandler);
            };
        }

    }

}
