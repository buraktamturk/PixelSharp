namespace PixelSharp.AspNetCore;

public class RequestServicesProxy : IServiceProvider
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IPixelClient _pixelClient;
    
    public RequestServicesProxy(IServiceProvider serviceProvider, IPixelClient pixelClient)
    {
        this._serviceProvider = serviceProvider;
        this._pixelClient = pixelClient;
    }
    
    public object? GetService(Type serviceType)
    {
        if (serviceType == typeof(IPixelClient))
        {
            return _pixelClient;
        }

        return _serviceProvider.GetService(serviceType);
    }
}
