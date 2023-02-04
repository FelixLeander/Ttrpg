using System.Text.Json.Serialization;

namespace DnD.Data.Model;

public class SpecialAbility
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }
}