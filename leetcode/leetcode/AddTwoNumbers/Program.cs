
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> results = Solution2.AddTwoNumbers(new List<int>() { 9, 9, 9, 9, 9, 9, 9 }, new List<int>() { 9, 9, 9, 9 });

            foreach(int i in results)
            {
                Console.Write(i + " ");
            }

        }
    }

    public static class Solution
    {
        public static List<int> AddTwoNumbers(List<int> l1, List<int> l2)
        {
            string firstNumber = "";
            string secondNumber = "" ;

            for(int i = l1.Count - 1; i >= 0; i--)
            {
                firstNumber += l1[i].ToString();
            }

            for (int i = l2.Count - 1; i >= 0; i--)
            {
                secondNumber += l2[i].ToString();
            }

            int num1 = int.Parse(firstNumber);
            int num2 = int.Parse(secondNumber);

            int sum = num1 + num2;

            string sumString = sum.ToString();



            List<int> resultList = new List<int>();
            for(int i = sumString.Length - 1 ; i >= 0; i--)
            {
                resultList.Add(int.Parse(sumString[i].ToString()));
            }



            return resultList;
        }
    }

    public static class Solution2
    {
        public static List<int> AddTwoNumbers(List<int> l1, List<int> l2)
        {
            
            List<int> resultList = new List<int>();

            int[] longerList;
            int[] shorterList;

            if(l1.Count  > l2.Count)
            {
                longerList = l1.ToArray();
                shorterList = l2.ToArray();
            }
            else if(l1.Count < l2.Count)
            {
                longerList = l2.ToArray();
                shorterList = l1.ToArray();
            }
            else
            {
                longerList = l1.ToArray();
                shorterList = l2.ToArray();
            }

            Array.Reverse(longerList);
            Array.Reverse(shorterList);


            bool doWeHaveACarry = false;
            for(int i = 0; i <= longerList.Length - 1; i++)
            {
                int sum = new int();
                if (i > shorterList.Length - 1)
                {
                     sum = longerList[i];
                }
                else
                {
                    sum = longerList[i] + shorterList[i];
                }

                if (doWeHaveACarry)
                {
                    sum++;
                    doWeHaveACarry = false;
                }

                if (sum < 10)
                {
                    
                    resultList.Add(sum);

                }
                else
                {
                    resultList.Add(sum - 10);

                    doWeHaveACarry = true;

                }

                if (i == longerList.Length - 1 && doWeHaveACarry == true)
                    resultList.Add(1);
            }


            return resultList;
        }
    }


}