using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> list = new List<int>() {  800,544,1000,5,6,7,2,4,7,5,33,22,1,20, 45, 5, 5, 5, 4, 4, 4, 44,  3,  21, 4, 44, 33, 1, 0 };


            list = MergeSort(list);

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

        }

        static List<int> MergeSort(List<int> nums)
        {
            if(nums.Count <= 1)
            {
                return nums;
            }

            List<int> LeftList = new List<int>();
            List<int> RightList = new List<int>();

            int mid = nums.Count / 2;
            int otherMid = nums.Count - mid;

            LeftList = nums.SkipLast(mid).ToList();
            LeftList = MergeSort(LeftList);

            RightList = nums.Skip(otherMid).ToList();
            RightList = MergeSort(RightList);

            int leftIndex = 0;
            int rightIndex = 0;

            List<int> sortedNumbers = new List<int>();

            while(leftIndex != LeftList.Count  && rightIndex != RightList.Count )
            {
                if (LeftList[leftIndex] < RightList[rightIndex])
                {
                    sortedNumbers.Add(LeftList[leftIndex]);
                    leftIndex++;
                }
                else
                {

                    sortedNumbers.Add(RightList[rightIndex]);
                    rightIndex++;
                }
            }


            for(int i = leftIndex; i < LeftList.Count; i++)
            {
                sortedNumbers.Add(LeftList[i]);

            }
            for (int i = rightIndex; i < RightList.Count; i++)
            {
                sortedNumbers.Add(RightList[i]);
            }



            return sortedNumbers;
        }
    }


}