using EClinic.Framework.Filters;
using EClinic.Framework.Http.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Serilog;
using System;

namespace EClinic.Framework.Logging
{
    public class ExceptionLogFilter : IExceptionFilter, IActionFilter, IWebApiFilter
    {
        private readonly ILogger _logger;
        private string requestBodyJson;

        public int Order => 4;

        public ExceptionLogFilter(ILogger logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            requestBodyJson = JsonConvert.SerializeObject(context.ActionArguments);
        }

        public void OnException(ExceptionContext context)
        {
            Exception exception = context.Exception;
            HttpRequest request = context.HttpContext.Request;

            string exceptionType = exception.GetType().ToString();
            string newLine = Environment.NewLine;
            string url = request.GetAbsoluteUri().ToString();
            var exceptionMessage = $"Exception: {exceptionType} {newLine}" +
                $"Message: {exception.Message} {newLine}" +
                $"URL: {url} {newLine}" +
                $"Request Body: {requestBodyJson} {newLine}";// +
                //$"StackTrace: {exception.StackTrace}";

            _logger.Error(exception, exceptionMessage);
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}