using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Middleware
{
    public class LoggerMiddleware : IMiddleware
    {
        private readonly ILogger<LoggerMiddleware> _logger;
        public LoggerMiddleware(ILogger<LoggerMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _logger.LogError("Middleware!!!");

            await next(context);
        }
    }
}
