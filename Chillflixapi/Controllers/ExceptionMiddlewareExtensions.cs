﻿using System;
using Microsoft.AspNetCore.Builder;

namespace Chillflixapi.Controllers
{
    public static class ExceptionMiddlewareExtensions
    {
        //https://www.notion.so/dannysas/Exception-Middleware-Extensions-c917317a228b4627a412344234bd0c68
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
