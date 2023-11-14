namespace Net7_WebAPI_Entity.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Author { get; set; } = string.Empty;
    public string? Genre { get; set; } = string.Empty;
    public string? Publisher { get; set; } = string.Empty;
    public string? Language { get; set; } = string.Empty;
    public int? Pages { get; set; } = 0;
    public int? Year { get; set; } = 0;
    public string? Description { get; set; } = string.Empty;
}
