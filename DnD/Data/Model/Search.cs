using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;

internal class Search
{
    [JsonPropertyName("document_slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document_title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("route")]
    public string? Route { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("ritual")]
    public string? Ritual { get; set; }

    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("school")]
    public string? School { get; set; }

    [JsonPropertyName("dnd_class")]
    public string? DndClass { get; set; }

    [JsonPropertyName("highlighted")]
    public string? Highlighted { get; set; }
}
