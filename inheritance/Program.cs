using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Dog();
            Pet emmasPet = new Rabbit();
            Cat thatCat = new Cat();
            myPet.SetName("Sophie");
            emmasPet.SetName("Gerald");
            myPet.Speak();
            emmasPet.Speak();
            thatCat.Speak();
        }
    }
}
