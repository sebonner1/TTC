namespace AdapterNotes
{
    public class MysticVehicle
    {
        public string Name{get;set;}
        
        public void FireWeapon()
        {
            System.Console.WriteLine($"{Name} has fired a weapon.");
        }

        public void Drive()
        {
            System.Console.WriteLine($"{Name} drivers forward");
        }
    }
}