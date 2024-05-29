
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace dotnet_demo.Entites;
[Table("person", Schema ="demo")]
public class Person
{
  [Column("person_id")]
  public required int PersonId {get; set;}

  [Column("name")]
  [MaxLength(100)]
  public required string Name {get; set;}
  
  [Column("date_birth")]
  public required DateOnly DateBirth {get; set;} 
  public required List<Adress> Adresses {get; set;}

}
