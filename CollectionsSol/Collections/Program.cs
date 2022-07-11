using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
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
            numbers.ForEach(numbers => Console.WriteLine(numbers + " "));

            //Dictionary< Tkey, Tvalue) -- > data type of Key, Key is unique


        }
    }
}
