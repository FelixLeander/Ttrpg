using System.Text.Json.Serialization;

namespace DnD.Data.Model;

internal class Feat
{
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("desc")]
    public string? Description { get; set; }

    [JsonPropertyName("prerequisite")]
    public string? Prerequisite { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }
}