using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 10));
        }

        static int Add(int x, int y)
        {
            //  Do some validation.
            return Add();
            int Add()
            {
                return x + y;
            }
        }
    }
}
