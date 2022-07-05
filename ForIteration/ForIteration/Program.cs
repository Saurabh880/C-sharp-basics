using System;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("We are at 7");
                    break;
                }
            }

            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
