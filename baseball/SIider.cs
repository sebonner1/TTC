using System;
namespace baseball
{
    public class Slider : IPitch
    {
        public void Pitch()
        {
            Console.WriteLine("An 88 mph slider has been thrown.");
        }
    }
}