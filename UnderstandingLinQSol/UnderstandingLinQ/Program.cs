using System;
using System.Collections.Generic;
using System.Linq;

namespace UnderstandingLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Car> MyCar = new List<Car>()
            {
                new Car(){VIN="A1",Make ="BMW",model="550I",Year=2008,StickerPrice=55000},
                new Car(){VIN = "T2",Make="Toyota",model="4Runner",Year=2012,StickerPrice=32000},
                new Car(){VIN="F1",Make="Ford",model="escape",StickerPrice=25000,Year=2010},
                new Car(){VIN="A5",Make="BMW",model="X5",Year=2018,StickerPrice=50000},
                new Car(){VIN="M2",Make="Mahindra",model="XUV700",StickerPrice=45000,Year=2022},
                new Car(){VIN="K2",Make="Kia",model="Seltos",Year=2020,StickerPrice=40000},
            };

            //LINQ query syntax
            /*
            var bmws = from car in MyCar
                       where car.Make == "BMW"
                       && car.Year == 2018
                       select car;

           
            var orderCar = from car in MyCar
                           orderby car.Year descending
                           select car;
             */


            //Lambda  experssiom
            //Linq method syntax
            //var bmws = MyCar.Where(p => p.Make == "Kia");
            //above one is filter query 

            //var orderCar = MyCar.OrderByDescending(p => p.Year);
            //Given each item in our collection we want to order by year property

            MyCar.ForEach(p => Console.WriteLine("{0} : {1}", p.Make, p.model));

            Console.(MyCar.Exists(p => p.Make == "maruti"));
            //foreach (var cars in orderCar)
            //{
            //    Console.WriteLine("{0} : {1} : Year : {2}",cars.model,cars.VIN,cars.Year);
            //}
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public string VIN { get; set; }
    }
}
