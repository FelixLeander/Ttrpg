using System.Text.Json.Serialization;

namespace DnD.Data.Model;

public class Skills
{
    [JsonPropertyName("athletics")]
    public int Athletics { get; set; }

    [JsonPropertyName("perception")]
    public int Perception { get; set; }

    [JsonPropertyName("stealth")]
    public int Stealth { get; set; }

    [JsonPropertyName("intimidation")]
    public int? Intimidation { get; set; }

    [JsonPropertyName("history")]
    public int? History { get; set; }

    [JsonPropertyName("deception")]
    public int? Deception { get; set; }

    [JsonPropertyName("performance")]
    public int? Performance { get; set; }

    [JsonPropertyName("persuasion")]
    public int? Persuasion { get; set; }

    [JsonPropertyName("medicine")]
    public int? Medicine { get; set; }

    [JsonPropertyName("religion")]
    public int? Religion { get; set; }

    [JsonPropertyName("insight")]
    public int? Insight { get; set; }

    [JsonPropertyName("arcana")]
    public int? Arcana { get; set; }

    [JsonPropertyName("nature")]
    public int? Nature { get; set; }

    [JsonPropertyName("acrobatics")]
    public int? Acrobatics { get; set; }

    [JsonPropertyName("survival")]
    public int? Survival { get; set; }

    [JsonPropertyName("investigation")]
    public int? Investigation { get; set; }
}
