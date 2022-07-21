using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 3, 5 };
            int size = arr.Length;
            int target = 3;
            //Binary search completed
            int start = 0;
            int end = arr.Length - 1;
            // use below mid as this will give you correct value and ignoren2^31 -1 out of bound error
            int mid = start + (end - start) / 2;
            int ans = -1;
            while (start < end)
            {
                if (arr[mid] == target)
                {
                    ans = mid;
                    end = mid - 1;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else if(arr[mid] < target)
                {
                    start = mid + 1;
                }
                mid = start + (end - start) / 2;
            }
            Console.WriteLine("first occurence of 3 is at index",ans);
        }
    }
}
