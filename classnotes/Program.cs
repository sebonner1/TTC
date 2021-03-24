using System;

namespace classnotes // must match
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle box = new Rectangle();
            // box.SetLength(5,5);
            // box.SetWidth(4,3);

            // Console.WriteLine(box.GetArea());

            // Rectangle myBox = new Rectangle();
            // myBox.SetLength(5.0);
            // myBox.SetWidth(5.0);

            // Console.WriteLine(myBox.GetArea());
            // Console.WriteLine(box.GetArea());

            Rectangle kitchen = new Rectangle();
            kitchen.SetWidth(10);
            kitchen.SetLength(10);
            Rectangle.SetCount(1);

            Rectangle den = new Rectangle();
            den.SetWidth(9);
            den.SetLength(8);
            Rectangle.SetCount(2);

            Rectangle bedroom = new Rectangle(10,9);
            Rectangle.SetCount(Rectangle.GetCount()+1);

            PrintLayout(bedroom);
            Console.WriteLine(bedroom.GetLength()); // Passing by value but the value is the memory location; acts like it was passed by reference

        }

        public static void PrintLayout(Rectangle myRoom)
        {
            myRoom.SetLength(15);
            Console.WriteLine($"The room is {myRoom.GetLegth()} by {myRoom.GetWidth()}");
        }
    }
}
