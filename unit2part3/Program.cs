using System;

namespace unit2part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myArray = {10, 3, 17, 25, 14, 100};
            int count = 6;
            int searchValue = 17;
            // int Index = Search(myArray, count, searchValue);
            // Console.WriteLine(index);
            Sort(myArray, count);
            for(int i = 0; i < count; i++){
                Console.WriteLine(myArray[i]);
            }
        }
        static int Search(int[] myArray, int count, int searchValue)
        {
            int foundIndex = -1;
            for(int i = 0; i < count; i++)
            {
                if(myArray[i] == searchValue)
                {
                    foundIndex = i;
                }
            }
            return foundIndex;
        }

        static int Sort(int[] myArray, int count, int searchValue)
        {
            for(int i = 0; i < count; i++) // EXAM - know that you start the outer loop with the second to last number!!
            {
                int minIndex = i;
                for(int j=i+1; j < count; j++) 
                {
                    if(myArray[j] < myArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if(minIndex != 1) 
                {
                    Swap(myArray, minIndex, i);
                }
            }
        }

        static int Swap(int[] myArray, int x, int y)
        {
            int temp = myArray[x];
            myArray[x] = myArray[y];
            myArray[y] = temp;
        }

        BinarySearch(int[] MyArray, int count, int searchValue)
        {
            int foundIndex = -1;
            int first = 0;
            int last = count-1;
            int middle;
            bool found = false;

            while(! found && first <= last) 
            {
                middle = (first+last) / 2;
                if(salaries[middle] == searchValue)
                {
                    found = true;
                    foundIndex = middle;
                }
                else 
                {
                    if(salaries[middle] > searchValue)
                    {
                        last = middle-1;
                    }
                    else
                    {
                        first = middle+1;
                    }
                }
            }
        }
        
        /*
        string myString = "Emma Bell";
        string compareString = "";
        for(int i = myString.Length-1; i >= 0; i--)
        {
            compareString+=myString[i];
        }
        Console.Write(myString[i]);
        Console.WriteLine(compString);
        */

    }
}
