using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace delegateHandlerWebApi.Handler
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string RESPONSE_HEADER_RESPONSE_TIME = "X-Response-Time-ms";

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/")
                context.Request.Path = "/api/values";

            return _next(context);
        //    var watch = new Stopwatch();
        //    //context.Response.OnStarting(state => {
        //    //    var httpContext = (HttpContext)state;
        //    //    httpContext.Response.Headers.Add("X-Response-Time-Milliseconds", new[] { watch.ElapsedMilliseconds.ToString() });
        //    //    return Task.FromResult(0);
        //    //}, context);
        //    watch.Start();
        //    await _next(context);
        //    context.Response.Headers.Add("X-Transfer-Success", "true");
        //    watch.Stop();
        }
    }

    public static class ApiKeyExtensions
    {
        public static IApplicationBuilder UseApiKey(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApiKeyMiddleware>();
        }
    }
}
