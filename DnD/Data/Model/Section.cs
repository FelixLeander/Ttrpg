using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DnD.Data.Model;

internal class Section
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

    [JsonPropertyName("document__license_url")]
    public string? DocumentLicenseUrl { get; set; }

    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
}
