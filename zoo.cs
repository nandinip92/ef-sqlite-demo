using Microsoft.EntityFrameworkCore;
using ZooManagement.Enums;
using ZooManagement.Models.Data;

namespace ZooManagement;

public class Zoo : DbContext
{
    public DbSet<Animal> Animals { get; set; } = null!;
    public DbSet<Species> Species { get; set; } = null!;
    protected readonly IConfiguration Configuration;

    public Zoo(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(Configuration.GetConnectionString("ZooApiDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var lion = new Species
        {
            Id = -1,
            Name = "lion",
            Classification = Classification.Mammal,
        };

        modelBuilder.Entity<Species>().HasData(lion);

        var simba = new Animal
        {
            Id = -1,
            Name = "simba",
            SpeciesId = -1,
            Sex = Sex.Male,
            DateOfBirth = new DateTime(1997, 10, 16).ToUniversalTime(),
            DateOfAcquisition = new DateTime(2000, 1, 1).ToUniversalTime(),
        };
        var nala = new Animal
        {
            Id = -2,
            Name = "nala",
            SpeciesId = -1,
            Sex = Sex.Female,
            DateOfBirth = new DateTime(1997, 9, 10).ToUniversalTime(),
            DateOfAcquisition = new DateTime(2001, 2, 3).ToUniversalTime(),
        };

        modelBuilder.Entity<Animal>().HasData(simba, nala);
    }
}

