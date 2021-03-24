using System;

namespace baseball
{
    public class Lefty : Pitcher
    {
        public Lefty()
        {
            Throws = "Left";
            pitchBehavior = new Curveball();
        }
    }
}