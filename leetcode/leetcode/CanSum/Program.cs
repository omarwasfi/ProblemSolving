using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanSum(30030, new List<int>() { 9,8,67}));

            
        }

        public static bool CanSum(int TargetSum, List<int> Numbers , Dictionary<int,bool> Memo = null)
        {
            if (TargetSum == 0) return true;
            if (TargetSum < 0) return false;
            if (Memo == null) Memo = new Dictionary<int, bool>();
            if (Memo.ContainsKey(TargetSum))
                return Memo[TargetSum];

            foreach (int number in Numbers)
            {
                
                int reminder = TargetSum - number;
                if(CanSum(reminder, Numbers) == true)
                {
                    Memo.Add(TargetSum, true);
                    return true;
                }
            }

            Memo.Add(TargetSum, false);
            return false;
        }
    }



    
}

