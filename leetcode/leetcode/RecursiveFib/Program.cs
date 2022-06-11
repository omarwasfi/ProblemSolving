using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


            Console.WriteLine(solution.CalculateFib(50));
        }


    }

    public class Solution
    {
        public long CalculateFib(int number, Dictionary<int, long>? memo = null)
        {

            if (memo == null) memo = new Dictionary<int, long>();

            if (memo.ContainsKey(number) == true)
            {

                return memo[number];
            }


            if (number <= 2)
                return 1;

            memo.Add(number, CalculateFib(number - 1 , memo) + CalculateFib(number - 2,memo));

            return memo[number];
        }
    }
}