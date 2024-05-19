using System;
using System.Collections.Generic;
using System.Linq;

using MetadataExtractor;

namespace Metadiary;
public class MetadataReader(string filename) : IMetadataReader
{
    private readonly IReadOnlyList<Directory> directories = ImageMetadataReader.ReadMetadata(filename);

    public void WriteMetadata()
    {
        foreach (string? tag in directories.SelectMany(d => d.Tags, (_, tag) => tag.Name))
            Console.WriteLine(tag);
    }

    public static MediaType GetMediaType(string mediaType) => MediaType.FromName(mediaType);
}
