using DnD.Model;
using DnD.Data;

namespace Testing;

public class Program
{
    public static void Main()
    {

        var apicaller = new ApiCaller(@"https://api.open5e.com/");
        //apicaller.DownloadData();
        apicaller.GetAndSaveDataFromApi();

        /*
        var baseUri = new Uri(@"https://api.open5e.com/");
        var api = new OpenFiveApi(baseUri);

        await api.DownloadFiles();
        */

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