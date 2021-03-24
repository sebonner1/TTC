namespace AdapterNotes
{
    public class CharacterVehicleAdapter : ICharacter
    {
        public MysticVehicle MyVehicle;

        public void CharacterVehicleAdapter(MysticVehicle myVehicle)
        {
            MyVehicle = myVehicle;
        }

        public void CastSpell()
        {
            myVehicle.FireWeapon();
        }

        public void Walk()
        {
            myVehicle.Drive();
        }
        // watch decorator and javascript for next class
    }
}