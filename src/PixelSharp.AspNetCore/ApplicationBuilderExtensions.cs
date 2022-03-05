using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace PixelSharp.AspNetCore;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UsePixelClientUserData(this IApplicationBuilder appBuilder,
        Func<HttpContext, UserData?>? customUserDataProvider = null)
    {
        return appBuilder.Use(async (res, next) =>
        {
            var requestUserData = res.GetBaseUserData();

            var customUserData = customUserDataProvider?.Invoke(res);
            if (customUserData is not null) {
                requestUserData = requestUserData.With(customUserData);
            }

            var client = new PixelClientProxy(
                res.RequestServices.GetRequiredService<IPixelClient>(),
                requestUserData
            );
            
            var old = res.RequestServices;
            res.RequestServices = new RequestServicesProxy(old, client);
            try
            {
                await next();
            }
            finally
            {
                res.RequestServices = old;
            }
        });
    }
}