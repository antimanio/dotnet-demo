namespace dotnet_demo;

public record class UpdateGame(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);