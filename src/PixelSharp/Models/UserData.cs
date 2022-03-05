
using System.Text.Json.Serialization;

namespace PixelSharp;

public record UserData
{
    /// <summary>
    /// A hashed email address in lower case using SHA-256 algorithm.
    /// </summary>
    /// <value>A hashed email address in lower case using SHA-256 algorithm.</value>
    [JsonPropertyName("em")]
    public HashedString? Em { get; init; }

    /// <summary>
    /// A hashed phone number using SHA-256 algorithm. Include only digits with country code, area code, and number.
    /// </summary>
    /// <value>A hashed phone number using SHA-256 algorithm. Include only digits with country code, area code, and number.</value>
    [JsonPropertyName("ph")]
    public HashedString? Ph { get; init; }

    /// <summary>
    /// A hashed gender (f or m) using SHA-256 algorithm.
    /// </summary>
    /// <value>A hashed gender (f or m) using SHA-256 algorithm.</value>
    [JsonPropertyName("ge")]
    public HashedString? Ge { get; init; }

    /// <summary>
    /// A hashed date of birth given as year, month, and day using SHA-256 algorithm
    /// </summary>
    /// <value>A hashed date of birth given as year, month, and day using SHA-256 algorithm</value>
    [JsonPropertyName("db")]
    public HashedString? Db { get; init; }

    /// <summary>
    /// A hashed last name in lowercase using SHA-256 algorithm.
    /// </summary>
    /// <value>A hashed last name in lowercase using SHA-256 algorithm.</value>
    [JsonPropertyName("ln")]
    public HashedString? Ln { get; init; }

    /// <summary>
    /// A hashed first name in lowercase using SHA-256 algorithm.
    /// </summary>
    /// <value>A hashed first name in lowercase using SHA-256 algorithm.</value>
    [JsonPropertyName("fn")]
    public HashedString? Fn { get; init; }

    /// <summary>
    /// A hashed city in lower-case without spaces or punctuation using SHA-256 algorithm.
    /// </summary>
    /// <value>A hashed city in lower-case without spaces or punctuation using SHA-256 algorithm.</value>
    [JsonPropertyName("ct")]
    public HashedString? Ct { get; init; }

    /// <summary>
    /// A hashed two-letter country code in lowercase using SHA-256 algorithm.
    /// </summary>
    /// <value>A hashed two-letter country code in lowercase using SHA-256 algorithm.</value>
    [JsonPropertyName("country")]
    public HashedString? Country { get; init; }

    /// <summary>
    /// A hashed two-letter state code in lowercase using SHA-256 algorithm.
    /// </summary>
    /// <value>A hashed two-letter state code in lowercase using SHA-256 algorithm.</value>
    [JsonPropertyName("st")]
    public HashedString? St { get; init; }

    /// <summary>
    /// A hashed zip code using SHA-256 algorithm. If you are in the United States, this is a five-digit zip code. For other locations, follow each country&#39;s standards.
    /// </summary>
    /// <value>A hashed zip code using SHA-256 algorithm. If you are in the United States, this is a five-digit zip code. For other locations, follow each country&#39;s standards.</value>
    [JsonPropertyName("zp")]
    public HashedString? Zp { get; init; }

    /// <summary>
    /// Any unique ID from the advertiser, such as loyalty membership IDs, user IDs, and external cookie IDs. If External ID is being sent via other channels, it should be sent in the same format via Conversions API. Hashing external_id using SHA-256 algorithm is optional.
    /// </summary>
    /// <value>Any unique ID from the advertiser, such as loyalty membership IDs, user IDs, and external cookie IDs. If External ID is being sent via other channels, it should be sent in the same format via Conversions API. Hashing external_id using SHA-256 algorithm is optional.</value>
    [JsonPropertyName("external_id")]
    public string ExternalId { get; init; }

    /// <summary>
    /// The IP address of the browser corresponding to the event.
    /// </summary>
    /// <value>The IP address of the browser corresponding to the event.</value>
    [JsonPropertyName("client_ip_address")]
    public string? ClientIpAddress { get; init; }

    /// <summary>
    /// The user agent for the browser corresponding to the event.
    /// </summary>
    /// <value>The user agent for the browser corresponding to the event.</value>
    [JsonPropertyName("client_user_agent")]
    public string ClientUserAgent { get; init; }

    /// <summary>
    /// The Facebook click ID value stored in the _fbc browser cookie under your domain. See Managing fbc and fbp Parameters for how to get this value (https://developers.facebook.com/docs/marketing-api/conversions-api/parameters/fbp-and-fbc), or generate this value from a fbclid query parameter.
    /// </summary>
    /// <value>The Facebook click ID value stored in the _fbc browser cookie under your domain. See Managing fbc and fbp Parameters for how to get this value (https://developers.facebook.com/docs/marketing-api/conversions-api/parameters/fbp-and-fbc), or generate this value from a fbclid query parameter.</value>
    [JsonPropertyName("fbc")]
    public string Fbc { get; init; }

    /// <summary>
    /// The Facebook browser ID value stored in the _fbp browser cookie under your domain. See Managing fbc and fbp Parameters for how to get this value (https://developers.facebook.com/docs/marketing-api/conversions-api/parameters/fbp-and-fbc).
    /// </summary>
    /// <value>The Facebook browser ID value stored in the _fbp browser cookie under your domain. See Managing fbc and fbp Parameters for how to get this value (https://developers.facebook.com/docs/marketing-api/conversions-api/parameters/fbp-and-fbc).</value>
    [JsonPropertyName("fbp")]
    public string Fbp { get; init; }

    /// <summary>
    /// The subscription ID for the user in this transaction. This is similar to the order ID for an individual product.
    /// </summary>
    /// <value>The subscription ID for the user in this transaction. This is similar to the order ID for an individual product.</value>
    [JsonPropertyName("subscription_id")]
    public string SubscriptionId { get; init; }

    public UserData With(UserData userData)
    {
        return this with
        {
            Em = this.Em ?? userData.Em,
            Ph = this.Ph ?? userData.Ph,
            Ge = this.Ge ?? userData.Ge,
            Db = this.Db ?? userData.Db,
            Ln = this.Ln ?? userData.Ln,
            Fn = this.Fn ?? userData.Fn,
            Ct = this.Ct ?? userData.Ct,
            Country = this.Country ?? userData.Country,
            St = this.St ?? userData.St,
            Zp = this.Zp ?? userData.Zp,
            ExternalId = this.ExternalId ?? userData.ExternalId,
            SubscriptionId = this.SubscriptionId ?? userData.SubscriptionId,
            ClientIpAddress = this.ClientIpAddress ?? userData.ClientIpAddress,
            ClientUserAgent = this.ClientUserAgent ?? userData.SubscriptionId,
            Fbc = this.Fbc ?? userData.Fbc,
            Fbp = this.Fbp ?? userData.Fbp
        };
    }
}