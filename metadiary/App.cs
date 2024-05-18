using CommandDotNet;

namespace Metadiary;

public static class App
{
    private static int Main(string[] args) => new AppRunner<MetadataReader>().UseDefaultMiddleware().Run(args);
}
