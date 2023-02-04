using DnD.Enumberable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Model;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Unit> Units { get; set; } = new();

    public Player(int id, string name)
    {
        Id = id;
        Name = name;
    }

}