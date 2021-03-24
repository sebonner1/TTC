using System;
using System.IO;

namespace TAsSec2
{
    class Program
    {
        static void Main(string[] args)
        {
            PAGrader kera = new PAGrader(){Name = "Kera"};

            kera.Grade();
            kera.WorkOfficeHours();

            // TA kera = new TA(){Name = "Kera"};

            // kera.GradeBehavior.Grading("multiple choice");
            // kera.GradeBehavior = new MultipleChoiceGrading();
            // kera.GradeBehavior.Grading();
        }
    }
}
