using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCarEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Prim and Proper Events *****\n");  

            Car c1 = new Car("Slug Bug", 100, 10);
            //  Register event handlers.
            EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarIsAlmostDoomed);
            EventHandler<CarEventArgs> b = new EventHandler<CarEventArgs>(CarAboutToBlow);
            EventHandler<CarEventArgs> e = new EventHandler<CarEventArgs>(CarExploded);
            c1.AboutToBlow += d;
            c1.AboutToBlow += b;
            c1.Exploded += e;

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.Exploded -= e;

            Console.WriteLine("\n***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }
        public static void CarAboutToBlow(object sender, CarEventArgs e)
        {
            //  Just to be safe, perform a runtime check before casting.
            if (sender is Car c)
            {
                Console.WriteLine("{0} says: {1}", c.PetName, e.msg);
            }
        }

        public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine("{0} says: {1}", c.PetName, e.msg);
            }
        }

        public static void CarExploded(object sender, CarEventArgs e)
        {
            if (sender is Car c)
            {
                Console.WriteLine("{0} says: {1}", c.PetName, e.msg);
            }
        }
    }
}
