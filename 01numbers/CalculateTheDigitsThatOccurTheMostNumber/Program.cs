using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[] { 5,445,78,32,11,44,11,66,57,57 };

            var results = solution(numbers);
        }

        static int[] solution(int[] a)
        {

            int[] degitCount = new int[10];


            foreach(int num in a)
            {
                string n = num.ToString();
                foreach(char c in n)
                {
                    int intergerValue = int.Parse(c.ToString());
                    degitCount[intergerValue]++;
                   
                }
            }

            int max = degitCount.Max();

            int count = 0;

            foreach(int i in degitCount)
            {
                if(i == max)
                {
                    count++;
                }

            }

            int[] results = new int[count];


            for (int j = 0; j < count; j++)
            {
                foreach (int i in degitCount)
                {
                    if (i == max)
                    {
                        results[j] = i;
                    }
                }


            }




            return results;

        }

    }
}