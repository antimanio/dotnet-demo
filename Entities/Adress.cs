using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_demo.Entites;

[Table("address", Schema ="demo")]
public class Adress
{
    [Column("id")]
    public required int Id {get; set;}

    [Column("person_id")]
    public required int PersonId {get; set;}

    [Column("Address1")]
    [MaxLength(100)]
    public required string Address1 {get; set;}

    [Column("Address2")]
    [MaxLength(100)]
    public string? Address2 {get; set;}

    [Column("City")]
    [MaxLength(100)]
    public required string City {get; set;}
    
    public required Person person {get; set;}
}
