using System;

namespace inheritance
{
    public class Pet
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void Speak()
        {
            Console.WriteLine("Not implemented");
        }
    }
}