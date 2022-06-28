using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> results = HowSum(300, new List<int>() { 6, 6, 67 });

            if(results != null)
            {
                foreach (int i in results)
                {
                    Console.WriteLine(i);

                }

            }
            else
            {
                Console.WriteLine("Null");

            }
            

        }

        public static List<int> HowSum(int TargetSum, List<int> Numbers, Dictionary<int, List<int>> Memo = null)
        {
            if (TargetSum == 0) return new List<int>();
            if (TargetSum < 0) return null;
            if (Memo == null) Memo = new Dictionary<int, List<int>>();
            if (Memo.ContainsKey(TargetSum))
                return Memo[TargetSum];

            foreach (int number in Numbers)
            {

                int reminder = TargetSum - number;
                if (HowSum(reminder, Numbers) != null)
                {
                    Memo.Add(TargetSum, HowSum(reminder, Numbers));

                    List<int> currentResults = HowSum(reminder, Numbers);
                    currentResults.Add(number);
                    return currentResults;
                }
            }

            Memo.Add(TargetSum, null);
            return null;
        }
    }




}

