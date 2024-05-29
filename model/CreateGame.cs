using System.ComponentModel.DataAnnotations;

namespace dotnet_demo;

public record class CreateGame(
   [Required][StringLength(50)] string Name,
   [Required][StringLength(20)] string Genre,
   [Range(1,100)] decimal Price,
   DateOnly ReleaseDate
);