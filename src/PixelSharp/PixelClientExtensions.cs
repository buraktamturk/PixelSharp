namespace PixelSharp;

public static class PixelClientExtensions
{
    public static Task<ResponseSuccess> SendEvent(this IPixelClient pixelClient, ModelEvent modelEvent)
    {
        return pixelClient.SendEvents(new EventRequest()
        {
            Data = new[] {modelEvent}
        });
    }
}