using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.ModelBase;

public class Die
{
    public int Range { get; set; }
    public int Result { get; set; }

    public Die(int range, int result)
    {
        Range = range;
        Result = result;
    }
}
