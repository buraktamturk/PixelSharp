using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PixelSharp.Tests;

public sealed class PixelClientTests : IDisposable
{
    private const string ACCESS_TOKEN = "";
    private const string PIXEL_ID = "";
    private const string TEST_CODE = "";

    private PixelClient _pixelClient = new(PIXEL_ID, ACCESS_TOKEN);
    
    [Fact]
    public async Task TestSendEvents()
    {
        var response = await this._pixelClient
            .SendEvents(new()
            {
                Data = new List<ModelEvent>()
                {
                    new()
                    {
                        EventName = "Test",
                        ActionSource = "website",
                        EventTime = DateTimeOffset.UtcNow,
                        UserData = new()
                        {
                            Em = "test@test.com",
                            ClientIpAddress = "127.0.0.1",
                            ClientUserAgent = "Test"
                        },
                        CustomData = new()
                        {
                            Currency = "USD",
                            Value = 123.45m
                        },
                        EventSourceUrl = "http://localhost/test"
                    }
                },
                TestEventCode = TEST_CODE
            });
        
        Assert.Equal(1, response.EventsReceived);
    }
    
    [Fact]
    public async Task TestSendEventException()
    {
        var ex = await Assert.ThrowsAsync<PixelClientException>(() => this._pixelClient
            .SendEvents(new()
            {
                Data = new List<ModelEvent>()
                {
                    new()
                    {
                        EventName = "Test",
                        ActionSource = "website",
                        EventTime = DateTimeOffset.UtcNow
                    }
                },
            }));
        
        Assert.Equal("100: Invalid parameter. No user parameters have been added for this event. Include at least one user parameter for this event other than client_user_agent.", ex.Message);
    }

    public void Dispose()
    {
        _pixelClient.Dispose();
    }
}