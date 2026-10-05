using SPTarkov.Server.Core.Models.Spt.Mod;
using SemanticVersioning;

namespace KnightMaskFix;

public record ModMetadata : IModMetadata
{
    public string ModGuid { get; init; } = "com.fums.KnightMaskFix";
    public string Name { get; init; } = "Fums Knight Mask Fix";
    public string Author { get; init; } = "Fums (Flex Wayne modernized version of Umbigo Preto's Face the Knight Mask Fix)";
    public List<string>? Contributors { get; init; }
    public SemanticVersioning.Version Version { get; init; } = new("1.0.0");
    public SemanticVersioning.Range SptVersion { get; init; } = new("~4.1.3");
    public List<string>? Incompatibilities { get; init; }
    public Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; }
    public string? Url { get; init; } = "https://github.com/MrFums/KnightMaskFix/blob/master/README.md";
    public bool? IsBundleMod { get; init; } = true;
    public string License { get; init; } = "MIT";
    public bool HasPrepatcher { get; init; } = false; 
}