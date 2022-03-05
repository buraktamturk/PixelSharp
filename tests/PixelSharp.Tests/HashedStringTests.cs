using System.Text.Json;
using Xunit;

namespace PixelSharp.Tests;

public class HashedStringTests
{
    [Fact]
    public void TestHashing()
    {
        HashedString str = "John_Smith@gmail.com";
        
        Assert.Equal(
        "62a14e44f765419d10fea99367361a727c12365e2520f32218d505ed9aa0f62f", 
        str.HashedValue
        );
        
        Assert.Equal(
            "6915771be1c5aa0c886870b6951b03d7eafc121fea0e80a5ea83beb7c449f4ec", 
            HashedString.Hash("Mary").HashedValue
        );
        
        Assert.Equal(
            "8fa8cd9c440be61d0151429310034083132b35975c4bea67fdd74158eb51db14", 
            HashedString.Hash("정").HashedValue
        );
        
        Assert.Equal(
            "08e1996b5dd49e62a4b4c010d44e4345592a863bb9f8e3976219bac29417149c", 
            HashedString.Hash("Valéry").HashedValue
        );
    }

    [Fact]
    public void TestConverter()
    {
        var str = JsonSerializer.Serialize(new
        {
            test = HashedString.Hash("Valéry")
        });
        
        Assert.Equal(@"{""test"":""08e1996b5dd49e62a4b4c010d44e4345592a863bb9f8e3976219bac29417149c""}", str);
    }
}