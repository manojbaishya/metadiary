using CommandDotNet;

namespace Metadiary;
public interface IMetadataReader
{
    /// <summary>
    /// Write Metadata of the file input.
    /// </summary>
    public void WriteMetadata(IConsole console, string filename);

    public void GetMediaType(IConsole console, string filename);
}
