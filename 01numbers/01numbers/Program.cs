using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] array = new int[5] { 8, 5, 6, 16, 5 };
            

            bool[] retsults = solution(array,1,3);
        }

        static bool[] solution(int[] numbers, int left, int right)
        {
            bool[] results = new bool[numbers.Length];
            float x = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                
                if(numbers[i] % (i + 1) == 0)
                {
                    x = numbers[i] / (i + 1);

                    if (x >= left && x <= right)
                    {
                        results[i] = true;
                    }
                }
                

            }

            return results;
        }

    }
}





