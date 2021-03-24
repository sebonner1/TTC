using System;
using System.IO;

namespace filesnotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[50];
            string[] breed = new string[50];
            int[] weight = new int[50];

            int count = GetAllDogs(names, breed, weight); // When you pass, it has already been declared in the method.
            PrintAllDogs(names, breed, weight, count);
            weight[2] = 65;
            PrintAllDogs(names, breed, weight, count);
            SaveAllDogs(names, breed, weight, count);
        }
        // it doesn't exist here in GetAllDogs. She's declaring it locally with the string[] and int[]
        public static int GetAllDogs(string[] names, string[] breed, int[] weight) // It is defined as an integer because we are sending back count
        {
            // EXAM QUESTION - OPEN, PROCESS, AND CLOSE THE FILE
            // open
            StreamReader inFile = new StreamReader("input.txt");
            
            // process
            int count = 0;
            string dataRow = inFile.ReadLine(); // priming read
            while(dataRow != null)
            {
                string[] temp = dataRow.Split('#');
                names[count] = temp[0];
                breed[count] = temp[1];
                weight[count] = int.Parse(temp[2]);
                count++;

                // update read
                dataRow = inFile.ReadLine();
            }
            // close
            inFile.Close();

            return count;
        }

        public static void PrintAllDogs(string[] names, string[] breed, int[] weight, int count)
        {
            for(int i = 0; i<count; i++)
            {
                Console.WriteLine($"{names[i]} is a {breed[i]} and weighs {weight[i]}");
            }
        }

        public static void SaveAllDogs(string[] names, string[] breed, int[] weight, int count)
        {
            StreamWriter outFiles = new StreamWriter("input.txt");
            
            // process
            for(int i = 0; i<count; i++)
            {
                Console.WriteLine($"{names[i]}#{breed[i]}#{weight[i]}"); 
            }

            // close
            outFiles.WriteLine();
        }

    }
}
