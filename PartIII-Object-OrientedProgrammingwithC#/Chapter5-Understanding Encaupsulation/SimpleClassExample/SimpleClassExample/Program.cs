using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            //  Allocate and configure a Car object.
            Car myCar = new Car();

            //  Invoking the default constructor.
            Car chuck = new Car();

            //  Prints "Chuck is going 10 MPH.
            chuck.PrintState();
            Console.WriteLine();

            //  Make a car called Mary going 0 MPH.
            Car mary = new Car("Mary");
            mary.PrintState();
            Console.WriteLine();

            //  Make a car called Daisy going 75 MPH.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
            Console.WriteLine();

            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            //  Speed up the car a few times and print out the new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            //  Must allocate calss objects with 'new' keyword.
            //  Compiler error! Forgot to use 'new' to create object!
            //Car myCar2;
            //myCar2.petName = "Fred";

            //  Can define and allocate on seperate lines.
            Car myCar2;
            myCar2 = new Car();
            myCar2.petName = "Fred";

            //MotorCycle mc = new MotorCycle();
            //mc.PopAWheely();

            ////  Make a motorcycle with a rider named Tiny?
            //MotorCycle c = new MotorCycle(5);
            //c.SetDriverName("Tiny");
            //c.PopAWheely();
            //Console.WriteLine("Rider name is {0}", c.driverName); //  Prints an empty name value!

            //  driverName = "", driverIntensity = 0
            MotorCycle m1 = new MotorCycle();
            Console.WriteLine("Name = {0}, Intensity = {1}", m1.driverName, m1.driverIntensity);
            Console.WriteLine();

            //  driverName = "Tiny", driverIntensity = 0
            MotorCycle m2 = new MotorCycle(name: "Tiny");
            Console.WriteLine("Name = {0}, Intensity = {1}", m2.driverName, m2.driverIntensity);
            Console.WriteLine();

            //  driverName = "", driverIntensity = 7
            MotorCycle m3 = new MotorCycle(7);
            Console.WriteLine("Name = {0}, Intensity = {1}", m3.driverName, m3.driverIntensity);
        }
    }
}
