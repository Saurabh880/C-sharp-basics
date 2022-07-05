using System;

namespace ArrayUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,3,4,6};
            //Console.WriteLine(arr[1]);
            string[] names = new string[] { "ram","tom","cat","dog"};
            //Console.WriteLine(names[3]);
            /*
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            */
            string name = "saurabh mishra";
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            foreach (char item in charArray)
            {
                Console.Write(item);
            }
            {

            }
        }
    }
}
