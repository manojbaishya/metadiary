using Ardalis.SmartEnum;

namespace Metadiary;

public sealed class MediaType : SmartEnum<MediaType>
{
    public static readonly MediaType image = new(nameof(image), 1);
    public static readonly MediaType audio = new(nameof(audio), 2);
    public static readonly MediaType video = new(nameof(video), 3);

    private MediaType(string name, int value) : base(name, value) { }
}
