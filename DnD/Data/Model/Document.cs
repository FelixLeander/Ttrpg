using System.Text.Json.Serialization;

namespace DnD.Data.Model;

internal class Document
{
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("license")]
    public string? License { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("copyright")]
    public string? Copyright { get; set; }

    [JsonPropertyName("license_url")]
    public string? LicenseUrl { get; set; }
}