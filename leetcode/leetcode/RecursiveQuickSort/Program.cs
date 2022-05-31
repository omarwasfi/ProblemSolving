using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> list = new List<int>() { 5,4,3,7497,21,4,44,33,1 ,0};


            list =  QuickSort(list);

            foreach(int i in list)
            {
                Console.Write(i + " ");
            }

        }


        static List<int> QuickSort(List<int> nums)
        {

            int pivot = nums[0];

            List<int> GreaterList = new List<int>();
            List<int> LesserList = new List<int>();

            for( int i = 1; i< nums.Count; i++)
            {
                if (nums[i] <= pivot)
                {
                    LesserList.Add(nums[i]);

                    LesserList = QuickSort(LesserList);
                }
                else
                {
                    GreaterList.Add(nums[i]);

                    GreaterList = QuickSort(GreaterList);
                }
            }

            nums = LesserList;
            nums.Add(pivot);
            nums.AddRange(GreaterList);

            

            return nums;
        }



    }
}