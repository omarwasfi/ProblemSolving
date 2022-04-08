using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] arr = { "Daisy", "Rose", "Hyacinth", "Poppy" };

            string results = solution(arr);
        }

        static string solution(string[] arr)
        {
            string word = "";
            int theBigstLength = 0;
            foreach (string w in arr)
            {
                if (w.Length > theBigstLength)
                {
                    theBigstLength = w.Length;
                }
            }

            for(int i = 0; i < theBigstLength; i++)
            {
                for(int y = 0; y< arr.Length; y++)
                {
                    if(arr[y].Length - 1 >= i)
                    {
                        word += arr[y][i];

                    }
                }

            }

            return word;

        }
    }
}