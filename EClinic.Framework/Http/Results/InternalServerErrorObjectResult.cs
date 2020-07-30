using Microsoft.AspNetCore.Mvc;

namespace EClinic.Framework.Http.Results
{
    public class InternalServerErrorObjectResult : ObjectResult
    {
        public InternalServerErrorObjectResult(object value) : base(value)
        {
            StatusCode = 500;
        }
    }
}