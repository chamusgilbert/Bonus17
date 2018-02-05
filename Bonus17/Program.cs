using System;
using System.Collections.Generic;

namespace Bonus17
{
    class Program
    {
        static void Main()
        {



            Console.WriteLine("Hello, How many cars would you like to submit?");
            bool works = int.TryParse(Console.ReadLine(), out int howMany);
            if (works == false)
            {
                Console.WriteLine("Try again");
                Main();
            }
            Car[] myCars = new Car[howMany];
            List<Car> ListofCars = new List<Car>();

            for (int i = 0; i < howMany; i++)
            {
                myCars[i] = new Car();
                ListofCars.Add(myCars[i]);
            }

            foreach (Car item in ListofCars)
            {
                Console.WriteLine(item.carInfo);
            }

        }
    }
}
