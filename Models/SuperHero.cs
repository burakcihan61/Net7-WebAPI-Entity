namespace Net7_WebAPI_Entity.Models;

public class SuperHero
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public string? SecretIdentity { get; set; } = string.Empty;
    public string? PlaceOfBirth { get; set; }  = string.Empty;
    public string? Occupation { get; set; } = string.Empty;
    public string? PlaceOfResidence { get; set; } = string.Empty;
}