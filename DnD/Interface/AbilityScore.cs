using DnD.Model;

namespace DnD.Interface;

public interface IAbilityScore
{
    public CurrentMaxValue Strength { get; set; }
    public int StrengthMod { get; }

    public CurrentMaxValue Dexterity { get; set; }
    public int DexterityMod { get; }

    public CurrentMaxValue Constitution { get; set; }
    public int ConstitutionMod { get; }

    public CurrentMaxValue Intelligence { get; set; }
    public int IntelligenceMod { get; }

    public CurrentMaxValue Wisdom { get; set; }
    public int WisdomMod { get; }

    public CurrentMaxValue Charisma { get; set; }
    public int CharismaMod { get; }
}