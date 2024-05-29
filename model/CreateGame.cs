namespace dotnet_demo;

public record class CreateGame(
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);