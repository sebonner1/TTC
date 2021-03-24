using System;

namespace unit2notespart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] salaries = new double[100];
            int count = GetSalaries(salaries);
            PrintAllSalaries(salaries, count);
            SelectionSort(salaries, count);
            Console.WriteLine();
            Console.WriteLine("After the sort");
            PrintAllSalaries(salaries, count);
            int index = BinarySearch(salaries, count, 30); // pass value we are searching for at end
            Console.WriteLine(index);
        } 
        static int GetSalaries(double[] salaries){
            int count = 0;
            double salary = GetSalary(); // priming read

            while(salary != -1)
            {
                salaries[count] = salary;
                count++;
                salary = GetSalary(); // update read
            }

            return count;
        }

        static double GetSalary()
        {
            Console.WriteLine("Enter a salary amount. -1 to stop.");
            return double.Parse(Console.ReadLine());
        }

        static void PrintAllSalaries(double[] salaries, int count)
        {
            for(int i = 0; i < count; i++) {
                Console.WriteLine(salaries[i]);
            }
        }

        static void SelectionSort(double[] salaries, int count)
        {
            // find all salaries that combine to be more than 50K
            // write out subscripts
            for(int i = 0; i < count - 1; i++){
                int minIndex = i;
                for(int j = i+1; j<count; j++){
                    if(salaries[j] < salaries[minIndex]){
                        minIndex = j;
                    }
                }
                if(minIndex != i){
                    Swap(salaries, i, minIndex);
                }
            }    
        }

        static void Swap(double[] salaries, int x, int y){
            double temp = salaries[x];
            salaries[x] = salaries[y];
            salaries[y] = temp;
        }
        static int BinarySearch(double[] salaries, int count, double searchValue)
        {
            int foundIndex = -1; // if we don't find it, we return -1
            int first = 0;
            int last = count-1;
            int middle;
            bool found = false;

            while(!found && first <= last) // until we find it and first crosses over last, we calculate the middle
            {
                middle = (first + last) / 2; // calculate middle

                if(salaries[middle] == searchValue)
                {
                    found = true; // if middle is correct
                    foundIndex = middle;
                }
                else // if middle was not the number
                {
                    if(salaries[middle] > searchValue) // too high or too low? cut off halk of the array each time
                    {
                        last = middle-1;
                    }
                    else{
                        first = middle + 1;
                    }
                }
            }
            
            return foundIndex; // return the index
        }
    }
}