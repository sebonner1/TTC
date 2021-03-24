using System;

namespace unit1review
{
    class Program
    {
        static void Main(string[] args) // weight for dogs until -1. when -1, average weight and range
        {
            string dogName = "";
            int dogWeight = 0;
            int count = 0;
            int totalWeight = 0;
            int minWeight = 500000; // We know we will have dogs smaller than this
            int maxWeight = -50; // We know we will have dogs larger than this

            dogWeight = getInfo(ref dogName);
            // dogName = getInfo();

            while(dogName.ToUpper() != "STOP")
            {
                count++;
                totalWeight+=dogWeight;
                if(dogWeight > maxWeight)
                {
                    maxWeight = dogWeight;
                }
                if(dogWeight < minWeight)
                {
                    minWeight = dogWeight;
                }
                if(dogWeight > 50)
                {
                   Console.WriteLine(dogName  + " needs to be in a cage by itself.");
                }
                // Update read
                dogWeight = getInfo(ref dogName);
                
                if(count > 0)
                {
                    Console.WriteLine("The average weight is " + (totalWeight/count));
                    Console.WriteLine("The range of weights is " + (maxWeight - minWeight));
                }
                else 
                {
                    Console.WriteLine("No dog info entered.");
                }
            }
        }
        static int getInfo(ref string dogName) // Value returning method
        {
            Console.WriteLine("Please enter dog name. Stop to quit.");
            dogName = Console.ReadLine();
            if(dogName.ToUpper() != "STOP")
            {
                Console.WriteLine("Hello, Humane Society. Please enter the weights of the dogs below. Enter -1 when you have finished and would like to exit.");
                return int.Parse(Console.ReadLine());
            }
            else 
            {
                return 0;
            }
        }
    }
}
