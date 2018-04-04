using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Sorting *****\n");

            //  Make an array of Car objects.
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[0] = new Car("Mary", 40, 234);
            myAutos[0] = new Car("Viper", 40, 34);
            myAutos[0] = new Car("Mel", 40, 4);
            myAutos[0] = new Car("Chucky", 40, 5);
        }
    }
}
