using System;
using System.Collections;

namespace Question
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2, 2, 2, 3 };
            FrequencySort(nums);

            //int[] nums = new int[]{ 0, 2, 1, 5, 3, 4 };
            //BuildArray(nums);
            //SingleNumber(nums);

            //int start = 0;
            //int destination = 3;
            //int[] distance = new int[] { 1, 2, 3, 4 };
            //DistanceBetweenBusStops(distance, start, destination);

            Console.ReadLine();
            //int[] heights = new int[] { 1,1,4,2,1,3};
            //HeightChecker(heights);
            //leet code 1748
            //int[] arr = new int[] { 7, 1, 5, 3, 6, 4 };

            //int[] arr = new int[] { 1, 2, 2, 3 };

            //int[] freq = new int[arr.Length];
            //int[] finalArr = new int[arr.Length];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    freq[arr[i]]++;
            //}
            //int sum = 0;
            //for (int i = 0; i < freq.Length; i++)
            //{

            //    if (freq[i] == 1)
            //    {
            //        sum = sum + i;
            //    }
            //}
            //Console.WriteLine("\n" + sum);
        }

        //leet code 1051
        public static int HeightChecker(int[] heights)
        {
            int[] expected = new int[heights.Length];
            Array.Copy(heights, expected, heights.Length);
            Array.Sort(expected);
            int sum = 0;
            foreach (var item in expected)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                    sum++;
            }
            Console.WriteLine(sum);
            return sum;
        }
        
        //leet code 1184
        public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {

            int shortd = 0;
            int longd = 0;

            for (int i = 0; i < distance.Length; i++)
            {
                shortd += distance[i];
                if (destination == distance[i])
                {
                    Console.WriteLine("Shot distance is :" + shortd);
                }
            }

            for (int i = distance.Length - 1; i > 0; i--)
            {
                longd += distance[i];
                if (destination == distance[i])
                {
                    Console.WriteLine("Long distance is : " + longd);
                }
            }

            if (shortd<longd)
            {
                Console.WriteLine("shortd is smaller :" + shortd);
            }
            else
            {
                Console.WriteLine("longd is smaller :" + longd);
            }
            int output = Math.Min(shortd,longd)==0?1: Math.Min(shortd, longd);
            Console.WriteLine("Output is : "+output);
            return output;
        }

        public static int SingleNumber(int[] nums)
        {
            int[] freq = new int[nums.Length];
            int output = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(freq[i]);
                if (freq[i] == 1)
                {
                    output = i;
                }
            }
            Console.WriteLine(output);
            return output;
        }

        public static int[] BuildArray(int[] nums)
        {
            int[] output = new int[nums.Length];

            for (int i= 0; i < nums.Length; i++)
            {
                output[i] = nums[nums[i]];
            }
            return output;
        }

        public static int[] FrequencySort(int[] nums)
        {
            int[] arr = new int[nums.Length];
            int[] freq = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(freq[i]);
            }

            return arr;
        }
    }
}


