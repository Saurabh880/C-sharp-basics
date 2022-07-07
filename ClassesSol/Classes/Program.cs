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
            
            Console.ReadLine();
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
