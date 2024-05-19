using Ardalis.SmartEnum;

namespace Metadiary;

public sealed class MediaType : SmartEnum<MediaType>
{
    public static readonly MediaType Image = new(nameof(Image), 1);
    public static readonly MediaType Audio = new(nameof(Audio), 2);
    public static readonly MediaType Video = new(nameof(Video), 3);

    private MediaType(string name, int value) : base(name, value) { }
}
