using Ardalis.SmartEnum;

using FluentAssertions;

namespace Metadiary.Tests;
public class MetadataTests
{
    [Theory]
    [InlineData("image")]
    [InlineData("audio")]
    [InlineData("video")]
    [InlineData("Invalid")]
    public void TestGetMediaType(string filetype)
    {
        try
        {
            MediaType mediaType = MetadataReader.GetMediaType(filetype.ToLower());
            mediaType.Should().NotBeNull();
            mediaType.ToString().Should().Be(filetype);
        } catch (SmartEnumNotFoundException enumNotFoundException)
        {
            enumNotFoundException.Message.Should().Be(@$"No MediaType with Name ""{filetype.ToLower()}"" found.");
        }
    }
}