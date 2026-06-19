using System.Text.Json.Serialization;

namespace NArk.Swaps.Boltz.Models.Info;

public class VersionResponse
{
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    [Obsolete("Boltz exposes the commit hash as part of Version; the API does not return this field.")]
    [JsonPropertyName("commitHash")]
    public string? CommitHash { get; set; }

}
