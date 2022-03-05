
using System.Text.Json.Serialization;

namespace PixelSharp;

public record FacebookErrorResponse
{
    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public FacebookError Error { get; init; }
}

public record FacebookError
{
    [JsonPropertyName("code")]
    public int Code { get; init; }
    
    [JsonPropertyName("message")]
    public string Message { get; init; }
    
    [JsonPropertyName("type")]
    public string Type { get; init; }
    
    [JsonPropertyName("error_subcode")]
    public int ErrorSubcode { get; init; }
    
    [JsonPropertyName("is_transient")]
    public bool IsTransient { get; init; }
    
    [JsonPropertyName("error_user_title")]
    public string ErrorUserTitle { get; init; }
    
    [JsonPropertyName("error_user_msg")]
    public string ErrorUserMsg { get; init; }
    
    [JsonPropertyName("fbtrace_id")]
    public string FbtraceId { get; init; }
}