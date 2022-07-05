using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lucky Giveaway");
            Console.WriteLine("Select a number form 0,1 or 2");
            /*
            string userInput = Console.ReadLine();
            string message = "";
            // == is for comapring values
            
            if(userInput == "1")
            {
                message = "You've won a car!!";
                
            }
            else if(userInput == "2")
            {
                message ="you have won a bike";
            }
            else if(userInput == "0")
            {
                message = "Better luck next time";
            }
            else
            {
                message = "wrong input";
            }
            Console.WriteLine("you entered : {0}, therefore you have won {1} ",userInput,message);
            Console.ReadLine();

            string WinnerValue = (userInput == "1") ? "Hit a Jackpot" : "Naah";
            Console.WriteLine(WinnerValue);
            */
            int userValue = 11;
            switch (userValue)
            {
                case 1: Console.WriteLine("Inside first case");
                    break;
                case 2: Console.WriteLine("Case 2");
                    break;
                case 11: Console.WriteLine("case 11");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
