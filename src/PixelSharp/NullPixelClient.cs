namespace PixelSharp;

public class NullPixelClient : IPixelClient
{
    private static NullPixelClient? _instance;

    public static IPixelClient Instance = _instance ??= new NullPixelClient();
    
    private NullPixelClient()
    {
        
    }
    
    public Task<ResponseSuccess> SendEvents(EventRequest ev)
    {
        return Task.FromResult(new ResponseSuccess()
        {
            EventsReceived = 0
        });
    }
}