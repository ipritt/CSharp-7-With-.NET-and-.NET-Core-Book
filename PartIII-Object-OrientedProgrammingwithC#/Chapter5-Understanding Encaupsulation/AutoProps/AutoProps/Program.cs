using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";

            Console.WriteLine("Your car is named {0}? That's odd...", c.PetName);
            c.DisplayStats();

            Garage g = new Garage();

            //  OK, prints default value of zero.
            Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);

            //  Runtime error! Backing field is currently null!
            //Console.WriteLine(g.MyAuto.PetName);

            g.MyAuto = c;
            Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);
        }
    }
}
