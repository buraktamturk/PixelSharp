
using System.Text.Json.Serialization;

namespace PixelSharp;

public record CustomData
{
    /// <summary>
    /// A numeric value associated with this event. This could be a monetary value or a value in some other metric.
    /// </summary>
    /// <value>A numeric value associated with this event. This could be a monetary value or a value in some other metric.</value>
    [JsonPropertyName("value")]
    public decimal? Value { get; init; }

    /// <summary>
    /// The currency for the value specified, if applicable. Currency must be a valid ISO 4217 (https://en.wikipedia.org/wiki/ISO_4217) three digit currency code.
    /// </summary>
    /// <value>The currency for the value specified, if applicable. Currency must be a valid ISO 4217 (https://en.wikipedia.org/wiki/ISO_4217) three digit currency code.</value>
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The name of the page or product associated with the event.
    /// </summary>
    /// <value>The name of the page or product associated with the event.</value>
    [JsonPropertyName("content_name")]
    public string? ContentName { get; init; }

    /// <summary>
    /// The category of the content associated with the event.
    /// </summary>
    /// <value>The category of the content associated with the event.</value>
    [JsonPropertyName("content_category")]
    public string? ContentCategory { get; init; }

    /// <summary>
    /// The content IDs associated with the event, such as product SKUs for items in an AddToCart event: [&#39;ABC123&#39;, &#39;XYZ789&#39;]. If content_type is a product, then your content IDs must be an array with a single string value. Otherwise, this array can contain any number of string values.
    /// </summary>
    /// <value>The content IDs associated with the event, such as product SKUs for items in an AddToCart event: [&#39;ABC123&#39;, &#39;XYZ789&#39;]. If content_type is a product, then your content IDs must be an array with a single string value. Otherwise, this array can contain any number of string values.</value>
    [JsonPropertyName("content_ids")]
    public IReadOnlyCollection<string>? ContentIds { get; init; }

    /// <summary>
    /// A list of Content objects that contain the product IDs associated with the event plus information about the products. id, quantity, and item_price are available fields.
    /// </summary>
    /// <value>A list of Content objects that contain the product IDs associated with the event plus information about the products. id, quantity, and item_price are available fields.</value>
    [JsonPropertyName("contents")]
    public IReadOnlyCollection<Content>? Contents { get; init; }

    /// <summary>
    /// It should be set to &#39;product&#39; or &#39;product_group&#39;. Use &#39;product&#39;, if the keys you send represent products. Sent keys could be content_ids or contents. Use product_group, if the keys you send in content_ids represent product groups. Product groups are used to distinguish products that are identical but have variations such as color, material, size or pattern.
    /// </summary>
    /// <value>It should be set to &#39;product&#39; or &#39;product_group&#39;. Use &#39;product&#39;, if the keys you send represent products. Sent keys could be content_ids or contents. Use product_group, if the keys you send in content_ids represent product groups. Product groups are used to distinguish products that are identical but have variations such as color, material, size or pattern.</value>
    [JsonPropertyName("content_type")]
    public string? ContentType { get; init; }

    /// <summary>
    /// The order ID for this transaction as a String.
    /// </summary>
    /// <value>The order ID for this transaction as a String.</value>
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// The predicted lifetime value of a conversion event, as a String.
    /// </summary>
    /// <value>The predicted lifetime value of a conversion event, as a String.</value>
    [JsonPropertyName("predicted_ltv")]
    public decimal? PredictedLtv { get; init; }

    /// <summary>
    /// Use only with InitiateCheckout events. The number of items that a user tries to buy during checkout.
    /// </summary>
    /// <value>Use only with InitiateCheckout events. The number of items that a user tries to buy during checkout.</value>
    [JsonPropertyName("num_items")]
    public int? NumItems { get; init; }

    /// <summary>
    /// Use only with Search events. A search query made by a user.
    /// </summary>
    /// <value>Use only with Search events. A search query made by a user.</value>
    [JsonPropertyName("search_string")]
    public string? SearchString { get; init; }

    /// <summary>
    /// Use only with CompleteRegistration events. The status of the registration event
    /// </summary>
    /// <value>Use only with CompleteRegistration events. The status of the registration event</value>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
