using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;


public class Monster
{
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }

    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    [JsonPropertyName("armor_class")]
    public int ArmorClass { get; set; }

    [JsonPropertyName("armor_desc")]
    public string? ArmorDesc { get; set; }

    [JsonPropertyName("hit_points")]
    public int HitPoints { get; set; }

    [JsonPropertyName("hit_dice")]
    public string? HitDice { get; set; }

    [JsonPropertyName("speed")]
    public Speed? Speed { get; set; }

    [JsonPropertyName("strength")]
    public int Strength { get; set; }

    [JsonPropertyName("dexterity")]
    public int Dexterity { get; set; }

    [JsonPropertyName("constitution")]
    public int Constitution { get; set; }

    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }

    [JsonPropertyName("wisdom")]
    public int Wisdom { get; set; }

    [JsonPropertyName("charisma")]
    public int Charisma { get; set; }

    [JsonPropertyName("strength_save")]
    public int? StrengthSave { get; set; }

    [JsonPropertyName("dexterity_save")]
    public int? DexteritySave { get; set; }

    [JsonPropertyName("constitution_save")]
    public int? ConstitutionSave { get; set; }

    [JsonPropertyName("intelligence_save")]
    public int? IntelligenceSave { get; set; }

    [JsonPropertyName("wisdom_save")]
    public int? WisdomSave { get; set; }

    [JsonPropertyName("charisma_save")]
    public int? CharismaSave { get; set; }

    [JsonPropertyName("perception")]
    public int? Perception { get; set; }

    [JsonPropertyName("skills")]
    public Skills? Skills { get; set; }

    [JsonPropertyName("damage_vulnerabilities")]
    public string? DamageVulnerabilities { get; set; }

    [JsonPropertyName("damage_resistances")]
    public string? DamageResistances { get; set; }

    [JsonPropertyName("damage_immunities")]
    public string? DamageImmunities { get; set; }

    [JsonPropertyName("condition_immunities")]
    public string? ConditionImmunities { get; set; }

    [JsonPropertyName("senses")]
    public string? Senses { get; set; }

    [JsonPropertyName("languages")]
    public string? Languages { get; set; }

    [JsonPropertyName("challenge_rating")]
    public string? ChallengeRating { get; set; }

    [JsonPropertyName("actions")]
    public List<Action> Actions { get; set; } = new();

    [JsonPropertyName("reactions")]
    public object Reactions { get; set; }

    [JsonPropertyName("legendary_desc")]
    public string? LegendaryDesc { get; set; }

    [JsonPropertyName("legendary_actions")]
    public object LegendaryActions { get; set; }

    [JsonPropertyName("special_abilities")]
    public List<SpecialAbility?> SpecialAbilities { get; set; } = new();

    [JsonPropertyName("spell_list")]
    public List<string?> SpellList { get; set; } = new();

    [JsonPropertyName("img_main")]
    public string? ImgMain { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }
}