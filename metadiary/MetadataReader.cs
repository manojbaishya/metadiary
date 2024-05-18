using System;
using System.Collections.Generic;
using System.Linq;

using MetadataExtractor;

namespace Metadiary;
public class MetadataReader(string filename)
{
    private readonly IReadOnlyList<Directory> directories = ImageMetadataReader.ReadMetadata(filename);

    public void GetMetadata()
    {
        foreach (string? tag in directories.SelectMany(d => d.Tags, (_, tag) => tag.Name))
        {
            Console.WriteLine(tag);
        }
    }
}
