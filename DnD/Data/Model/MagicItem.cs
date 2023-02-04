using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;

internal class MagicItem
{
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("desc")]
    public string? Description { get; set; }

    [JsonPropertyName("rarity")]
    public string? Rarity { get; set; }

    [JsonPropertyName("requires_attunement")]
    public string? RequiresAttunement { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }
}