using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace delegateHandler.Handlers
{
    public class DelegatingHandlerTemplate : DelegatingHandler
    {

        const string _header = "X-API-Timer";
        protected async override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var timer = Stopwatch.StartNew();

            var response = await base.SendAsync(request, cancellationToken);

            var elapsed = timer.ElapsedMilliseconds;

            Trace.WriteLine(" -- Pipeline Action time msec: " + elapsed);
            response.Headers.Add(_header, elapsed + " msec");

            return response;
        }

    }
}