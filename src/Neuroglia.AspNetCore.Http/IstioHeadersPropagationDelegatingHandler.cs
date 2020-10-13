using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Neuroglia.AspNetCore.Http
{

    /// <summary>
    /// Represents a <see cref="DelegatingHandler"/> used to propagate Istio headers
    /// </summary>
    public class IstioHeadersPropagationDelegatingHandler
        : DelegatingHandler
    {

        /// <summary>
        /// Initializes a new <see cref="IstioHeadersPropagationDelegatingHandler"/>
        /// </summary>
        /// <param name="istioHeadersAccessor">The service used to access incoming Istio headers</param>
        public IstioHeadersPropagationDelegatingHandler(IIstioHeadersAccessor istioHeadersAccessor)
        {
            this.IstioHeadersAccessor = istioHeadersAccessor;
        }

        /// <summary>
        /// Gets the service used to access incoming Istio headers
        /// </summary>
        protected IIstioHeadersAccessor IstioHeadersAccessor { get; }

        /// <inheritdoc/>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            foreach(KeyValuePair<string, string> header in this.IstioHeadersAccessor.IstioHeaders)
            {
                request.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }
            return await base.SendAsync(request, cancellationToken);
        }

    }

}
