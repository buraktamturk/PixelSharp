using Microsoft.Extensions.DependencyInjection;

namespace PixelSharp.AspNetCore;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPixelClient(this IServiceCollection that, string pixelId, string accessToken)
    {
        return that
            .AddSingleton<IPixelClient>(_ => new PixelClient(pixelId, accessToken));
    }
}