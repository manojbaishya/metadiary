using Ardalis.SmartEnum;

using FluentAssertions;

namespace Metadiary.Tests;
public class MetadataTests
{
    [Theory]
    [InlineData("Image")]
    [InlineData("Audio")]
    [InlineData("Video")]
    [InlineData("Invalid")]
    public void TestGetMediaType(string filetype)
    {
        try
        {
            MediaType mediaType = MetadataReader.GetMediaType(filetype);
            mediaType.Should().NotBeNull();
            mediaType.ToString().Should().Be(filetype);
        } catch (SmartEnumNotFoundException enumNotFoundException)
        {
            enumNotFoundException.Message.Should().Be(@$"No MediaType with Name ""{filetype}"" found.");
        }
    }
}