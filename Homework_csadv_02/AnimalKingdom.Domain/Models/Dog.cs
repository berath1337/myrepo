using AnimalKingdom.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Domain.Models
{
    public class Dog : Animal, IDog
{
        public Dog(string breed, string color, int age) : base(breed, color, age)
        {
            
        }


        public override void PrintAnimal()
    {
       
    }

    public void Bark()
    {
        
    }
}
}
