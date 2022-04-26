using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced_.NET_Assignment_3.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (!httpContext.Request.Headers.ContainsKey("Accept"))
            {
                httpContext.Response.StatusCode = 406;
                await httpContext.Response.WriteAsync("Bad request. Accept header must be present");
                return;
            }
            if (!(httpContext.Request.Headers["Accept"].Contains("application/json") || httpContext.Request.Headers["Accept"].Contains("application/xml")))
            {
                httpContext.Response.Headers.Add("Accept", "application/json");
            }
            //httpContext.Response.Headers.Add("Accept", "application/json");
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
