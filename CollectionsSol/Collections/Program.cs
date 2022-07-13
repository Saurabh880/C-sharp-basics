using System;
using System.Collections.Generic;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //leet code 628
            /*
            int[] nums =new int[] { -1,-2,-3,1,2,3};
            int max1 = Int32.MinValue, max2 = Int32.MinValue, max3 = Int32.MinValue, min1 = Int32.MaxValue, min2 = Int32.MaxValue;
            foreach (var item in nums)
            {
                if(item >=max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = item;
                }
                else if(item >= max2)
                {
                    max3 = max2;
                    max2 = item;
                }
                else if (item >= max3)
                {
                    max3 = item;
                }

                //find min1 and min2
                if(item<= min1)
                {
                    min2 = min1;
                    min1 = item;
                }
                else if(item<=min2)
                {
                    min2 = item;
                }

                
            }
            int output1 = Math.Max(max1 * max2 * max3, max1 * min1 * min2);

            Array.Sort(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            int output= Math.Max(nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3], nums[nums.Length - 1] * nums[0] * nums[1]);
            Console.WriteLine(output);
            */


            //to check for sorted array
            /*
            //int[] arr = new int[] { 1, 4, 3, 2, 5 };
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //int[] arr = new int[] { 1, 4, 3, 2, 5 ,0};
            int[] arr = new int[] {-2,-1,0,-10,1 };
            int[] sorted = new int[5];
            bool isSorted=false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length-1; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        isSorted = true;
                    }
                    
                }
                
            }
            Console.WriteLine(isSorted);
        */


            /*
            //List
            var Phone = new List<string>() { "Samsung","Apple","OnePlus","Nokia"};
            //Phone.Add("OnePlus");
            //Phone.Add("Nokia");
            //Phone.Add("Apple");
            foreach (var item in Phone)
            {
                Console.WriteLine(item);
            }
            var numbers = new List<int>() { 2, 1, 5, 4, 7, 9, 0, 3, };
            for(int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i]%2 == 1)
                {
                    numbers.RemoveAt(i);
                }
            }
            //numbers.ForEach(numbers => Console.WriteLine(numbers + " "));

            //Dictionary< Tkey, Tvalue) -- > data type of Key, Key is unique
            // Hashtable in C#

            Hashtable ht = new Hashtable();
            ht.Add(1, "Tom");
            ht.Add(2, "Sam");
            ht.Add(3, "Alex");
            ht.Add(4, "Tom");

            ICollection keys = ht.Keys;

            //prinitng keys and values

            foreach (int key in ht.Keys)
            {
                Console.WriteLine(key+ " : " +ht[key]);
                //Console.WriteLine($"key : {key} | value : {ht[key]}");
            }

            */

            /*
            int[] arr1 = new int[] { 1, 2, 3, 1, 1, 3 };
            //Console.WriteLine(arr[1]);
            Hashtable integers = new Hashtable();
            for (int i = 0; i < arr1.Length; i++)
            {
                integers.Add(i, arr1[i]);
            }
            foreach (object obj in integers.Keys)
            {
                Console.WriteLine(obj + " : " + integers[obj]);
            }

            for (int i = 0; i < integers.Count; i++)
            {

            }
            */

        }
    }


}
