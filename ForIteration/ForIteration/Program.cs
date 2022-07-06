using System;


namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Simple for loop with break statement
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
            */

            /*
             * nested loop example, every time outerloop runs the inner loop runs 4 times
            int outerLoop=0, innerLoop = 0;
            for (int i = 0; i < 5; i++)
            {
                outerLoop++;
                for (int j = 0; j < 4; j++)
                {
                    innerLoop++;
                }

            }
            Console.WriteLine("Outer loop run {0} time :", outerLoop);
            Console.WriteLine("Inner loop run {0} time :", innerLoop);
            */

            /*
             * pattern using for loop
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            */


            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }

            //    Console.WriteLine();
            //    i++;
            //}

            /*
         
             //Multi D array with 2 rows and 3 columns 
              
            int[,] MultiDArr = { { 1, 2, 3 }, { 4, 5, 6 } };

            //numbers.GetLength(0) - gives the number of rows in a 2D array
            for (int i = 0; i < MultiDArr.GetLength(0); i++)
            {
                Console.Write("Row : " + i + " - ");

            //numbers.GetLength(1) - gives the number of elements in the row
                for (int j = 0; j < MultiDArr.GetLength(1); j++)
                {
                    Console.Write(MultiDArr[i, j] + " ");
                }Console.WriteLine();
            }
            */
             Console.ReadLine();
        }
    }

}
