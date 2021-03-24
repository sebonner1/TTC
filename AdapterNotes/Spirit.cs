namespace AdapterNotes
{
    public class Spirit
    {
        public string Name{get;set;}

        public void CastSpell()
        {
            System.Console.WriteLine($"{Name} has cast a spell");
        }
    }
}