using System;

namespace Strings
{
    class Program
    {
        public static void UsingEscapeChar()
        {
            //Adding escape character in string 
            string FirstName = "Samuel";
            string LastName = "jackson";

            string displayName = $"Hello, \n{FirstName}\t{LastName} ";

            //using double quotes inside string
            //string myString = "my \"So-called\" life";

            //Formatting string {0:N},{0:P}
            string Numbers = string.Format("{0:N}" , 123456789);

            //to create own format use zero and use # symbol to represent each digit we want to foramt
            string PhoneNumber = string.Format("Phone number : {0: (##) #####-#####}", 919509527612);
            Console.WriteLine(PhoneNumber);
        }
        static void Main(string[] args)
        {
            /*
            string FirstName = "Samuel";
            string LastName = "jackson";
            //changes to lower case
            var username = FirstName.ToLower();

            string fullName = FirstName + " " + LastName;
            string employeeName = String.Concat(fullName, LastName);

            string EnterName = Console.ReadLine();
            // to check if String contains certain word
            if (EnterName.Contains("sam") || EnterName.Contains("Sam")){
                Console.WriteLine("It's Samuel");
            }

            //get a part of string from defined length
            string subString = fullName.Substring(1, 4);
            Console.WriteLine("Characters 2 to 5 are :" + subString);

            int age = 23;
            string companyName = "LTI";
            string EmployeeDetails = $"Full Name of employee is : {fullName}, his age is {age} and works in {companyName} company";
            Console.WriteLine(EmployeeDetails);
            */
           

            UsingEscapeChar();
            //adding file path in string - use double backslash or @"file path"
            
            Console.ReadLine();
        }
            
            
        }
    }

