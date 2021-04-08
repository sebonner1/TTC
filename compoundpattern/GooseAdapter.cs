using System;
namespace compoundpattern
{
    public class GooseAdapter : IQuackable
    {
        Goose goose;
        public GooseAdapter(Goose duck)
        {
            goose = duck;
        }
        public void Quack(){
            goose.Honk();
        }
    }
}