using Microsoft.AspNetCore.Http;

namespace PixelSharp.AspNetCore;

public static class HttpContextExtensions
{
    public static UserData GetBaseUserData(this HttpContext context)
    {
        return new UserData()
        {
            ClientIpAddress = context.Connection?.RemoteIpAddress?.ToString(),
            ClientUserAgent = context.Request.Headers.UserAgent,
            Fbc = context.Request.Cookies["_fbc"],
            Fbp = context.Request.Cookies["_fbp"]
        };
    }
}