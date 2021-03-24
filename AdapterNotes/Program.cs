using System;

namespace AdapterNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Spirit mySpirit = new Spirit(){Name = "Ailen"};
            mySpirit.CastSpell();

            ICharacter myVehicle = new CharacterVehicleAdapter(new MysticVehicle(){Name = "Mongoose"});
            myVehicle.CastSpell();
            myVehicle.Walk();
            mySpirit.Walk();
        }
    }
}
