using dotnet_demo.Entites;
using Microsoft.EntityFrameworkCore;

namespace dotnet_demo.DataContext;

/*
 Brigde Between Entities and Database
*/
public class DataDbContext : DbContext
{
    
    private readonly IConfiguration configuration;

    //Database Context know we have two tables by using DbSet 
    public DbSet<Person> Persons { get; set;}

    public DbSet<Adress> Adresses { get; set;}
    
    //Construction Injection (DI)
    public DataDbContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("dotnetDemo"),  x => x.MigrationsHistoryTable("__EFMigrationsHistory", "demo"));
    }


}
