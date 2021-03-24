using System;

namespace unit2notes
{
    class Program
    {
        static void Main(string[] args)
        {
        const int ARRAY_SIZE = 100;
        int count = 0;
        string[] names = new string[ARRAY_SIZE]; // parallel arrays!
        int[] grades = new int[ARRAY_SIZE];
        count = GetGrades(names,grades);
        PrintAllGrades(names,grades,count);
        UpdateUserGrade(names, grades, count);


        } 

        static void UpdateUserGrade(string[] names, int[] grades, int count)
        {
            Console.WriteLine("Enter name of student to update");
            string searchValue = Console.ReadLine();
            int foundIndex = SearchArray(names, count, searchValue);
            if(foundIndex == -1)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                UpdateGrade(grades, foundIndex, names[foundIndex]);
            }
        }
        
        static void UpdateGrade(int[] grades, int foundIndex, string studentName)
        {
            Console.WriteLine($"What would you like to update {studentName} to");
            grades[foundIndex] = int.Parse(Console.ReadLine());
        }


        static int SearchArray(string[] myArray, int count, string searchValue)
        {
            int foundIndex = -1;
            int currentIndex = 0;
            bool found = false;
            while(! found && currentIndex < count)
            {
                if(myArray[currentIndex].ToUpper() == searchValue.ToUpper())
                {
                    foundIndex = currentIndex;
                    found = true;
                }
                else
                {
                    currentIndex++;
                }
            }
            return foundIndex;
        }

        static string GetGrade(ref int grade)
        {
            Console.WriteLine("Enter name or stop to quit");
            string name = Console.ReadLine();
            if(name.ToUpper() != "STOP")
            {
                Console.WriteLine("Enter grade");
                grade = int.Parse(Console.ReadLine());
            }
            return name;
        }

        static int GetGrades(string[] names, int[] grades)
        {
            int count = 0;
            int grade = -1;
            string name = GetGrade(ref grade);
            while(name.ToUpper() != "STOP" && count < 100)
            {
                grades[count] = grade;
                names[count] = name;
                count++;
                name = GetGrade(ref grade);
            }
            return count;
        }
        static void PrintAllGrades(string[] names, int[] grades, int count)
        {
            for(int i = 0; i<count; i++){
                Console.WriteLine($"{names[i]} made a {grades[i]}");
            }
        }
    }
}
