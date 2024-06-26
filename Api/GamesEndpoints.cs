﻿namespace dotnet_demo;

public static class GamesEndpoints
{

    const string GetGameEndpointName = "GetGame";

    private static readonly List<GameTest> games = [
        new GameTest(1, "The Legend of Zeldar", "Adventure", 59.99m, new DateOnly(2021, 11, 12)),
        new GameTest(2, "Space Invaders", "Arcade", 14.99m, new DateOnly(1978, 6, 19)),
        new GameTest(3, "Cyber Fighter 2077", "Action", 49.99m, new DateOnly(2020, 12, 10))
    ];

    public static RouteGroupBuilder MapGamesEndPoints(this WebApplication app) {

    var group = app.MapGroup("games");
        
    group.MapGet("/", () => games);

    group.MapGet("/{id}", (int id) =>
    {
        GameTest? game = games.Find(x => x.Id == id);
        return game is null ? Results.NotFound() : Results.Ok(game);
    })
    .WithName(GetGameEndpointName);

    group.MapPost("/", (CreateGame newGame) => {
        GameTest game = new GameTest(games.Count + 1,  newGame.Name, newGame.Genre, newGame.Price, newGame.ReleaseDate);
        games.Add(game);
        return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id}, game);
    })
    .WithParameterValidation();

    group.MapPut("/{id}", (int id, UpdateGame updateGame) => {
        int index = games.FindIndex(x => x.Id == id);
        if(index == -1) {
            return Results.NotFound();
        }
        games[index] = new GameTest(id, updateGame.Name, updateGame.Genre, updateGame.Price, updateGame.ReleaseDate);
        return Results.Ok(games[index]);
    })
    .WithParameterValidation();


    group.MapDelete("/{id}", (int id) =>
    {
        games.RemoveAll(x => x.Id == id);
        return Results.NoContent();
    });

    return group;

    }
}
