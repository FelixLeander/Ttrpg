using System.Text.Json.Serialization;

namespace DnD.Data.Model;

internal class Background
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("skill_proficiencies")]
    public string? SkillProficiencies { get; set; }

    [JsonPropertyName("tool_proficiencies")]
    public string? ToolProficiencies { get; set; }

    [JsonPropertyName("languages")]
    public string? Languages { get; set; }

    [JsonPropertyName("equipment")]
    public string? Equipment { get; set; }

    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    [JsonPropertyName("feature_desc")]
    public string? FeatureDesc { get; set; }

    [JsonPropertyName("suggested_characteristics")]
    public string? SuggestedCharacteristics { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }
}