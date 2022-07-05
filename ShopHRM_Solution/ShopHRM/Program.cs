using System;

namespace ShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            do
            {
                Console.WriteLine("Choose the action you want to select");
                Console.WriteLine("1. Add Employee details");
                Console.WriteLine("2. update Employee details");
                Console.WriteLine("3. Delete Emoployee details");
                Console.WriteLine("99. Exit application");

                //use int.parse and them Console.ReadLine to take the int input
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Adding new employee..");
                        break;
                    case 2:
                        Console.WriteLine("Updating employee details...");
                        break;
                    case 3:
                        Console.WriteLine("Deleting employee details...");
                        break;
                    case 4:
                        Console.WriteLine("Invalid input");
                        break;
                    default:
                        break;
                }
            } while (userInput != 99);
            Console.WriteLine("Closing app");
            Console.ReadLine();
        }
    }
}
