using WebApplication1.Models;

namespace WebApplication1;

public static class Database
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal() { Id = 1, Name = "Test kot 1", Category = AnimalCategory.CAT, Weight = 5, Color = "Red" },
        new Animal() { Id = 2, Name = "Test pies ", Category = AnimalCategory.DOG, Weight = 30, Color = "Brown" },
        new Animal() { Id = 3, Name = "Test jeż 1", Category = AnimalCategory.HEDGEHOG, Weight = .100, Color = "blue" },
        new Animal() { Id = 4, Name = "Test królik 1", Category = AnimalCategory.RABBIT,  Weight = 1, Color = "green" },
        new Animal() { Id = 5, Name = "Test kot 2", Category = AnimalCategory.CAT, Weight = 4.5, Color = "Red" },
        new Animal() { Id = 6, Name = "Test pies 2", Category = AnimalCategory.DOG, Weight = 25, Color = "Brown" },
        new Animal() { Id = 7, Name = "Test jeż 2", Category = AnimalCategory.HEDGEHOG, Weight = .50, Color = "blue" },
        new Animal() { Id = 8, Name = "Test królik 2", Category = AnimalCategory.RABBIT,  Weight = .75, Color = "green" },
    };

    public static List<Schedule> Schedules = new List<Schedule>()
    {
        new Schedule() { Date = "15.04.2025", AnimalId = Animals[0].Id, Description = "Wizyta kontrolna", Price = 123.45 },
        new Schedule() { Date = "15.04.2025", AnimalId = Animals[1].Id, Description = "Pobieranie krwi", Price = 678 },
        new Schedule() { Date = "15.04.2025", AnimalId = Animals[2].Id, Description = "Usuwanie kamienia", Price = 45.89 },
        new Schedule() { Date = "15.04.2025", AnimalId = Animals[3].Id, Description = "Usg jamy brzusznej", Price = 119.10 }
    };
}