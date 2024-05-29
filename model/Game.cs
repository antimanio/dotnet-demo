namespace dotnet_demo;

public record class Game(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);