using System;
using System.IO;


namespace RecursiveQuickSort_String // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReadAndSort readAndSort = new ReadAndSort();

            List<string> strings = readAndSort.ReadListOfStrings("/Users/omarwasfi/Documents/GitHub/ProblemSolving/leetcode/leetcode/RecursiveQuickSort-String/1000strings.txt");

            strings = readAndSort.QuickSort(strings);

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }

        }

        
    }


}