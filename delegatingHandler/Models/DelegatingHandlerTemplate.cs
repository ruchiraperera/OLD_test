using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace delegatingHandler.Models
{
    public class DelegatingHandlerTemplate : DelegatingHandler
    {

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            var auth = request.Headers.Authorization;
            if (auth != null)
            {
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

    }
}
