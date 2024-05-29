
using System.Net.Sockets;

namespace dotnet_demo.Entites;

public class Person
{
  public int Id {get; set;}

  public required string Name {get; set;}

  public List<Adress> Adresses {get; set;}

}
