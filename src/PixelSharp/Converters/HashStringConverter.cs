using System.Text.Json;
using System.Text.Json.Serialization;

namespace PixelSharp.Converters;

public class HashStringConverter : JsonConverter<HashedString>
{
    public override HashedString? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, HashedString value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.HashedValue);
    }
}