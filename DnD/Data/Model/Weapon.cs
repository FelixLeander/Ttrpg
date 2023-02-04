using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;

internal class Weapon
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }

    [JsonPropertyName("cost")]
    public string? Cost { get; set; }

    [JsonPropertyName("damage_dice")]
    public string? DamageDice { get; set; }

    [JsonPropertyName("damage_type")]
    public string? DamageType { get; set; }

    [JsonPropertyName("weight")]
    public string? Weight { get; set; }

    [JsonPropertyName("properties")]
    public List<string> Properties { get; set; } = new();
}
