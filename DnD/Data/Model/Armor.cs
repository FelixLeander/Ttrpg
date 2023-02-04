namespace DnD.Data.Model;

public class Armor
{
    public string? Name { get; set; }
    public string? Slug { get; set; }
    public string? Category { get; set; }
    public string? DocumentSlug { get; set; }
    public string? DocumentTitle { get; set; }
    public string? DocumentLicenseUrl { get; set; }
    public string? AcString { get; set; }
    public int? StrengthRequirement { get; set; }
    public string? Cost { get; set; }
    public string? Weight { get; set; }
    public bool StealthDisadvantage { get; set; }
}