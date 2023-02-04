using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;

internal class Plane
{
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("document__slug")]
    public string? DocumentSlug { get; set; }

    [JsonPropertyName("document__title")]
    public string? DocumentTitle { get; set; }

    public Plane(string slug, string name, string desc, string documentSlug, string documentTitle)
    {
        Slug = slug;
        Name = name;
        Desc = desc;
        DocumentSlug = documentSlug;
        DocumentTitle = documentTitle;
    }

    public static Plane CreateInstanceMaterialPlane()
    {
        return new Plane(
            "the-material-plane",
            "The Material Plane",
            "The Material Plane is the nexus where the philosophical and elemental forces that define the other planes collide in the jumbled existence of mortal life and mundane matter. All fantasy gaming worlds exist within the Material Plane, making it the starting point for most campaigns and adventures. The rest of the multiverse is defined in relation to the Material Plane.\nThe worlds of the Material Plane are infinitely diverse, for they reflect the creative imagination of the GMs who set their games there, as well as the players whose heroes adventure there. They include magic-wasted desert planets and island-dotted water worlds, worlds where magic combines with advanced technology and others trapped in an endless Stone Age, worlds where the gods walk and places they have abandoned.",
            "wotc-srd",
            "Systems Reference Document");
    }
}
