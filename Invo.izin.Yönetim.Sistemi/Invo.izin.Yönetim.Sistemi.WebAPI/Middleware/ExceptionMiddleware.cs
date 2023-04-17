#region NAMESPACES
using Invo.izin.Yönetim.Sistemi.Application.Exceptions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Net;

#endregion

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Middleware
{
    public class ExceptionMiddleware
    {
        #region FFIELDS
        private readonly RequestDelegate _next;
        private readonly IHostEnvironment _environment;
        private readonly IModelMetadataProvider _metadataProvider;
        private readonly ILogger _logger;
        #endregion

        #region METHODS
        public ExceptionMiddleware(RequestDelegate next, IHostEnvironment environment, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _environment = environment;
     
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            string result = JsonConvert.SerializeObject(new ErrorDeatils
            {
                ErrorMessage = exception.Message,
                ErrorType = "Hata"
            });

            switch (exception)
            {
                case BadRequestException badRequestException:
                    statusCode = HttpStatusCode.BadRequest;
                   
                    break;
                case ValidationException validationException:
                    statusCode = HttpStatusCode.BadRequest;
                    result = JsonConvert.SerializeObject(validationException.Errors);
                    break;
                case NotFoundException notFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    break;
                default:
                    break;
            }

            context.Response.StatusCode = (int)statusCode;
            _logger.LogError(result);
            return context.Response.WriteAsync(result);
        }
        #endregion


    }

    public class ErrorDeatils
    {
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
    }
}
