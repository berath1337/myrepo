using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalKingdom.Domain.Interfaces;

namespace AnimalKingdom.Domain.Models;
   

    public class Cat : Animal, ICat
{
    public Cat(string breed, string color, int age) : base(breed, color, age)
    {

    }

    public override void PrintAnimal()
    {
        
    }

    void ICat.Eat(string food)
    {
      
    }
}


