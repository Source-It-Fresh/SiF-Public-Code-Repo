using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SourceItFrech.Handlers
{
    public class ForwardCookiesHandler : DelegatingHandler
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ForwardCookiesHandler(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var context = _httpContextAccessor.HttpContext;
            if (context != null && context.Request.Headers.ContainsKey("Cookie"))
            {
                // Forward all cookies from the incoming request
                request.Headers.Add("Cookie", context.Request.Headers["Cookie"].ToArray());
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}