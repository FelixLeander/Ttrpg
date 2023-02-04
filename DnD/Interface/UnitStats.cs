using DnD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Interface;

public interface ICharacterSheet
{
    public CurrentMaxValue Inspiration { get; set; }
    public CurrentMaxValue ProficentyBonus { get; set; }
    public Array[] SavingThrows { get; set; }
    public CurrentMaxValue PassiveWisedomPerception { get; set; }

    public CurrentMaxValue ArmorClass { get; set; }
    public CurrentMaxValue HitPointMax { get; set; }
    public CurrentMaxValue HitPoints { get; set; }
    public CurrentMaxValue Speed { get; set; }
    public CurrentMaxValue HitDiceAmount { get; set; }
    public CurrentMaxValue HitDiceRange { get; set; }

    public CurrentMaxValue TemporaryHitPoints { get; set; }
}
