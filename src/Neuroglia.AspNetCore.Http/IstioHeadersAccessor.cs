using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.Linq;

namespace Neuroglia.AspNetCore.Http
{

    /// <summary>
    /// Represents the default implementation of the <see cref="IIstioHeadersAccessor"/> interface
    /// </summary>
    public class IstioHeadersAccessor
        : IIstioHeadersAccessor
    {

        /// <summary>
        /// Initializes a new <see cref="IstioHeadersAccessor"/>
        /// </summary>
        /// <param name="httpContextAccessor">The service used to access the current <see cref="HttpContext"/></param>
        public IstioHeadersAccessor(IHttpContextAccessor httpContextAccessor)
        {
            this.HttpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Gets the service used to access the current <see cref="HttpContext"/>
        /// </summary>
        protected IHttpContextAccessor HttpContextAccessor { get; }

        /// <inheritdoc/>
        public IDictionary<string, string> IstioHeaders
        {
            get
            {
                Dictionary<string, string> headers = new Dictionary<string, string>();
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.REQUEST_ID, out StringValues value))
                    headers.Add(Http.IstioHeaders.REQUEST_ID, value.FirstOrDefault());
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.B3_TRACE_ID, out value))
                    headers.Add(Http.IstioHeaders.B3_TRACE_ID, value.FirstOrDefault());
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.B3_SPAN_ID, out value))
                    headers.Add(Http.IstioHeaders.B3_SPAN_ID, value.FirstOrDefault());
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.B3_PARENT_SPAN_ID, out value))
                    headers.Add(Http.IstioHeaders.B3_PARENT_SPAN_ID, value.FirstOrDefault());
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.B3_SAMPLED, out value))
                    headers.Add(Http.IstioHeaders.B3_SAMPLED, value.FirstOrDefault());
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.B3_FLAGS, out value))
                    headers.Add(Http.IstioHeaders.B3_FLAGS, value.FirstOrDefault());
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.B3, out value))
                    headers.Add(Http.IstioHeaders.B3, value.FirstOrDefault());
                if (this.HttpContextAccessor.HttpContext.Request.Headers.TryGetValue(Http.IstioHeaders.OT_SPAN_CONTEXT, out value))
                    headers.Add(Http.IstioHeaders.OT_SPAN_CONTEXT, value.FirstOrDefault());
                return headers;
            }
        }

    }

}
