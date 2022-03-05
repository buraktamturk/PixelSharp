namespace PixelSharp.AspNetCore;

public class PixelClientProxy : IPixelClient
{
    private readonly IPixelClient client;
    private readonly UserData userData;
    
    public PixelClientProxy(IPixelClient client, UserData userData)
    {
        this.client = client;
        this.userData = userData;
    }
    
    public Task<ResponseSuccess> SendEvents(EventRequest ev)
    {
        if (ev is null)
            throw new ArgumentNullException(nameof(ev));
        
        return client.SendEvents(ev with
            {
                Data = ev.Data
                    .Select(a => a with
                    {
                        UserData = a.UserData is null ? userData
                            : a.UserData.With(userData)
                    })
                    .ToList()
            });
    }
}