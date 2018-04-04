using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Dispose *****\n");

            //  Create a disoposable object and call Dispose()
            //  to free any internal resources.
            //  Using "using" keyword, Dispose() is called automatically
            //  when the "using" scope exits.
            using (MyResourceWrapper rw = new MyResourceWrapper(),
                rw2 = new MyResourceWrapper())
            {
                //  use the members of rw.
            }
            Console.ReadLine();
        }

        static void DisposeFileSteam()
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);

            //  Confusing, to say the least!
            //  These method calls do the same thing!
            fs.Close();
            fs.Dispose();
        }
    }
}
