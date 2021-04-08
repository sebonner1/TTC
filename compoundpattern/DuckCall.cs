using System;
namespace compoundpattern
{
    public class DuckCall : IQuackable
    {
        public void Quack(){
            Console.WriteLine("Kwak");
        }
    }
}