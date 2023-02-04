using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Model;

public class Campain
{
    public int Id { get; set; }
    public Player? DungeonMaster { get; set; }
    public List<Player> Players { get; set; } = new();
}
