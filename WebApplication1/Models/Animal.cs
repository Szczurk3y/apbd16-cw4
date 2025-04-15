namespace WebApplication1.Models;

public class Animal
{
    public int  Id { get; set; }
    public string Name { get; set; }
    public AnimalCategory Category { get; set; }
    public double Weight { get; set; }
    public string Color { get; set; }
}

public enum AnimalCategory
{
    CAT, DOG, HEDGEHOG, RABBIT
}