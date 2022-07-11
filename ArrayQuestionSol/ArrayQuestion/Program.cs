using System;

namespace ArrayQuestion
{
    class Program
    {
        //leet code 1365
        //public static int[] SmallerNumbersThanCurrent(int[] nums)
        //{
        //int[] endArr = new int[nums.Length];

        //    Console.WriteLine("Num length is :", endArr.Length);
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int temp = 0;
        //        for (int j = 0; j < nums.Length; j++)
        //        {
        //            if (nums[i]>nums[j])
        //            {
        //                temp++;
        //            }
        //        }
        //        endArr[i] = temp;

        //    }
        //    foreach (var item in endArr)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    return endArr;
        //}
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

            int[] nums = new int[] { 8, 1, 2, 2, 3 };
            //SmallerNumbersThanCurrent(nums);

            //Console.WriteLine(Sum(7, 5));

            //code to reverse an string usinh Char array
            //string name = "saurabh mishra";
            //char[] charArray = name.ToCharArray();
            //Array.Reverse(charArray);
            //foreach (char item in charArray)
            //{
            //    Console.Write(item);
            //}

            //string s = "x++";
            //char ch = s[0];

            //if (ch == 'x') 
            //{
            //    Console.WriteLine("first char is x");
            //    ch = s[1];
            //}

            //Fibonacci series
            /*
            int n = int.Parse(Console.ReadLine());
            int previous = 0;
            int current = 1;
            int count = 2;

            while (count <= n)
            {
                int temp = current;
                current = current + previous;
                previous = temp;//current is assigned to previous
                count++;
            }
            Console.WriteLine(current);
            */

            //Find a number (target) occurance in a number
            /*
            int n = 1787742;
            int target = int.Parse(Console.ReadLine()); ;
            int count = 0;
            int reminder;
            while (n > 0)
            {
                reminder = n % 10;
                if(reminder == target)
                {
                    count++;
                }
                n /= 10;
            }
            Console.WriteLine(count);
            */

            //Reverse a number
            /*
            int n = 457632;
            int answer = 0;
            int reminder;

            while (n > 0)
            {
                reminder = n % 10;
                answer = (answer * 10) + reminder;
                n /= 10;
                
            }
            Console.WriteLine(answer);
            */


            // reverse a string
            /*
            string country = "India";
            int length = country.Length - 1;
            string rev = "";
            for (int i = length; i >=0; i--)
            {
                rev = rev + country[i];
            }
            Console.WriteLine(rev);
            */


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