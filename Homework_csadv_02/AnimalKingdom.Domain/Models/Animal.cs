using AnimalKingdom.Domain.Interfaces;

namespace AnimalKingdom.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Animal(string breed, string color, int age)
        {
            Breed = breed;
            Color = color;
            Age = age;

        }

        public Animal()
        {
        }

        public abstract void PrintAnimal();
    }

}
