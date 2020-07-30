using EClinic.Framework.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace B2B.Framework.Validation
{
    public class ModelStateValidationFilter : IActionFilter, IWebApiFilter
    {
        private readonly IConfiguration _configuration;

        public ModelStateValidationFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int Order => 4;

        public void OnActionExecuted(ActionExecutedContext context) { }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string projectType = _configuration["Framework:ProjectType"];
            if (projectType == "WebApi")
            {
                if (!context.ModelState.IsValid)
                {
                    context.Result = new BadRequestObjectResult(context.ModelState);
                }
            }
            else
            {
                if (!context.ModelState.IsValid)
                {
                    context.Result = new OkObjectResult(context.ModelState);
                }
            }

        }
    }
}