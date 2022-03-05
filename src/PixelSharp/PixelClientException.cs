using System.Runtime.Serialization;

namespace PixelSharp;

public class PixelClientException : Exception
{
    public PixelClientException()
    {
    }

    public PixelClientException(FacebookError error) : base($"{error.Code}: {error.Message}. {error.ErrorUserMsg}")
    {
    }
    
    protected PixelClientException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public PixelClientException(string? message) : base(message)
    {
    }

    public PixelClientException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}