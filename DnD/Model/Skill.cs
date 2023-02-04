using DnD.Enumberable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Model;

public sealed class Skill
{
    public Skills Name { get; set; }
    public bool IsProficent { get; set; }
    public bool RelatedAbilityScore { get; set; }
}