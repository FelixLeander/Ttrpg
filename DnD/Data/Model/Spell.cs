using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;
public class Spell
{
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("higher_level")]
    public string? HigherLevel { get; set; }

    [JsonPropertyName("page")]
    public string? Page { get; set; }

    [JsonPropertyName("range")]
    public string? Range { get; set; }

    [JsonPropertyName("components")]
    public string? Components { get; set; }

    [JsonPropertyName("material")]
    public string? Material { get; set; }

    [JsonPropertyName("ritual")]
    public string? Ritual { get; set; }

    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("concentration")]
    public string? Concentration { get; set; }

    [JsonPropertyName("casting_time")]
    public string? CastingTime { get; set; }

    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("level_int")]
    public int LevelInt { get; set; }

    [JsonPropertyName("school")]
    public string? School { get; set; }

    [JsonPropertyName("dnd_class")]
    public string? DndClass { get; set; }

    [JsonPropertyName("archetype")]
    public string? Archetype { get; set; }

    [JsonPropertyName("circles")]
    public string? Circles { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }
}