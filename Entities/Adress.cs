namespace dotnet_demo.Entites;

public class Adress
{

    public int Id {get; set;}

    public int PersonId {get; set;}

    public string Adress1 {get; set;}

    public string Adress2 {get; set;}

    public string City {get; set;}
    
    public Person person {get; set;}
}
