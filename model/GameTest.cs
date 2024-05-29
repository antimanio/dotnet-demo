namespace dotnet_demo;

public record class GameTest(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);