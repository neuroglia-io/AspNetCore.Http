namespace Neuroglia.AspNetCore.Http
{

    /// <summary>
    /// Exposes constants about Istio headers
    /// </summary>
    public static class IstioHeaders
    {

        /// <summary>
        /// Gets the name of the 'x-request-id' header
        /// </summary>
        public const string REQUEST_ID = "x-request-id";

        /// <summary>
        /// Gets the name of the 'x-b3-traceid' header
        /// </summary>
        public const string B3_TRACE_ID = "x-b3-traceid";

        /// <summary>
        /// Gets the name of the 'x-b3-spanid' header
        /// </summary>
        public const string B3_SPAN_ID = "x-b3-spanid";

        /// <summary>
        /// Gets the name of the 'x-b3-parentspanid' header
        /// </summary>
        public const string B3_PARENT_SPAN_ID = "x-b3-parentspanid";

        /// <summary>
        /// Gets the name of the 'x-b3-sampled' header
        /// </summary>
        public const string B3_SAMPLED = "x-b3-sampled";

        /// <summary>
        /// Gets the name of the 'x-b3-flags' header
        /// </summary>
        public const string B3_FLAGS = "x-b3-flags";

        /// <summary>
        /// Gets the name of the 'b3' header
        /// </summary>
        public const string B3 = "b3";

        /// <summary>
        /// Gets the name of the 'x-ot-span-context' header
        /// </summary>
        public const string OT_SPAN_CONTEXT = "x-ot-span-context";

    }

}
