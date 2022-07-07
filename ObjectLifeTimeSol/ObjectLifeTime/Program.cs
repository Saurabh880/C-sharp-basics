using System;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 4, 2, 6, 8, 1, 0 };
            //SelectionSort(arr);
            
            //int[] arr = new int[] { 10,2,7,11,15};
           // int target = 9;
            //if (TwoSum(arr, 9))
            //{
            //    Console.WriteLine("Valid pair exists");
            //}
            //else
            //{
            //    Console.WriteLine("No valid pair exists for " + target);
            //}


            Console.ReadLine();
        }

        private static void SelectionSort(int[] nums)
        {


            for (int i = 0; i < nums.Length - 1; i++)
            {
                int MinValue = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[MinValue])
                        MinValue = j;
                }
                int temap = nums[i];
                nums[i] = nums[MinValue];
                nums[MinValue] = temap;

            }
            foreach (var items in nums)
            {
                Console.WriteLine(items);
            }
        }
        public static bool TwoSum(int[] nums, int target)
        {
            //[2,7,11,15]
            int[] indices = new int[2];
            int size = nums.Length;
            for (int i = 0; i < (size - 1); i++)
            {
                for (int j = (i + 1); j < size; j++)
                {
                    
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("Pair with a given sum " + target +
                                           " is (" + nums[i] + ", " + nums[j] + ")");
                        indices[0] = Array.IndexOf(nums, nums[i]);
                        indices[1] = j;
                        Console.WriteLine(indices[0]);
                        Console.WriteLine(indices[1]);
                        return true;
                    }
                }

               
            }
            
            return false;
        }
    }
}
