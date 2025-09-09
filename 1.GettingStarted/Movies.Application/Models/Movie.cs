namespace Movies.Application.Models;

    public class Movie
{
    public required Guid Id { get; init; }
    public required string Title { get; set; } // here we use set; to allow modification of the title during runtime
    public required int ReleaseYear { get; set; } // here we use set; to allow modification of the release year during runtime
    public required List<string> Genres { get; init; } = new(); // here we use init; so the list is the same instance during runtime, but said instance can be modified since it`s a list
} 
