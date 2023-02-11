using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DnD.Data.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json;
using System.Reflection.Metadata.Ecma335;
using DnD.Constant;

namespace DnD.Data;

public class ApiCaller
{
    private RestClient RestClient { get; set; }
    public ApiCaller()
    {
        RestClient = new RestClient(MetaInfo.OpenFithEditonApiUrl);
        RestClient.AddDefaultParameter("format", "json");
        RestClient.AddDefaultParameter("limit", "0");
    }

    public string GetAndSaveDataFromApi()
    {
        var classes = new List<(Type, string)>
        {
            (typeof(Spell), "spells"),
            (typeof(Monster), "monsters"),
            (typeof(Document), "documents"),
            (typeof(Background), "backgrounds"),
            (typeof(Plane), "planes"),
            (typeof(Section), "sections"),
            (typeof(Feat), "feats"),
            (typeof(Condition), "conditions"),
            (typeof(Race), "races"),
            (typeof(UnitClass), "classes"),
            (typeof(MagicItem), "magicitems"),
            (typeof(Weapon), "weapons"),
            (typeof(Armor), "armor")
            //(typeof(Search), "/search")
        };

        foreach (var (type, route) in classes)
        {
            var method = this.GetType()
                .GetMethod("CallClass");

            if (method == null)
                continue;

            method.MakeGenericMethod(type)
                .Invoke(this, new[] { route });
        }

        return Environment.CurrentDirectory;
    }

    private List<T> GetDataFromApi<T>(string route)
    {
        var request = new RestRequest(route);
        var value = RestClient.Get<TypeHolder<T>>(request);
        return value?.Results ?? throw new Exception("BAD");
    }

    public void CallClass<T>(string route) where T : class
    {
        var listValues = GetDataFromApi<T>($"/{route}");
        var json = JsonConvert.SerializeObject(listValues);
        File.WriteAllText(Path.Combine(Environment.CurrentDirectory, $"{route}.json"), json);
    }
}
