using System;
namespace baseball
{
    public class Pitcher
    {
        public string Name {get; set;}
        public string Team {get; set;}
        public string Throws {get; set;}

        public IPitch pitchBehavior;

        public Pitcher()
        {
            pitchBehavior = new Fastball();
        }

        public void SetPitchBehavior(IPitch pitch)
        {
            pitchBehavior = pitch;
        }
    }
}