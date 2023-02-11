using DnD.Model;
using DnD.Data;

namespace Testing;

public class Program
{
    public static void Main()
    {

        var apicaller = new ApiCaller();
        apicaller.GetAndSaveDataFromApi();

        
        return;

        var campain = new Campain();

        var userDm = new Player(0, "Dm Hendrik");
        var playerFelix = new Player(1, "Player Felix");
        var playerFlander = new Player(2, "Player Flander");

        userDm.Units.Add(new Unit()
        {
             Name = "Mind Flaier",
             Description = "A octoface dude with psycic abilitys."
        });

        campain.DungeonMaster = userDm;
        campain.Players.Add(playerFelix);
        campain.Players.Add(playerFlander);
    }
}