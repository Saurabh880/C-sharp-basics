using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 1 };
            containsDuplicate(arr);
            Console.ReadLine();
        }

        private static bool containsDuplicate(int[] nums)
        {
            int length = nums.Length;
            bool distinct = false;
            
            for (int i = 0; i < length-1 ; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    distinct = true;
                }
            }
            Console.WriteLine(distinct);
            return distinct;
        }
    }
}
