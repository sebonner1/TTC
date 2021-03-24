using System;
using System.Collections.Generic;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal(){Name = "generic"};
            Dog spot = new Dog(){Name = "Spot"};
            Cat ellen = new Cat(){Name = "Ellen"};
            
            // Creating the list
            List<Animal> animalKingdom = new List<Animal>();
            // Adding the animals to list
            animalKingdom.Add(myAnimal);
            animalKingdom.Add(spot);
            animalKingdom.Add(ellen);

            animalKingdom.Add(new Dog(){Name = "Sophie"});
            
            foreach(Animal localAnimal in animalKingdom)
            {
                localAnimal.Speak();
            }
            // Interfaces provide for us the definiton of what must be in a class that implements the interface
            // We use interfaces to build loosely coupled code
        }
    }
}
