using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
    
            //  Add two shorts and print the result.
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

            //  Compiler error below!
            short num1 = 30000, num2 = 30000;
            //  Expicitly cast the int into a short(and allow loss of data).
            //  short answer = (short)Add(num1, num2);

            //  Console.WriteLine("{0} + {1} = {2}", num1, num2, answer);

            //  Another compiler error!
            NarrowingAttempt();

            ProcessBytes();

            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            //  Explicitly cast the int into a byte(no loss of data).
            myByte = (byte)myInt;

            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                //  byte sum = checked((byte)Add(b1, b2));
                //  Console.WriteLine("sum = {0}", sum);
                //checked
                //{
                //    byte sum = (byte)Add(b1, b2);
                //    Console.WriteLine("sum = {0}", sum);
                //}
                //  Assuming /checked is enabled, this block will not trigger
                //  a runtime exception.
                unchecked
                {
                    byte sum = (byte)(b1 + b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //  Sum should hold the value 350. However, we find the value 94!
            //  Console.WriteLine("sum = {0}", sum);
        }
    }
}
