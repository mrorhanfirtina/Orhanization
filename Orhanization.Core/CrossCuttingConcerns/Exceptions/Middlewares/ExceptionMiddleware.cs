using Microsoft.AspNetCore.Http;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Handlers;
using Orhanization.Core.CrossCuttingConcerns.Logging;
using Orhanization.Core.CrossCuttingConcerns.Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Orhanization.Core.CrossCuttingConcerns.Exceptions.Middlewares;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly HttpExceptionHandler _httpExceptionHandler;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly LoggerServiceBase _loggerService;

    public ExceptionMiddleware(RequestDelegate next, IHttpContextAccessor httpContextAccessor, LoggerServiceBase loggerService)
    {
        _next = next;
        _httpExceptionHandler = new HttpExceptionHandler();
        _httpContextAccessor = httpContextAccessor;
        _loggerService = loggerService;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            await LogException(httpContext, ex);
            await HandleExceptionAsync(httpContext.Response, ex);
        }
    }

    private Task LogException(HttpContext httpContext, Exception ex)
    {
        List<LogParameter> parameters = new List<LogParameter>()
        {
            new LogParameter
            {
                Type = httpContext.GetType().Name, Value=ex.ToString()
            }
        };

        LogDetailWithException logDetail = new()
        {
            MethodName = _next.Method.Name,
            Parameters = parameters,
            User = _httpContextAccessor.HttpContext?.User.Identity?.Name ?? "?",
            ExceptionMessage = ex.Message
        };

        _loggerService.Error(JsonSerializer.Serialize(logDetail));

        return Task.CompletedTask;

    }

    private Task HandleExceptionAsync(HttpResponse httpResponse, Exception exception)
    {
        httpResponse.ContentType = "application/json";
        _httpExceptionHandler.Response = httpResponse;
        return _httpExceptionHandler.HandleExceptionAsync(exception);
    }

}
