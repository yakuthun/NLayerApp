using Microsoft.AspNetCore.Diagnostics;
using NLayer.Core.DTOs;
using NLayer.Service.Services.Exceptions;
using System.Text.Json;

namespace NLayer.API.Middlewares
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var expectionFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = expectionFeature.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };
                    context.Response.StatusCode = statusCode;
                    var response = CustomResponseDto<NoContentDto>.Fail(statusCode, expectionFeature.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                   
                }); //sonlandırıcı bir middleware'dir. request buraya geldiği an daha da bir expection gitmeyecek.
            }
            );
        }
    }
}
