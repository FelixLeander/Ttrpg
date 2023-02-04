namespace DnD.Model;

public class CurrentMaxValue
{
    public int CurrentValue { get; set; }
    public int MaxValue { get; set; }

    public CurrentMaxValue()
    {
        CurrentValue= 0;
        MaxValue= 0;
    }
    public CurrentMaxValue(int value, int maxValue)
    {
        CurrentValue = value;
        MaxValue = maxValue;
    }

    public int MaxValueGetDifference()
    {
        int difference = MaxValue- CurrentValue;
        CurrentValue = MaxValue;
        return difference;
    }
}
