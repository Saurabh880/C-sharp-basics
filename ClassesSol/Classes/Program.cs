using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Mahindra";
            myCar.Model = "XUV700";
            myCar.Year = 2022;
            myCar.Color = "Midnight Blue";
                                   
            Console.WriteLine("Car details are : {0} {1} {2}, Comapany : {3} ", myCar.Model, myCar.Year, myCar.Color, myCar.Make);
            Console.WriteLine("{0:N}",myCar.DetermineMarketValue());

            //Airplain B1 = new Airplain();
            //B1.Company = "Boeing";
            //B1.type = "Transport Carrier";
            //B1.CabinCrew = 6;
            //Console.WriteLine("Enter your name");

            //string name = Console.ReadLine();
            //B1.WelcomeMessage(name);

            //Airplain M1 = new Airplain();
            //M1.type = "Fighter jet MIG-21";
            //M1.Company = "Mikoyan-Gurevich";
            //M1.CabinCrew = 1;
            //M1.FighterJet(M1.type);

            Console.ReadLine();
        }
            
    }
    class Airplain
    {
        public string Company { get; set; }
        public string type { get; set; }
        public int CabinCrew { get; set; }

        public void WelcomeMessage(string USERNAME)
        {
            Console.WriteLine("{0}, welcomes you {1}", Company, USERNAME);
        }

        public bool FighterJet(string s)
        {
            if (s.Contains("MIG"))
            {
                Console.WriteLine("We are looking at fighter jet! Awsome");
            }
            return true;
        }
    }
    class Car
    {
        //class is the blue print and object is instantiation 
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public  decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year >= 2022)
            {
                carValue = 22000;
            }
            else 
                carValue = 15000;
            return carValue;
        }
    }
}
