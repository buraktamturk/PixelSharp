using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using PixelSharp.Converters;

namespace PixelSharp;

[JsonConverter(typeof(HashStringConverter))]
public class HashedString
{
    private readonly string _hashedValue;

    public string HashedValue => _hashedValue;

    public HashedString(string hashedValue)
    {
        this._hashedValue = hashedValue;
    }
    
    public static HashedString Hash(string str)
    {
        var bytes = Encoding.UTF8.GetBytes(str.ToLowerInvariant());
        using var hashEngine = SHA256.Create();
        var hashedBytes = hashEngine.ComputeHash(bytes, 0, bytes.Length);
        var sb = new StringBuilder();
        foreach (var b in hashedBytes)
        {
            var hex = b.ToString("x2");
            sb.Append(hex);
        }
        return new HashedString(sb.ToString());
    }
    
    public static HashedString FromHashed(string str)
    {
        return new HashedString(str);
    }
    
    public static implicit operator string(HashedString hashedString) => hashedString._hashedValue;
    public static implicit operator HashedString(string str)
    {
        return HashedString.Hash(str);
    }
}