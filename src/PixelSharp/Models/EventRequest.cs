
using System.Text.Json.Serialization;

namespace PixelSharp;

public record EventRequest
{
    /// <summary>
    /// Partner agent string.
    /// </summary>
    /// <value>Partner agent string.</value>
    [JsonPropertyName("partner_agent")]
    public string? PartnerAgent { get; init; }
    
    /// <summary>
    /// An array of Server Event objects.
    /// </summary>
    /// <value>An array of Server Event objects.</value>
    [JsonPropertyName("data")]
    public IReadOnlyCollection<ModelEvent> Data { get; init; }

    /// <summary>
    /// Code used to verify that your server events are received correctly by Facebook. Use this code to test your server events in the Test Events feature in Events Manager. See Test Events Tool (https://developers.facebook.com/docs/marketing-api/conversions-api/using-the-api#testEvents) for an example.
    /// </summary>
    /// <value>Code used to verify that your server events are received correctly by Facebook. Use this code to test your server events in the Test Events feature in Events Manager. See Test Events Tool (https://developers.facebook.com/docs/marketing-api/conversions-api/using-the-api#testEvents) for an example.</value>
    [JsonPropertyName("test_event_code")]
    public string? TestEventCode { get; init; }
}