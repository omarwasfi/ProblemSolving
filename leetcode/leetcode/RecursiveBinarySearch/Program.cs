using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,12,13 }, 0 , 13-1 ,  4));

            //BinarySearch(new List<int>() { 1,2,3,4,5,6,7,8,9,10,11 } , 2);

        }

        static bool BinarySearch(List<int> numbers, int left , int right, int target)
        {
            if (left <= right)
            {
                int mid = left + ((right - left) / 2);

                if (numbers[mid] == target)
                {
                    return true;
                }
                else if (numbers[mid] > target)
                {
                    return BinarySearch(numbers, left, mid - 1, target);
                }
                else
                {
                    return BinarySearch(numbers, mid + 1, right , target);
                }
            }
            else
                return false;
        }


        static bool BinarySearch1(List<int> numbers , int target)
        {
            if (numbers.Count == 0)
                return false;

            int midIndex = numbers.Count / 2;

            if (numbers[midIndex] == target)
                return true;
            else if (numbers[midIndex] < target)
            {

                /*int count = new int();
                if (numbers.Count % 2 != 0)
                    count = (numbers.Count / 2) - 1;
                else
                    count = (numbers.Count / 2);*/


                List<int> newList = new List<int>();
                newList = numbers.Skip((numbers.Count - 1) - ( numbers.Count / 2) ).ToList();
                
                return BinarySearch1(newList , target);
                //return BinarySearch(numbers.GetRange(0, count), target);

            }
            else
            {
                /*int count = new int();
                if (numbers.Count % 2 == 0)
                    count = (numbers.Count / 2) - 1 ;
                else
                    count = (numbers.Count / 2);

                return BinarySearch(numbers.GetRange((numbers.Count / 2) + 1 , count ), target);*/


                List<int> newList = new List<int>();
                newList = numbers.SkipLast((numbers.Count - 1) - (numbers.Count / 2) ).ToList();

                return BinarySearch1(newList, target);
            }

        }
    }
}