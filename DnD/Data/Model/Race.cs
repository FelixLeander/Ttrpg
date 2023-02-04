using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;

public class Asi
{
    [JsonPropertyName("attributes")]
    public List<string> Attributes { get; set; } = new();

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Race
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("asi_desc")]
    public string? AsiDesc { get; set; }

    [JsonPropertyName("asi")]
    public List<Asi> Asi { get; set; } = new();

    [JsonPropertyName("age")]
    public string? Age { get; set; }

    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("speed")]
    public Speed Speed { get; set; }

    [JsonPropertyName("speed_desc")]
    public string? SpeedDesc { get; set; }

    [JsonPropertyName("languages")]
    public string? Languages { get; set; }

    [JsonPropertyName("vision")]
    public string? Vision { get; set; }

    [JsonPropertyName("traits")]
    public string? Traits { get; set; }

    [JsonPropertyName("subraces")]
    public List<Subrace> Subraces { get; set; } = new();

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }
}

public class Speed
{
    [JsonPropertyName("walk")]
    public int Walk { get; set; }
}

public class Subrace
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("asi")]
    public List<Asi> Asi { get; set; } = new();

    [JsonPropertyName("traits")]
    public string? Traits { get; set; }

    [JsonPropertyName("asi_desc")]
    public string? AsiDesc { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }
}