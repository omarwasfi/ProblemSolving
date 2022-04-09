using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { 1, 2, 1, 3, 4 };
            var resuls = solution(nums);
        }

        static int[] solution(int[] numbers)
        {

            List<int> results = new List<int>();

            int currentIndex = 0;

            while(currentIndex + 2 <= numbers.Length - 1)
            {
                if (numbers[currentIndex] < numbers[currentIndex + 1] && numbers[currentIndex + 1] > numbers[currentIndex + 2])
                {
                    results.Add(1);
                }

                else if (numbers[currentIndex] > numbers[currentIndex + 1] && numbers[currentIndex + 1] < numbers[currentIndex + 2])
                {
                    results.Add(1);
                }
                else
                {
                    results.Add(0);

                }

                currentIndex++;
            }


            return results.ToArray();

        }

        
    }



}