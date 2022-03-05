# PixelSharp

This package provides a client for Facebook Pixel's Server Side Conversions API (https://developers.facebook.com/docs/marketing-api/conversions-api/).

### Sample Usage

```csharp
using var pixelClient = new PixelClient("PIXEL_ID", "ACCESS_TOKEN");

await this._pixelClient
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
```

# PixelSharp.AspNetCore

This package provides useful extension methods such as integration with dependency injection, a middleware that modifies PixelClient to include ClientIpAddress, ClientUserAgent and relevant Facebook cookies or to extract them from HttpContext.

# License

© 2022 [Burak Tamturk](https://burak.gr/)

Released under the [MIT LICENSE](http://opensource.org/licenses/MIT)