using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(OptSolution.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2,2001,2002,2003,2004,2005,2006 }));


        }
    }
    public static class Solution
    {
        public static int LongestConsecutive(int[] nums)
        {
            nums = nums.OrderBy(x => x).ToArray();

            List<int> countOfSequences = new List<int>();
            int counter = 0;
            

            for(int i = 0; i < nums.Length; i++)
            {
                if (i + 1 <= nums.Length - 1)
                {
                    if (nums[i] + 1 == nums[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        countOfSequences.Add(counter + 1);
                        counter = 0;

                    }
                }
                else
                {
                    if(counter > 0)
                    {
                        countOfSequences.Add(counter + 1);

                    }

                }
               
            }

            
            return countOfSequences.Max();
        }
    }

    public static class OptSolution
    {
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> numbersSet = new HashSet<int>();
            numbersSet = nums.ToHashSet();

            int longestStreak = 0;

            foreach(int num in numbersSet)
            {
                if(!numbersSet.Contains(num - 1))
                {
                    int currentNumber = num;
                    int currentStreak = 1;


                    while (numbersSet.Contains(currentNumber + 1))
                    {
                        currentStreak++;
                        currentNumber++;                         
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }
    }
}
