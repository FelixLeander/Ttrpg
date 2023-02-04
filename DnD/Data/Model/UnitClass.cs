using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;

public class UnitClass
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("hit_dice")]
    public string? HitDice { get; set; }

    [JsonPropertyName("hp_at_1st_level")]
    public string? HpAt1stLevel { get; set; }

    [JsonPropertyName("hp_at_higher_levels")]
    public string? HpAtHigherLevels { get; set; }

    [JsonPropertyName("prof_armor")]
    public string? ProfArmor { get; set; }

    [JsonPropertyName("prof_weapons")]
    public string? ProfWeapons { get; set; }

    [JsonPropertyName("prof_tools")]
    public string? ProfTools { get; set; }

    [JsonPropertyName("prof_saving_throws")]
    public string? ProfSavingThrows { get; set; }

    [JsonPropertyName("prof_skills")]
    public string? ProfSkills { get; set; }

    [JsonPropertyName("equipment")]
    public string? Equipment { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("spellcasting_ability")]
    public string? SpellcastingAbility { get; set; }

    [JsonPropertyName("subtypes_name")]
    public string? SubtypesName { get; set; }

    [JsonPropertyName("archetypes")]
    public List<Archetype> Archetypes { get; set; } = new();

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }
}

public class Archetype
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }
}
