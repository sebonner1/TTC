using System;
namespace baseball
{
    public class Curveball : IPitch
    {
        public void Pitch()
        {
            Console.WriteLine("An 80 mph curveball has been thrown.");
        }
    }
}