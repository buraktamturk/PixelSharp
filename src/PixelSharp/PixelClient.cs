using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace PixelSharp;

public sealed class PixelClient : IPixelClient, IDisposable
{
    private readonly HttpClient _httpClient;
    
    public PixelClient(string pixelId, string accessToken)
    {
        this._httpClient = new HttpClient()
        {
            BaseAddress = new Uri($"https://graph.facebook.com/v8.0/{pixelId}/"),
            DefaultRequestHeaders =
            {
                Authorization = new AuthenticationHeaderValue("Bearer", accessToken)
            }
        };
    }
    
    public async Task<ResponseSuccess> SendEvents(EventRequest ev)
    {
        if (ev is null)
            throw new ArgumentNullException(nameof(ev));

        using var response = await this._httpClient.PostAsJsonAsync("events", ev);

        if (!response.IsSuccessStatusCode)
        {            var str = await response.Content.ReadAsStringAsync();

            var error = await response.Content.ReadFromJsonAsync<FacebookErrorResponse>();

            throw new PixelClientException(error.Error!);
        }

        return (await response.Content.ReadFromJsonAsync<ResponseSuccess>())!;
    }

    public void Dispose()
    {
        this._httpClient.Dispose();
    }
}
