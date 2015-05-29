using System;
namespace AnimalInterface.Animals
{
    public interface IAnimals
    {
        string MakeSound();
        string Name { get; set; }
    }
}
