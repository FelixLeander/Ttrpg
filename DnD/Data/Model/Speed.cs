using System.Text.Json.Serialization;

namespace DnD.Data.Model;

public class Speed
{
    [JsonPropertyName("swim")]
    public int Swim { get; set; }

    [JsonPropertyName("burrow")]
    public int Burrow { get; set; }

    [JsonPropertyName("walk")]
    public int Walk { get; set; }

    [JsonPropertyName("hover")]
    public bool? Hover { get; set; }

    [JsonPropertyName("fly")]
    public int? Fly { get; set; }

    [JsonPropertyName("climb")]
    public int? Climb { get; set; }
}
