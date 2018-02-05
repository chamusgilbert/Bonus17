using System;

namespace Bonus17
{
    class Car
    {
        public string make;
        public string model;
        public int year;
        public double price;
        public string carInfo;

        public Car()
        {
            this.make = makeMake();
            this.model = makeModel();
            this.year = makeYear();
            this.price = makePrice();
            this.carInfo = string.Format("{0,10}  {1,10}  {2,4}   {3,15}", make, model, year, price);
            Console.WriteLine(carInfo);
        }

        public static string makeMake()
        {
            Console.WriteLine("please enter the make of the car");
            string methodMake = Console.ReadLine().ToLower();
            return methodMake;
        }
        public static string makeModel()
        {
            Console.WriteLine("please enter the model of the car");
            string methodModel = Console.ReadLine().ToLower();
            return methodModel;
        }
        public static int makeYear()
        {
            Console.WriteLine("please enter the Year of the car");
            bool works = int.TryParse(Console.ReadLine(), out int methodYear);
            if (works = false || methodYear < 1400 || methodYear > 9999)
            {
                Console.WriteLine("Please enter a proper Year");
                makeYear();
            }

            return methodYear;

        }
        public static double makePrice()
        {
            Console.WriteLine("please enter the Price of the car");
            bool works = double.TryParse(Console.ReadLine(), out double methodPrice);
            if (works = false || methodPrice < 0)
            {
                Console.WriteLine("Please enter a proper Price");
                makePrice();
            }

            return methodPrice;


        }
    }
}
