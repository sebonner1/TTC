using System;

namespace baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            Pitcher myPitcher = new Pitcher(){Name = "Greg Maddox", Team = "Braves", Throws = "Right"};
            myPitcher.pitchBehavior.Pitch();

            Pitcher craftyLefty = new Lefty(){Name = "Tom Glavin", Team = "Braves"}; // notice we don't set throws
            craftyLefty.pitchBehavior.Pitch();

            craftyLefty.SetPitchBehavior(new Slider());
            craftyLefty.pitchBehavior.Pitch();
        }
    }
}
