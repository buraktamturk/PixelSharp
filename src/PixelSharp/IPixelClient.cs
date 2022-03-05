namespace PixelSharp;

public interface IPixelClient
{
    Task<ResponseSuccess> SendEvents(EventRequest ev);
}