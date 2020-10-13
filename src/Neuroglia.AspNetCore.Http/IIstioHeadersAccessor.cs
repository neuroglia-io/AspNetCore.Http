using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Neuroglia.AspNetCore.Http
{

    /// <summary>
    /// Defines the fundamentals of a service used to access Istio headers from the current <see cref="HttpContext"/>
    /// </summary>
    public interface IIstioHeadersAccessor
    {

        /// <summary>
        /// Gets an <see cref="IDictionary{TKey, TValue}"/> containing incoming Istio headers
        /// </summary>
        IDictionary<string, string> IstioHeaders { get; }

    }

}
