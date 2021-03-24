using System;

namespace baseball
{
    public class Fastball : IPitch
    {
        public void Pitch()
        {
            Console.WriteLine("A 94 mph fastball has been thrown.");
        }
    }
}