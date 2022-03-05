
using System.Text.Json.Serialization;

namespace PixelSharp;

public record ModelEvent
{
    /// <summary>
    /// A Facebook pixel Standard Event or Custom Event name. This field is used to deduplicate events sent by both Facebook Pixel and Conversions API. event_id is also used in deduplication. For the same customer action, event from the browser event match event_name from the server event. If we find a match between events sent within 48 hours of each other, we only consider the first one. If a server and browser event arrive at approximately the same time (within 5 minutes of each other), we favor the browser event.
    /// </summary>
    /// <value>A Facebook pixel Standard Event or Custom Event name. This field is used to deduplicate events sent by both Facebook Pixel and Conversions API. event_id is also used in deduplication. For the same customer action, event from the browser event match event_name from the server event. If we find a match between events sent within 48 hours of each other, we only consider the first one. If a server and browser event arrive at approximately the same time (within 5 minutes of each other), we favor the browser event.</value>
    [JsonPropertyName("event_name")]
    public string EventName { get; init; }

    /// <summary>
    /// A Unix timestamp in seconds indicating when the actual event occurred. The specified time may be earlier than the time you send the event to Facebook. This is to enable batch processing and server performance optimization. event_time can be up to 7 days before you send an event to Facebook. If any event_time in data is greater than 7 days in the past, we return an error for the entire request and process no events.
    /// </summary>
    /// <value>A Unix timestamp in seconds indicating when the actual event occurred. The specified time may be earlier than the time you send the event to Facebook. This is to enable batch processing and server performance optimization. event_time can be up to 7 days before you send an event to Facebook. If any event_time in data is greater than 7 days in the past, we return an error for the entire request and process no events.</value>
    [JsonPropertyName("event_time")]
    public DateTimeOffset EventTime { get; init; }

    /// <summary>
    /// The browser URL where the event happened.
    /// </summary>
    /// <value>The browser URL where the event happened.</value>
    [JsonPropertyName("event_source_url")]
    public string? EventSourceUrl { get; init; }

    /// <summary>
    /// A flag that indicates we should not use this event for ads delivery optimization. If set to true, we only use the event for attribution.
    /// </summary>
    /// <value>A flag that indicates we should not use this event for ads delivery optimization. If set to true, we only use the event for attribution.</value>
    [JsonPropertyName("opt_out")]
    public bool? OptOut { get; init; }

    /// <summary>
    /// This ID can be any unique string chosen by the advertiser. event_id is used to deduplicate events sent by both Facebook Pixel and Conversions API. event_name is also used in deduplication. For deduplication, the eventID from a browser event must match the event_id in the corresponding server event.
    /// </summary>
    /// <value>This ID can be any unique string chosen by the advertiser. event_id is used to deduplicate events sent by both Facebook Pixel and Conversions API. event_name is also used in deduplication. For deduplication, the eventID from a browser event must match the event_id in the corresponding server event.</value>
    [JsonPropertyName("event_id")]
    public string? EventId { get; init; }

    /// <summary>
    /// This field allows you to specify where your conversions occurred. Knowing where your events took place helps ensure your ads go to the right people. See docs for the allowable values. https://developers.facebook.com/docs/marketing-api/conversions-api/parameters/server-event#action-source
    /// </summary>
    /// <value>This field allows you to specify where your conversions occurred. Knowing where your events took place helps ensure your ads go to the right people. See docs for the allowable values. https://developers.facebook.com/docs/marketing-api/conversions-api/parameters/server-event#action-source</value>
    [JsonPropertyName("action_source")]
    public string ActionSource { get; init; }

    /// <summary>
    /// Gets or Sets UserData
    /// </summary>
    [JsonPropertyName("user_data")]
    public UserData UserData { get; init; }

    /// <summary>
    /// Gets or Sets CustomData
    /// </summary>
    [JsonPropertyName("custom_data")]
    public CustomData? CustomData { get; init; }

    /// <summary>
    /// Processing options you would like to enable for a specific event. For more details see: https://developers.facebook.com/docs/marketing-apis/data-processing-options.
    /// </summary>
    /// <value>Processing options you would like to enable for a specific event. For more details see: https://developers.facebook.com/docs/marketing-apis/data-processing-options.</value>
    [JsonPropertyName("data_processing_options")]
    public IReadOnlyCollection<string>? DataProcessingOptions { get; init; }

    /// <summary>
    /// The country that you want to associate to this data processing option. If you set a country, you must also set a state. For more details see: https://developers.facebook.com/docs/marketing-apis/data-processing-options
    /// </summary>
    /// <value>The country that you want to associate to this data processing option. If you set a country, you must also set a state. For more details see: https://developers.facebook.com/docs/marketing-apis/data-processing-options</value>
    [JsonPropertyName("data_processing_options_country")]
    public int? DataProcessingOptionsCountry { get; init; }

    /// <summary>
    /// The state that you want to associate with this data processing option. For more details see: https://developers.facebook.com/docs/marketing-apis/data-processing-options.
    /// </summary>
    /// <value>The state that you want to associate with this data processing option. For more details see: https://developers.facebook.com/docs/marketing-apis/data-processing-options.</value>
    [JsonPropertyName("data_processing_options_state")]
    public int? DataProcessingOptionsState { get; init; }

}