using Microsoft.AspNetCore.Http;
using System;

namespace EClinic.Framework.Http.Extensions
{
    public static class HttpRequestExtensions
    {
        public static Uri GetAbsoluteUri(this HttpRequest request)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = request.Scheme;
            uriBuilder.Host = request.Host.Host;
            uriBuilder.Path = request.Path.ToString();
            uriBuilder.Query = request.QueryString.ToString();
            return uriBuilder.Uri;
        }
    }
}