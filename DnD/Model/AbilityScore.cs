using DnD.Interface;

namespace DnD.Model;

public class AbilityScore : IAbilityScore
{
    public CurrentMaxValue Strength { get; set; } = new();
    public int StrengthMod => CalculateMod(Strength.CurrentValue);

    public CurrentMaxValue Dexterity { get; set; } = new();
    public int DexterityMod => CalculateMod(Dexterity.CurrentValue);

    public CurrentMaxValue Constitution { get; set; } = new();
    public int ConstitutionMod => CalculateMod(Constitution.CurrentValue);

    public CurrentMaxValue Intelligence { get; set; } = new();
    public int IntelligenceMod => CalculateMod(Intelligence.CurrentValue);

    public CurrentMaxValue Wisdom { get; set; } = new();
    public int WisdomMod => CalculateMod(Wisdom.CurrentValue);

    public CurrentMaxValue Charisma { get; set; } = new();
    public int CharismaMod => CalculateMod(Charisma.CurrentValue);

    private static int CalculateMod(int abilityScore) => (int)Math.Floor((abilityScore - 10) / 2.0);
}
