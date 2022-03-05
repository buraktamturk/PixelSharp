
using System.Text.Json.Serialization;

namespace PixelSharp;

public record ResponseSuccess 
{
    /// <summary>
    /// Gets or Sets EventsReceived
    /// </summary>
    [JsonPropertyName("events_received")]
    public int EventsReceived { get; init; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [JsonPropertyName("messages")]
    public IReadOnlyCollection<string>? Messages { get; init; }

    /// <summary>
    /// Gets or Sets FbtraceId
    /// </summary>
    [JsonPropertyName("fbtrace_id")]
    public string? FbtraceId { get; init; }
}
