using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Slug Bug", 100, 10);
            //  Register event handlers.
            c1.AboutToBlow += CarIsAlmostDoomed;
            c1.AboutToBlow += CarAboutToBlow;
            c1.Exploded += CarExploded;

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            c1.Exploded -= CarExploded;

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
            if(sender is Car c)
            {
                Console.WriteLine("{0} says: {1}", c.PetName, e.msg);
            }
        }

        public static void CarExploded(object sender, CarEventArgs e)
        {
            if(sender is Car c)
            {
                Console.WriteLine("{0} says: {1}", c.PetName, e.msg);
            }
        }
    }
}
