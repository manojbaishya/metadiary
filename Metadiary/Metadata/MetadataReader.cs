using System.Collections.Generic;
using System.Linq;

using CommandDotNet;

using MetadataExtractor;

namespace Metadiary;
public class MetadataReader : IMetadataReader
{
    public static MediaType GetMediaType(string mediaType) => MediaType.FromName(mediaType);

    [Command("getmediatype")]
    public void GetMediaType(IConsole console, string filename)
    {
        IReadOnlyList<Directory> directories = ImageMetadataReader.ReadMetadata(filename);
        string? mimeCategory = directories?.FirstOrDefault(dir => dir.Name.StartsWith("File Type"))?.Tags?.FirstOrDefault(tag => tag.Type == 3)?.Description?.Split('/')[0];
        var mediaType = MediaType.FromName(mimeCategory?.ToLower());
        console.WriteLine($"The media type is {mediaType.Name}");
    }

    [Command("get")]
    public void WriteMetadata(IConsole console, string filename)
    {
        IReadOnlyList<Directory> directories = ImageMetadataReader.ReadMetadata(filename);
        foreach ((Directory? dir, Tag? tag) in directories.SelectMany(dir => dir.Tags, (dir, tag) => (dir, tag)))
            console.WriteLine($"{dir.Name} - {tag.Name} / {tag.Type} = {tag.Description}");
    }
}
