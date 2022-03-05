
using System.Text.Json.Serialization;

namespace PixelSharp;

public record Content
{
    /// <summary>
    /// Product Id
    /// </summary>
    /// <value>Product Id</value>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// number of product
    /// </summary>
    /// <value>number of product</value>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    /// <summary>
    /// Item Price.
    /// </summary>
    /// <value>Item Price.</value>
    [JsonPropertyName("item_price")]
    public float? ItemPrice { get; init; }
}